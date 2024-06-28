using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_shop.Helpers;

namespace Web_shop.Pages
{
    public class FaqModel : PageModel
    {
        private readonly DucanPlusDbContext _context;
        public string Username { get; set; }
        public int UserId { get; set; }
        public FaqModel(DucanPlusDbContext context)
        {
            _context = context;
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
