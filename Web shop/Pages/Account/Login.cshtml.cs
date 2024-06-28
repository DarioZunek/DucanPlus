using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_shop.Helpers;

namespace Web_shop.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly DucanPlusDbContext _context;
        public LoginModel(DucanPlusDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(Input.Username) || string.IsNullOrEmpty(Input.Password))
                {
                    ModelState.AddModelError(string.Empty, "Korisničko ime i lozinka su obavezni.");
                }
                return Page();
            }

            string storedHashedPassword = "";

            var user = _context.Users!.FirstOrDefault(u => u.Username == Input.Username);
            if (user != null)
            {
                storedHashedPassword = user.PasswordHash;
                if (BCrypt.Net.BCrypt.Verify(Input.Password, storedHashedPassword))
                {
                    SetUserCookie(user.Username, user.Id);
                    TempData["ShowLoginSuccessToast"] = true;
                    return RedirectToPage("/Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Neispravno korisničko ime ili lozinka.");
                    return Page();
                }
            }

            return Page();
        }

        private void SetUserCookie(string username, int id)
        {
            string encryptedUsername = EncryptionHelper.Encrypt(username);
            string encryptedId = EncryptionHelper.Encrypt(id.ToString());

            var httpContext = PageContext.HttpContext;

            httpContext.Response.Cookies.Append("Username", encryptedUsername, new CookieOptions
            {
                HttpOnly = true,
                Secure = true,
                Expires = DateTimeOffset.UtcNow.AddDays(7)
            });

            httpContext.Response.Cookies.Append("UserId", encryptedId, new CookieOptions
            {
                HttpOnly = true,
                Secure = true,
                Expires = DateTimeOffset.UtcNow.AddDays(7)
            });
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
