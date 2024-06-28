using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.IO;
using System.Web;
using System.Windows.Forms.VisualStyles;

namespace WMS
{
    public partial class PocetnaForm : Form
    {
        string kategorija = "---";
        public CategoryEntity? trenutnaKategorija = null;
        public UserEntity? prijavljeniKorisnik = null;
        public ProductEntity? trenutniProizvod = null;
        public PocetnaForm()
        {
            InitializeComponent();
            try
            {
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                DirectoryInfo directoryInfo = new DirectoryInfo(baseDirectory);

                DirectoryInfo? parent1 = directoryInfo.Parent;
                DirectoryInfo? parent2 = parent1?.Parent;
                DirectoryInfo? parent3 = parent2?.Parent;
                string? direktorij = parent3?.FullName;

                if (direktorij == null)
                {
                    throw new Exception("Ne mogu pronaæi direktorij resursa!");
                }

                string slikaPutanja = @"Images\default-user.png";
                string slikaPunaPutanja = Path.Combine(direktorij, slikaPutanja);

                using (FileStream fs = new FileStream(slikaPunaPutanja, FileMode.Open, FileAccess.Read))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        fs.CopyTo(ms);
                        KorisnikPictureBox.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
                KorisnikPictureBox.Image = SystemIcons.Application.ToBitmap();
            }
            BrisiKategorijuBtn.Enabled = false;
            UrediProizvodBtn.Enabled = false;
            ObrisanoBtn.Enabled = false;
            DodajProizvodBtn.Enabled = false;
            ZaprimiBtn.Enabled = false;
            IzdajBtn.Enabled = false;
            OdabranaKategorijaLbl.Text = "---";

            using (var context = new DucanPlusDbContext())
            {
                List<CategoryEntity> kategorije = new List<CategoryEntity>();
                if (context.Categories != null && context.Categories.Count() != 0)
                {
                    kategorije = context.Categories.Where(c => c.IsActive == true).ToList();
                }

                if (kategorije == null || !kategorije.Any())
                {
                    MessageBox.Show("Greška: Nisu pronađene kategorije u bazi podataka!");
                    return;
                }

                PodaciDGV.DataSource = kategorije;
                KategorijeCmb.DataSource = kategorije;
                KategorijeCmb.DisplayMember = "Name";
            }
        }

        private void odaberiKategorijuBtn_Click(object sender, EventArgs e)
        {
            using (var context = new DucanPlusDbContext())
            {
                if (context.Categories != null && context.Categories.Count() != 0)
                {
                    trenutnaKategorija = context.Categories.FirstOrDefault(c => c.Name.Equals(kategorija));
                }
            }
            if (trenutnaKategorija != null)
            {
                using (var context = new DucanPlusDbContext())
                {
                    if (context.Products != null && context.Products.Count() != 0)
                    {
                        List<ProductEntity> proizvodiKategorije = new List<ProductEntity>();
                        proizvodiKategorije = context.Products
                            .Where(p => p.Category.Equals(trenutnaKategorija) && p.IsActive == true)
                            .Include(p => p.Supplier)
                            .Include(p => p.Category)
                            .ToList();
                        OdabranaKategorijaLbl.Invoke(new Action(() => OdabranaKategorijaLbl.Text = trenutnaKategorija!.Name));
                        ProizvodiDGV.DataSource = proizvodiKategorije;
                        ProizvodiDGV.Columns["Category"].Visible = false;
                        ProizvodiDGV.Columns["Supplier"].Visible = false;
                        if (!ProizvodiDGV.Columns.Contains("CategoryName"))
                        {
                            ProizvodiDGV.Columns.Add("CategoryName", "Category Name");
                        }
                        if (!ProizvodiDGV.Columns.Contains("SupplierName"))
                        {
                            ProizvodiDGV.Columns.Add("SupplierName", "Supplier Name");
                        }
                        foreach (DataGridViewRow row in ProizvodiDGV.Rows)
                        {
                            var product = row.DataBoundItem as ProductEntity;
                            if (product != null && product.Category != null && product.Supplier != null)
                            {
                                row.Cells["CategoryName"].Value = product.Category.Name;
                                row.Cells["SupplierName"].Value = product.Supplier.Name;
                            }
                        }

                        trenutniProizvod = (ProductEntity)ProizvodiDGV.CurrentRow.DataBoundItem;
                        if (prijavljeniKorisnik != null)
                        {
                            UrediProizvodBtn.Enabled = true;
                        }
                    }
                }
            }
        }

