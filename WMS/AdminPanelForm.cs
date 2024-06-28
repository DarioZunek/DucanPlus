using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMS
{
    public partial class AdminPanelForm : Form
    {
        public PocetnaForm _glavniObrazac = new PocetnaForm();
        private CategoryEntity oznacenaKategorija = new CategoryEntity();
        private ProductEntity oznacenProizvod = new ProductEntity();
        private UserEntity oznaceniKorisnik = new UserEntity();
        private RoleEntity oznacenaUloga = new RoleEntity();
        public AdminPanelForm(PocetnaForm glavniObrazac)
        {
            _glavniObrazac = glavniObrazac;
            InitializeComponent();
        }

        private async Task SakrijLabeleSOdmakom()
        {
            await Task.Delay(3000);
            GreskaKategorijaLbl.Visible = false;
            UspjehKategorijaLbl.Visible = false;
            GreskaBrisiKategorijuLbl.Visible = false;
            UspjehBrisiKategorijuLbl.Visible = false;
            GreskaBrisiProizvodLbl.Visible = false;
            UspjehBrisiProizvodLbl.Visible = false;
            GreskaUlogaLbl.Visible = false;
            UspjehUlogaLbl.Visible = false;
        }

        private void DodajKategorijuBtn_Click(object sender, EventArgs e)
        {
            CategoryEntity kategorija = new CategoryEntity();
            kategorija.Name = NazivKategorijeTxtb.Text;
            kategorija.Description = OpisKategorijeTxtb.Text;
            try
            {
                using (var context = new DucanPlusDbContext())
                {
                    context.Categories!.Add(kategorija);
                    context.SaveChanges();
                    UspjehKategorijaLbl.Visible = true;
                    _glavniObrazac.OsvjeziKategorijeDGV();

                    KategorijeCmb.DataSource = null;
                    KategorijeCmb.DataSource = context.Categories!.ToList();
                    KategorijeCmb.DisplayMember = "Name";
                    KategorijeCmb.ValueMember = "Id";
                    KategorijeCmb.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                GreskaKategorijaLbl.Visible = true;
            }
            Task task = SakrijLabeleSOdmakom();
        }

        private void KategorijeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            oznacenaKategorija = (CategoryEntity)KategorijeCmb.SelectedItem;
        }

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
            using (var context = new DucanPlusDbContext())
            {
                KategorijeCmb.DataSource = context.Categories!.ToList();
                KategorijeCmb.DisplayMember = "Name";
                KategorijeCmb.ValueMember = "Id";
                KategorijeCmb.SelectedIndex = -1;

                BrisiProizvodCmb.DataSource = context.Products!.ToList();
                BrisiProizvodCmb.DisplayMember = "Name";
                BrisiProizvodCmb.ValueMember = "Id";
                BrisiProizvodCmb.SelectedIndex = -1;

                KorisnikCmb.DataSource = context.Users!.ToList();
                KorisnikCmb.DisplayMember = "Username";
                KorisnikCmb.ValueMember = "Id";
                KorisnikCmb.SelectedIndex = -1;

                UlogaCmb.DataSource = context.Roles!.ToList();
                UlogaCmb.DisplayMember = "Name";
                UlogaCmb.ValueMember = "Id";
                UlogaCmb.SelectedIndex = -1;
            }
        }

        private void BrisiKategorijuBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DucanPlusDbContext())
                {
                    context.Categories!.Remove(oznacenaKategorija);
                    context.SaveChanges();

                    KategorijeCmb.DataSource = null;
                    KategorijeCmb.DataSource = context.Categories!.ToList();
                    KategorijeCmb.DisplayMember = "Name";
                    KategorijeCmb.ValueMember = "Id";
                    KategorijeCmb.SelectedIndex = -1;
                    _glavniObrazac.OsvjeziKategorijeDGV();
                    UspjehBrisiKategorijuLbl.Visible = true;
                }
            }
            catch (Exception ex)
            {
                GreskaBrisiKategorijuLbl.Visible = true;
            }
            Task task = SakrijLabeleSOdmakom();
        }

        private void BrisiProizvodCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            oznacenProizvod = (ProductEntity)BrisiProizvodCmb.SelectedItem;
        }

        private void BrisiProizvodBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DucanPlusDbContext())
                {
                    context.Products!.Remove(oznacenProizvod);
                    context.SaveChanges();

                    BrisiProizvodCmb.DataSource = null;
                    BrisiProizvodCmb.DataSource = context.Products!.ToList();
                    BrisiProizvodCmb.DisplayMember = "Name";
                    BrisiProizvodCmb.ValueMember = "Id";
                    BrisiProizvodCmb.SelectedIndex = -1;
                    _glavniObrazac.OsvjeziProizvodiDGV();
                    UspjehBrisiProizvodLbl.Visible = true;
                }
            }
            catch (Exception ex)
            {
                GreskaBrisiProizvodLbl.Visible = true;
            }
            Task task = SakrijLabeleSOdmakom();
        }

        private void KorisnikCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            oznaceniKorisnik = (UserEntity)KorisnikCmb.SelectedItem;
        }

        private void UlogaCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            oznacenaUloga = (RoleEntity)UlogaCmb.SelectedItem;
        }

        private void PromjeniUloguBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DucanPlusDbContext())
                {
                    var korisnik = context.Users!.Find(oznaceniKorisnik.Id);
                    if (korisnik != null)
                    {
                        korisnik.RoleId = oznacenaUloga.Id;
                        context.SaveChanges();

                        UspjehUlogaLbl.Visible = true;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            catch (Exception ex)
            {
                GreskaUlogaLbl.Visible = true;
            }
            Task task = SakrijLabeleSOdmakom();
        }
    }
}
