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
    public partial class ObrisanoForm : Form
    {
        ProductEntity? proizvod = null;
        CategoryEntity? kategorija = null;
        PocetnaForm? _glavniObrazac = null;
        public ObrisanoForm(PocetnaForm glavniObrazac)
        {
            InitializeComponent();
            _glavniObrazac = glavniObrazac;
        }

        private void ObrisanoForm_Load(object sender, EventArgs e)
        {
            PotvrdaLbl.Visible = false;
            using (var context = new DucanPlusDbContext())
            {
                if (context.Products != null && context.Products.Count() > 0)
                {
                    var proizvodi = context.Products.Where(p => p.IsActive == false).ToList();
                    ObrisaniProizvodiDGV.DataSource = proizvodi;
                }
                else
                {
                    MessageBox.Show("Ne mogu dohvatiti proizvode!", "Greška kod dohvaćanja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (context.Categories != null && context.Categories.Count() > 0)
                {
                    var kategorije = context.Categories.Where(c => c.IsActive == false).ToList();
                    ObrisaneKategorijeDGV.DataSource = kategorije;
                }
                else
                {
                    MessageBox.Show("Ne mogu dohvatiti kategorije!", "Greška kod dohvaćanja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ObrisaniProizvodiDGV_SelectionChanged(object sender, EventArgs e)
        {
            proizvod = ObrisaniProizvodiDGV.CurrentRow.DataBoundItem as ProductEntity;
        }

        private void ObrisaneKategorijeDGV_SelectionChanged(object sender, EventArgs e)
        {
            kategorija = ObrisaneKategorijeDGV.CurrentRow.DataBoundItem as CategoryEntity;
        }

        private void VratiProizvodBtn_Click(object sender, EventArgs e)
        {
            if (proizvod != null)
            {
                using (var context = new DucanPlusDbContext())
                {
                    if (context.Products != null && context.Products.Count() > 0)
                    {
                        var proizvodZaVracanje = context.Products.Find(proizvod.Id);
                        proizvodZaVracanje!.IsActive = true;
                        context.SaveChanges();

                        PotvrdaLbl.Visible = true;
                        OsvjeziGridove();
                        _glavniObrazac!.OsvjeziProizvodiDGV();
                    }
                    else
                    {
                        MessageBox.Show("Ne mogu dohvatiti proizvode!", "Greška kod dohvaćanja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void OsvjeziGridove()
        {
            using (var context = new DucanPlusDbContext())
            {
                if (context.Products != null && context.Products.Count() > 0)
                {
                    var proizvodi = context.Products.Where(p => p.IsActive == false).ToList();
                    ObrisaniProizvodiDGV.DataSource = null;
                    ObrisaniProizvodiDGV.DataSource = proizvodi;
                }
                else
                {
                    MessageBox.Show("Ne mogu dohvatiti proizvode!", "Greška kod dohvaćanja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (context.Categories != null && context.Categories.Count() > 0)
                {
                    var kategorije = context.Categories.Where(c => c.IsActive == false).ToList();
                    ObrisaneKategorijeDGV.DataSource = null;
                    ObrisaneKategorijeDGV.DataSource = kategorije;
                }
                else
                {
                    MessageBox.Show("Ne mogu dohvatiti kategorije!", "Greška kod dohvaćanja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Task task = SakrijPotvrduAsync();
        }

        public async Task SakrijPotvrduAsync()
        {
            await Task.Delay(3000);

            PotvrdaLbl.Visible = false;
        }

        private void VratiKategorijuBtn_Click(object sender, EventArgs e)
        {
            if (kategorija != null)
            {
                using (var context = new DucanPlusDbContext())
                {
                    if (context.Categories != null && context.Categories.Count() > 0 && context.Products != null && context.Products.Count() > 0)
                    {
                        var kategorijaZaVracanje = context.Categories.Find(kategorija.Id);
                        kategorijaZaVracanje!.IsActive = true;
                        var proizvodiZaVracanje = context.Products.Where(p => p.CategoryId == kategorija.Id).ToList();
                        foreach (var proizvod in proizvodiZaVracanje)
                        {
                            proizvod.IsActive = true;
                        }
                        context.SaveChanges();

                        PotvrdaLbl.Visible = true;
                        OsvjeziGridove();
                        _glavniObrazac.OsvjeziKategorijeDGV();
                    }
                    else
                    {
                        MessageBox.Show("Ne mogu dohvatiti kategorije!", "Greška kod dohvaćanja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
