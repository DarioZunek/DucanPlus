using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMS
{
    public partial class RegistracijaForm : Form
    {
        public RegistracijaForm()
        {
            InitializeComponent();
        }

        private void RegistracijaForm_Load(object sender, EventArgs e)
        {

        }

        private void RegistracijaBtn_Click(object sender, EventArgs e)
        {
            bool provjera = true;
            string ime = ImeTxtb.Text;
            string prezime = PrezimeTxtb.Text;
            string datumRodenja = DatumRodenjaDTP.Value.ToString("dd.MM.yyyy");
            string email = EmailTxtb.Text;
            string korisnickoIme = KorimeTxtb.Text;
            string lozinka = LozinkaTxtb.Text;
            string ponovljenaLozinka = PonovljenLozinkaTxtb.Text;

            string patternImePrezime = @"^([A-ZŠŽĐČĆ][a-zšžđčćüäöß]*\s?){1,}$";
            string patternDatumRodenja = @"^\d{2}\.\d{2}\.\d{4}$";
            string patternEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            string patternKorisnickoIme = @"^[a-zA-Z0-9]{5,}$";
            string patternLozinka = @"^(?=.*\d)(?=.*[-_?!#$/*\-+.,()=&]).{8,}$";


            if (!Regex.IsMatch(ime, patternImePrezime) || ime.Length > 30)
            {
                ImeTxtb.BackColor = Color.Red;
                GreskaLbl.Visible = true;
                provjera = false;
            }

            if (!Regex.IsMatch(prezime, patternImePrezime) || prezime.Length > 30)
            {
                PrezimeTxtb.BackColor = Color.Red;
                GreskaLbl.Visible = true;
                provjera = false;
            }

            if (!Regex.IsMatch(datumRodenja, patternDatumRodenja))
            {
                DatumRodenjaDTP.CalendarForeColor = Color.Red;
                GreskaLbl.Visible = true;
                provjera = false;
            }

            DateTime parsedDatumRodenja;
            if (!DateTime.TryParseExact(datumRodenja, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDatumRodenja))
            {
                DatumRodenjaDTP.CalendarForeColor = Color.Red;
                GreskaLbl.Visible = true;
                provjera = false;
            }

            if (!Regex.IsMatch(email, patternEmail))
            {
                EmailTxtb.BackColor = Color.Red;
                GreskaLbl.Visible = true;
                provjera = false;
            }

            if (!Regex.IsMatch(korisnickoIme, patternKorisnickoIme))
            {
                KorimeTxtb.BackColor = Color.Red;
                GreskaLbl.Visible = true;
                provjera = false;
            }
            else
            {
                using (var context = new DucanPlusDbContext())
                {
                    bool korisnickoImePostoji = context.Users!.Any(u => u.Username == korisnickoIme);
                    if (korisnickoImePostoji)
                    {
                        KorimeTxtb.BackColor = Color.Red;
                        GreskaLbl.Visible = true;
                        provjera = false;
                        MessageBox.Show("Greška", "Korisničko ime već postoji u bazi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            if (!Regex.IsMatch(lozinka, patternLozinka))
            {
                LozinkaTxtb.BackColor = Color.Red;
                PonovljenLozinkaTxtb.BackColor = Color.Red;
                GreskaLbl.Visible = true;
                provjera = false;
            }

            if (lozinka != ponovljenaLozinka)
            {
                LozinkaTxtb.BackColor = Color.Red;
                PonovljenLozinkaTxtb.BackColor = Color.Red;
                GreskaLbl.Visible = true;
                provjera = false;
            }

            if (provjera)
            {
                string sol = BCrypt.Net.BCrypt.GenerateSalt();
                string lozinkaHash = BCrypt.Net.BCrypt.HashPassword(lozinka, sol);
                using (var context = new DucanPlusDbContext())
                {
                    try
                    {
                        Task task = AddNewUserAsync(context, ime, prezime, datumRodenja, email, korisnickoIme, sol, lozinkaHash);
                        MessageBox.Show("Uspješno ste se registrirali!");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Greška u dodavanju korisnika u bazu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async Task AddNewUserAsync(DucanPlusDbContext dbContext, string ime, string prezime, string datumRodenja, string email, string korisnickoIme, string sol, string lozinkaHash)
        {
            var newUser = new UserEntity
            {
                Name = ime,
                Surname = prezime,
                DateOfBirth = DateTime.ParseExact(datumRodenja, "dd.MM.yyyy", null),
                Email = email,
                Username = korisnickoIme,
                PasswordSalt = sol,
                PasswordHash = lozinkaHash,
                RoleId = 2,
                IsActive = true
            };

            try
            {
                dbContext.Users!.Add(newUser);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška u dodavanju korisnika u bazu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImeTxtb_TextChanged(object sender, EventArgs e)
        {
            ImeTxtb.BackColor = Color.White;
            GreskaLbl.Visible = false;
        }

        private void PrezimeTxtb_TextChanged(object sender, EventArgs e)
        {
            PrezimeTxtb.BackColor = Color.White;
            GreskaLbl.Visible = false;
        }

        private void EmailTxtb_TextChanged(object sender, EventArgs e)
        {
            EmailTxtb.BackColor = Color.White;
            GreskaLbl.Visible = false;
        }

        private void DatumRodenjaDTP_ValueChanged(object sender, EventArgs e)
        {
            DatumRodenjaDTP.CalendarForeColor = Color.Black;
            GreskaLbl.Visible = false;
        }

        private void KorimeTxtb_TextChanged(object sender, EventArgs e)
        {
            KorimeTxtb.BackColor = Color.White;
            GreskaLbl.Visible = false;
        }

        private void LozinkaTxtb_TextChanged(object sender, EventArgs e)
        {
            LozinkaTxtb.BackColor = Color.White;
            GreskaLbl.Visible = false;
        }

        private void PonovljenLozinkaTxtb_TextChanged(object sender, EventArgs e)
        {
            PonovljenLozinkaTxtb.BackColor = Color.White;
            GreskaLbl.Visible = false;
        }
    }
}