        private void PrijavaBtn_Click(object sender, EventArgs e)
        {
            PrijavaForm prijavaForm = new PrijavaForm(this);
            prijavaForm.Show();
            if (prijavljeniKorisnik != null && trenutnaKategorija != null)
            {
                UrediProizvodBtn.Enabled = true;
            }
        }

        private void RegistracijaBtn_Click(object sender, EventArgs e)
        {
            RegistracijaForm registracijaForm = new RegistracijaForm();
            registracijaForm.Show();
        }

        public void OsvjeziKorisnika()
        {
            KorImeLbl.Text = prijavljeniKorisnik?.Username;
            PrijavaBtn.Visible = false;
            RegistracijaBtn.Visible = false;
            OdjavaBtn.Visible = true;
            AdminPanelBtn.Visible = false;
            ObrisanoBtn.Enabled = true;
            DodajProizvodBtn.Enabled = true;
            BrisiKategorijuBtn.Enabled = true;
            ZaprimiBtn.Enabled = true;
            IzdajBtn.Enabled = true;

            if (prijavljeniKorisnik != null && prijavljeniKorisnik.RoleId ==1)
            {
                AdminPanelBtn.Visible = true;
            }
        }

        private void UrediProizvodBtn_Click(object sender, EventArgs e)
        {
            UrediProizvodForm urediArtiklForm = new UrediProizvodForm(this);
            urediArtiklForm.Show();
        }

        public void OsvjeziProizvodiDGV()
        {
            ProizvodiDGV.DataSource = null;
            if (trenutnaKategorija != null)
            {
                using (var context = new DucanPlusDbContext())
                {
                    if (context.Products != null && context.Products.Count() != 0)
                    {
                        List<ProductEntity> proizvodiKategorije = new List<ProductEntity>();
                        proizvodiKategorije = context.Products
                            .Where(p => p.Category.Equals(trenutnaKategorija) && p.IsActive == true)
                            .Include(p => p.Supplier)
                            .Include(p => p.Category)
                            .ToList();
                        OdabranaKategorijaLbl.Invoke(new Action(() => OdabranaKategorijaLbl.Text = trenutnaKategorija!.Name));
                        ProizvodiDGV.DataSource = proizvodiKategorije;
                        ProizvodiDGV.Columns["Category"].Visible = false;
                        ProizvodiDGV.Columns["Supplier"].Visible = false;
                        if (!ProizvodiDGV.Columns.Contains("CategoryName"))
                        {
                            ProizvodiDGV.Columns.Add("CategoryName", "Category Name");
                        }
                        if (!ProizvodiDGV.Columns.Contains("SupplierName"))
                        {
                            ProizvodiDGV.Columns.Add("SupplierName", "Supplier Name");
                        }
                        foreach (DataGridViewRow row in ProizvodiDGV.Rows)
                        {
                            var product = row.DataBoundItem as ProductEntity;
                            if (product != null && product.Category != null && product.Supplier != null)
                            {
                                row.Cells["CategoryName"].Value = product.Category.Name;
                                row.Cells["SupplierName"].Value = product.Supplier.Name;
                            }
                        }
                    }
                }
            }
            ProizvodiDGV.Refresh();
        }

        private void ProizvodiDGV_SelectionChanged(object sender, EventArgs e)
        {
            trenutniProizvod = (ProductEntity)ProizvodiDGV.CurrentRow.DataBoundItem;
        }

        private void KategorijeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            kategorija = KategorijeCmb.Text;
        }

