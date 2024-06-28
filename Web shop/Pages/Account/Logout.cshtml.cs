using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web_shop.Pages.Account
{
    public class LogoutModel : PageModel
    {
        public async Task<IActionResult> OnGetAsync()
        {
            HttpContext httpContext = PageContext.HttpContext;
            httpContext.SignOutAsync();

            Response.Cookies.Delete("Username");
            Response.Cookies.Delete("UserId");

            TempData["ShowLogoutSuccessToast"] = true;

            return RedirectToPage("../Index");
        }
    }
}
