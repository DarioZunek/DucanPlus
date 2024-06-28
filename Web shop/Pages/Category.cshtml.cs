using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_shop.Helpers;

namespace Web_shop.Pages
{
    public class CategoryModel : PageModel
    {
        private readonly DucanPlusDbContext _context;
        public List<CategoryEntity> CategoryList { get; set; }
        public string Username { get; set; }
        public int UserId { get; set; }
        public CategoryModel(DucanPlusDbContext context)
        {
            _context = context;
            CategoryList = _context.Categories!.Where(x => x.IsActive).ToList();
        }

        public void OnGet()
        {
            (string Username, int UserId) userCookies = GetUserCookies();
            Username = userCookies.Username;
            UserId = userCookies.UserId;
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
    }
}