        private void GlavniObrazac_Load(object sender, EventArgs e)
        {
            KategorijeCmb.SelectedIndex = 0;
            this.kategorija = KategorijeCmb.Text;
        }

        private void OdjavaBtn_Click(object sender, EventArgs e)
        {
            prijavljeniKorisnik = null;
            KorImeLbl.Text = "---";
            PrijavaBtn.Visible = true;
            RegistracijaBtn.Visible = true;
            OdjavaBtn.Visible = false;
            AdminPanelBtn.Visible = false;
            UrediProizvodBtn.Enabled = false;
            ObrisanoBtn.Enabled = false;
            DodajProizvodBtn.Enabled = false;
            BrisiKategorijuBtn.Enabled = false;
            ZaprimiBtn.Enabled = false;
            IzdajBtn.Enabled = false;
        }

        private void ObrisanoBtn_Click(object sender, EventArgs e)
        {
            ObrisanoForm obrisanoForm = new ObrisanoForm(this);
            obrisanoForm.Show();
        }

        private void PodaciDGV_SelectionChanged(object sender, EventArgs e)
        {
            trenutnaKategorija = PodaciDGV.CurrentRow.DataBoundItem as CategoryEntity;
        }

        private void BrisiKategorijuBtn_Click(object sender, EventArgs e)
        {
            if (trenutnaKategorija != null)
            {
                using (var context = new DucanPlusDbContext())
                {
                    if (context.Categories != null && context.Categories.Count() > 0 && context.Products != null && context.Products.Count() > 0)
                    {
                        var kategorijaZaBrisanje = context.Categories.Find(trenutnaKategorija.Id);
                        kategorijaZaBrisanje!.IsActive = false;
                        var proizvodiZaBrisanje = context.Products.Where(p => p.CategoryId == trenutnaKategorija.Id).ToList();
                        foreach (var proizvod in proizvodiZaBrisanje)
                        {
                            proizvod.IsActive = false;
                        }
                        context.SaveChanges();
                        OsvjeziKategorijeDGV();
                    }
                    else
                    {
                        MessageBox.Show("Ne mogu dohvatiti kategorije!");
                    }
                }
            }
        }

        public void OsvjeziKategorijeDGV()
        {
            using (var context = new DucanPlusDbContext())
            {
                List<CategoryEntity> kategorije = new List<CategoryEntity>();
                if (context.Categories != null && context.Categories.Count() != 0)
                {
                    kategorije = context.Categories.Where(c => c.IsActive == true).ToList();
                }

                if (kategorije == null || !kategorije.Any())
                {
                    MessageBox.Show("Greška: Nisu pronađene kategorije u bazi podataka!");
                    return;
                }

                PodaciDGV.DataSource = null;
                PodaciDGV.DataSource = kategorije;
                KategorijeCmb.DataSource = null;
                KategorijeCmb.DataSource = kategorije;
                KategorijeCmb.DisplayMember = "Name";
                trenutnaKategorija = null;
            }
        }

        private void DodajProizvodBtn_Click(object sender, EventArgs e)
        {
            DodajProizvodForm dodajProizvodForm = new DodajProizvodForm(this);
            dodajProizvodForm.Show();
        }

        private void ZaNarucitiBtn_Click(object sender, EventArgs e)
        {
            ZaNarucitiForm zaNarucitiForm = new ZaNarucitiForm(this);
            zaNarucitiForm.Show();
        }

        private void ZaprimiBtn_Click(object sender, EventArgs e)
        {
            ZaprimiRobuForm zaprimiRobuForm = new ZaprimiRobuForm(this);
            zaprimiRobuForm.Show();
        }

        private void IzdajBtn_Click(object sender, EventArgs e)
        {
            IzdajRobuForm izdajRobuForm = new IzdajRobuForm(this);
            izdajRobuForm.Show();
        }

        private void AdminPanelBtn_Click(object sender, EventArgs e)
        {
            AdminPanelForm adminPanelForm = new AdminPanelForm(this);
            adminPanelForm.Show();
        }
    }
}
