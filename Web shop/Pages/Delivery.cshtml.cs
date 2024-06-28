using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web_shop.Helpers;
using Web_shop.Models;
using Web_shop.Services;

namespace Web_shop.Pages
{
    public class DeliveryModel : PageModel
    {
        public List<DeliveryEntity> UserDeliveries { get; set; } = new List<DeliveryEntity>();
        private readonly DucanPlusDbContext _context;
        private readonly EmailService _emailService;
        public string Username { get; set; }
        public int UserId { get; set; }
        public int DeliveryId { get; set; }
        public DeliveryModel(DucanPlusDbContext context, EmailService emailService)
        {
            _context = context;
            _emailService = emailService;
        }
        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            public string RecipientName { get; set; }
            public string Address { get; set; }
            public string PhoneNumber { get; set; }
            public DateTime DeliveryDate { get; set; }
            public string Notes { get; set; }
        }

        public (string Username, int UserId, int DeliveryId) GetUserCookies()
        {
            var httpContext = PageContext.HttpContext;
            string decryptedUsername = "";
            string decryptedUserId = "";
            string decryptedDeliveryId = "";
            int id = 0;
            int deliveryId = 0;

            if (httpContext.Request.Cookies.TryGetValue("Username", out string? encryptedUsername))
            {
                decryptedUsername = EncryptionHelper.Decrypt(encryptedUsername!);
            }

            if (httpContext.Request.Cookies.TryGetValue("UserId", out string? encryptedUserId))
            {
                decryptedUserId = EncryptionHelper.Decrypt(encryptedUserId!);
                id = int.Parse(decryptedUserId);
            }

            if (httpContext.Request.Cookies.TryGetValue("DeliveryId", out string? encryptedDeliveryId))
            {
                decryptedDeliveryId = EncryptionHelper.Decrypt(encryptedDeliveryId!);
                deliveryId = int.Parse(decryptedDeliveryId);
            }

            return (decryptedUsername, id, deliveryId);
        }
        public void OnGet()
        {
            (string Username, int UserId, int DeliveryId) userCookies = GetUserCookies();
            Username = userCookies.Username;
            UserId = userCookies.UserId;
            DeliveryId = userCookies.DeliveryId;

            UserDeliveries = _context.Deliveries!
               .Where(d => d.UserId == UserId)
               .Include(d => d.DeliveryItems)
                    .ThenInclude(di => di.Product)
               .ToList();
        }

        public IActionResult OnPostProcessDelivery()
        {
            (string Username, int UserId, int DeliveryId) userCookies = GetUserCookies();
            Username = userCookies.Username;
            UserId = userCookies.UserId;
            DeliveryId = userCookies.DeliveryId;

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var delivery = _context.Deliveries!.Find(DeliveryId);
            if (delivery == null)
            {
                return Page();
            }

            var DeliveryItems = _context.DeliveryItems!
                .Where(di => di.DeliveryId == DeliveryId)
                .Include(di => di.Product)
                .ToList();
            if (DeliveryItems.Count == 0)
            {
                return Page();
            }
            foreach (var item in DeliveryItems)
            {
                delivery.DeliveryItems.Add(item);
            }

            delivery!.RecipientName = Input.RecipientName;
            delivery.Address = Input.Address;
            delivery.PhoneNumber = Input.PhoneNumber;
            delivery.DeliveryDate = Input.DeliveryDate;
            delivery.Notes = Input.Notes;
            _context.SaveChanges();

            Response.Cookies.Delete("DeliveryId");

            string stavke = "";
            foreach (var item in DeliveryItems)
            {
                stavke += $"Proizvod: {item.Product.Name}<br>" +
                          $"Količina: {item.Quantity}<br>" +
                          $"Cijena: {item.Product.RetailPrice}<br>" +
                          $"Ukupno: {item.Quantity * item.Product.RetailPrice}<br><br>";
            }
            string mail = $"Primatelj: {delivery.RecipientName}<br>" +
                          $"Adresa: {delivery.Address}<br>" +
                          $"Broj telefona: {delivery.PhoneNumber}<br>" +
                          $"Datum dostave: {delivery.DeliveryDate}<br>" +
                          $"Napomene: {delivery.Notes}<br>" +
                          $"Stavke:<br>{stavke}";

            Task task = _emailService.SendEmailAsync("vas.ducan.plus@gmail.com", "Narudžba", mail);

            TempData["DeliverySuccessToast"] = true;

            return RedirectToPage("/Index");
        }
    }
}
