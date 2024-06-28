using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web_shop.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly DucanPlusDbContext _context;
        public RegisterModel(DucanPlusDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public InputModel? Input { get; set; }

        public class InputModel
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string PasswordRepeat { get; set; }
            public string Email { get; set; }
            public DateTime DateOfBirth { get; set; }


        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Ispravno popunite sva polja.");
                return Page();
            }

            if(Input!.Password != Input.PasswordRepeat)
            {
                ModelState.AddModelError(string.Empty, "Lozinke se ne podudaraju.");
                return Page();
            }

            if (_context.Users!.Any(u => u.Username == Input.Username))
            {
                ModelState.AddModelError(string.Empty, "Korisničko ime već postoji.");
                return Page();
            }

            try
            {
                string salt = BCrypt.Net.BCrypt.GenerateSalt();
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(Input.Password, salt);

                UserEntity user = new UserEntity
                {
                    Name = Input.Name,
                    Surname = Input.Surname,
                    Username = Input.Username,
                    PasswordHash = hashedPassword,
                    PasswordSalt = salt,
                    Email = Input.Email,
                    DateOfBirth = Input.DateOfBirth,
                    RoleId = 3
                };
                _context.Users!.Add(user);
                _context.SaveChanges();

                TempData["ShowRegisterSuccessToast"] = true;
                return RedirectToPage("../Index");
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Greška prilikom registracije.");
                return Page();
            }
        }
    }
}
