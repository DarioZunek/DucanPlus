using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web_shop.Helpers;
using Web_shop.Models;
using Web_shop.Services;

namespace Web_shop.Pages
{
    public class ShoppingCartModel : PageModel
    {
        private readonly DucanPlusDbContext _context;
        public List<BasketItemEntity> BasketItems { get; set; } = new List<BasketItemEntity>();
        private readonly PayPalService _payPalService;
        public ShoppingCartModel(DucanPlusDbContext context, PayPalService payPalService)
        {
            _context = context;
            _payPalService = payPalService;
        }

        public (string Username, int UserId) GetUserCookies()
        {
            var httpContext = PageContext.HttpContext;
            string decryptedUsername = "";
            string decryptedUserId = "";
            int id = 0;

            if (httpContext.Request.Cookies.TryGetValue("Username", out string? encryptedUsername))
            {
                decryptedUsername = EncryptionHelper.Decrypt(encryptedUsername!);
            }

            if (httpContext.Request.Cookies.TryGetValue("UserId", out string? encryptedUserId))
            {
                decryptedUserId = EncryptionHelper.Decrypt(encryptedUserId!);
                id = int.Parse(decryptedUserId);
            }

            return (decryptedUsername, id);
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var basket = await GetUserBasketAsync();
            if (basket != null)
            {
                BasketItems = basket.Items.ToList();
            }
            return Page();
        }

        public async Task<BasketEntity?> GetUserBasketAsync()
        {
            var (username, userId) = GetUserCookies();

            if (userId <= 0)
            {
                return null;
            }

            var basket = await _context.Baskets!
                                       .Include(b => b.Items)
                                       .ThenInclude(item => item.Product)
                                       .FirstOrDefaultAsync(b => b.UserId == userId);

            return basket;
        }

        public IActionResult OnPostDeleteItem(int id)
        {
            var item = _context.BasketItems!.Find(id);
            if (item != null)
            {
                _context.BasketItems.Remove(item);
                _context.SaveChanges();
                return RedirectToPage("/ShoppingCart");
            }
            return new JsonResult(new { success = false, message = "Stavka nije pronađena." });
        }

        public async Task<IActionResult> OnPostProcessPaymentAsync(decimal amount)
        {
            try
            {
                UserEntity? userEntity = await _context.Users!.FindAsync(GetUserCookies().UserId);
                var delivery = new DeliveryEntity
                {
                    RecipientName = "",
                    Address = "",
                    PhoneNumber = "",
                    DeliveryDate = DateTime.Now,
                    Notes = "",
                    UserId = userEntity!.Id,
                    User = userEntity,
                    DeliveryItems = new List<DeliveryItemEntity>()
                };
                _context.Deliveries!.Add(delivery);
                await _context.SaveChangesAsync();

                (string Username, int UserId) = GetUserCookies();
                delivery = _context.Deliveries.Where(d => d.UserId == UserId).OrderBy(d => d.Id).Last();

                var basket = await GetUserBasketAsync();
                var basketItems = new List<BasketItemEntity>();
                if (basket != null)
                {
                    basketItems = basket.Items.ToList();
                }
                foreach (var item in basketItems)
                {
                    var deliveryItem = new DeliveryItemEntity
                    {
                        DeliveryId = delivery.Id,
                        ProductId = item.ProductId,
                        Quantity = item.Quantity
                    };
                    _context.DeliveryItems!.Add(deliveryItem);
                    await _context.SaveChangesAsync();
                }

                string encryptedId = EncryptionHelper.Encrypt(delivery.Id.ToString());
                var httpContext = PageContext.HttpContext;
                httpContext.Response.Cookies.Append("DeliveryId", encryptedId, new CookieOptions
                {
                    HttpOnly = true,
                    Secure = true,
                    Expires = DateTimeOffset.UtcNow.AddDays(7)
                });

                await _payPalService.CreateOrder(amount);

                basket = await GetUserBasketAsync();
                if (basket != null)
                {
                    _context.BasketItems!.RemoveRange(basket.Items);
                    _context.Baskets!.Remove(basket);
                    await _context.SaveChangesAsync();
                }

                TempData["PaymentSuccessfulToast"] = true;

                return RedirectToPage("/Delivery");
            }
            catch (Exception ex)
            {
                return RedirectToPage("/ShoppingCart", new { errorMessage = ex.Message });
            }
        }

    }
}
