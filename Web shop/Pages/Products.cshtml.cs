using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web_shop.Helpers;
using Web_shop.Models;

namespace Web_shop.Pages
{
    public class ProductsModel : PageModel
    {
        private readonly DucanPlusDbContext _context;
        public List<ProductEntity> ProductList { get; set; }
        public string Username { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            public int ProductId { get; set; }
            public int Quantity { get; set; }
        }

        public ProductsModel(DucanPlusDbContext context)
        {
            _context = context;
            ProductList = new List<ProductEntity>();
        }

        public void OnGet([FromQuery] int categoryId, [FromQuery] int sort = 0)
        {
            CategoryId = categoryId;
            (Username, UserId) = GetUserCookies();
            if(categoryId == 0)
            {
                if(sort == 1)
                {
                    ProductList = _context.Products!.Where(p => p.IsActive).OrderBy(p => p.Name).ToList();
                }
                else if(sort == 2)
                {
                    ProductList = _context.Products!.Where(p => p.IsActive).OrderByDescending(p => p.Name).ToList();
                }
                else if(sort == 3)
                {
                    ProductList = _context.Products!.Where(p => p.IsActive).OrderBy(p => p.RetailPrice).ToList();
                }
                else if(sort == 4)
                {
                    ProductList = _context.Products!.Where(p => p.IsActive).OrderByDescending(p => p.RetailPrice).ToList();
                }
                else
                {
                    ProductList = _context.Products!.Where(p => p.IsActive).ToList();
                }
            }
            else
            {
                if(sort == 1)
                {
                    ProductList = _context.Products!.Where(p => p.CategoryId == categoryId && p.IsActive).OrderBy(p => p.Name).ToList();
                }
                else if(sort == 2)
                {
                    ProductList = _context.Products!.Where(p => p.CategoryId == categoryId && p.IsActive).OrderByDescending(p => p.Name).ToList();
                }
                else if(sort == 3)
                {
                    ProductList = _context.Products!.Where(p => p.CategoryId == categoryId && p.IsActive).OrderBy(p => p.RetailPrice).ToList();
                }
                else if(sort == 4)
                {
                    ProductList = _context.Products!.Where(p => p.CategoryId == categoryId && p.IsActive).OrderByDescending(p => p.RetailPrice).ToList();
                }
                else
                {
                    ProductList = _context.Products!.Where(p => p.CategoryId == categoryId && p.IsActive).ToList();
                }
            }
        }

        private (string Username, int UserId) GetUserCookies()
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

        public async Task<IActionResult> OnPostAddToBasketAsync()
        {
            (Username, UserId) = GetUserCookies();

            var basket = await _context.Baskets!
                                       .Include(b => b.Items)
                                       .FirstOrDefaultAsync(b => b.UserId == UserId);

            if (basket == null)
            {
                basket = new BasketEntity { UserId = UserId };
                _context.Baskets!.Add(basket);
                await _context.SaveChangesAsync();
            }

            var basketItem = basket.Items.FirstOrDefault(i => i.ProductId == Input.ProductId);

            if (basketItem == null)
            {
                basketItem = new BasketItemEntity
                {
                    BasketId = basket.Id,
                    ProductId = Input.ProductId,
                    Quantity = Input.Quantity,
                    RetailPrice = _context.Products!.FirstOrDefault(p => p.Id == Input.ProductId)?.RetailPrice ?? 0
                };
                basket.Items.Add(basketItem);
            }
            else
            {
                basketItem.Quantity += Input.Quantity;
            }

            await _context.SaveChangesAsync();

            TempData["ToastMessage"] = true;
            return RedirectToPage("/Category");
        }
    }
}
