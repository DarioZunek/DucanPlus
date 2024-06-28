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
    public partial class DodajProizvodForm : Form
    {
        PocetnaForm? _glavniObrazac = null;
        CategoryEntity? kategorija = null;
        SupplierEntity? dobavljac = null;
        public DodajProizvodForm(PocetnaForm glavniObrazac)
        {
            _glavniObrazac = glavniObrazac;
            InitializeComponent();
        }

        private void DodajProizvodForm_Load(object sender, EventArgs e)
        {
            kategorija = _glavniObrazac!.trenutnaKategorija;
            using (var context = new DucanPlusDbContext())
            {
                if (context.Categories != null && context.Categories.Count() > 0)
                {
                    var kategorije = context.Categories.ToList();
                    KategorijeCmb.DataSource = kategorije;
                    KategorijeCmb.DisplayMember = "Name";
                    KategorijeCmb.ValueMember = "Id";

                    KategorijeCmb.SelectedItem = kategorija;
                }

                if (context.Suppliers != null && context.Suppliers.Count() > 0)
                {
                    var dobavljaci = context.Suppliers.ToList();
                    DobavljaciCmb.DataSource = dobavljaci;
                    DobavljaciCmb.DisplayMember = "Name";
                    DobavljaciCmb.ValueMember = "Id";
                }
            }
        }

        private void CijenaTxtb_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(CijenaTxtb.Text, out decimal value))
            {
                CijenaTxtb.ForeColor = Color.Red;
            }
            else
            {
                CijenaTxtb.ForeColor = Color.Black;
            }
        }

        private void CijenaTxtb_Leave(object sender, EventArgs e)
        {
            if (!decimal.TryParse(CijenaTxtb.Text, out decimal value))
            {
                CijenaTxtb.ForeColor = Color.Red;
            }
            else
            {
                CijenaTxtb.ForeColor = Color.Black;
            }
        }

        private void CijenaTxtb_Enter(object sender, EventArgs e)
        {
            CijenaTxtb.ForeColor = Color.Black;
        }

        private void KolicinaTxtb_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(KolicinaTxtb.Text, out int value))
            {
                KolicinaTxtb.ForeColor = Color.Red;
            }
            else
            {
                KolicinaTxtb.ForeColor = Color.Black;
            }
        }

        private void KolicinaTxtb_Enter(object sender, EventArgs e)
        {
            KolicinaTxtb.ForeColor = Color.Black;
        }

        private void KolicinaTxtb_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(KolicinaTxtb.Text, out int value))
            {
                KolicinaTxtb.ForeColor = Color.Red;
            }
            else
            {
                KolicinaTxtb.ForeColor = Color.Black;
            }
        }

        private void TezinaTxtb_TextChanged(object sender, EventArgs e)
        {
            if (!float.TryParse(TezinaTxtb.Text, out float value))
            {
                TezinaTxtb.ForeColor = Color.Red;
            }
            else
            {
                TezinaTxtb.ForeColor = Color.Black;
            }
        }

        private void TezinaTxtb_Enter(object sender, EventArgs e)
        {
            TezinaTxtb.ForeColor = Color.Black;
        }

        private void TezinaTxtb_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(TezinaTxtb.Text, out float value))
            {
                TezinaTxtb.ForeColor = Color.Red;
            }
            else
            {
                TezinaTxtb.ForeColor = Color.Black;
            }
        }

        private void MinimalnaKolicinaTxtb_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(MinimalnaKolicinaTxtb.Text, out int value))
            {
                MinimalnaKolicinaTxtb.ForeColor = Color.Red;
            }
            else
            {
                MinimalnaKolicinaTxtb.ForeColor = Color.Black;
            }
        }

        private void MinimalnaKolicinaTxtb_Enter(object sender, EventArgs e)
        {
            MinimalnaKolicinaTxtb.ForeColor = Color.Black;
        }

        private void MinimalnaKolicinaTxtb_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(MinimalnaKolicinaTxtb.Text, out int value))
            {
                MinimalnaKolicinaTxtb.ForeColor = Color.Red;
            }
            else
            {
                MinimalnaKolicinaTxtb.ForeColor = Color.Black;
            }
        }

        private void NabavnaCijenaTxtb_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(NabavnaCijenaTxtb.Text, out decimal value))
            {
                NabavnaCijenaTxtb.ForeColor = Color.Red;
            }
            else
            {
                NabavnaCijenaTxtb.ForeColor = Color.Black;
            }
        }

        private void NabavnaCijenaTxtb_Leave(object sender, EventArgs e)
        {
            if (!decimal.TryParse(NabavnaCijenaTxtb.Text, out decimal value))
            {
                NabavnaCijenaTxtb.ForeColor = Color.Red;
            }
            else
            {
                NabavnaCijenaTxtb.ForeColor = Color.Black;
            }
        }

        private void NabavnaCijenaTxtb_Enter(object sender, EventArgs e)
        {
            NabavnaCijenaTxtb.ForeColor = Color.Black;
        }

        private void KategorijeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            kategorija = KategorijeCmb.SelectedItem as CategoryEntity;
        }

        private void DobavljaciCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            dobavljac = DobavljaciCmb.SelectedItem as SupplierEntity;
        }

        private void SpremiBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using(var context = new DucanPlusDbContext())
                {
                    var proizvod = new ProductEntity();
                    proizvod.Name = NazivTxtb.Text;
                    proizvod.CostPrice = decimal.Parse(CijenaTxtb.Text);
                    proizvod.Quantity = int.Parse(KolicinaTxtb.Text);
                    proizvod.RetailPrice = decimal.Parse(NabavnaCijenaTxtb.Text);
                    proizvod.Description = OpisTxtb.Text;
                    proizvod.Dimensions = DimenzijeTxtb.Text;
                    proizvod.Weight = float.Parse(TezinaTxtb.Text);
                    proizvod.MinimumStockLevel = int.Parse(MinimalnaKolicinaTxtb.Text);
                    proizvod.ExpirationDate = DatumIstekaDtp.Value;
                    proizvod.CategoryId = (int)KategorijeCmb.SelectedValue;
                    proizvod.SupplierId = (int)DobavljaciCmb.SelectedValue;
                    proizvod.IsActive = !ObrisanoCb.Checked;

                    if(context.Products != null && context.Products.Count() > 0)
                    {
                        context.Products.Add(proizvod);
                        context.SaveChanges();

                        MessageBox.Show("Proizvod je dodan u bazu.", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.None);
                        _glavniObrazac!.OsvjeziProizvodiDGV();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ne mogu dohvatiti proizvode iz base.", "Greška kod povezivanja s bazom", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            catch (Exception)
            {
                GreskaLbl.Visible = true;
            }
        }
    }
}
