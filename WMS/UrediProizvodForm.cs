using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WMS
{
    public partial class UrediProizvodForm : Form
    {
        PocetnaForm? _glavniObrazac = null;
        public UrediProizvodForm(PocetnaForm glavniObrazac)
        {
            InitializeComponent();
            _glavniObrazac = glavniObrazac;
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

        private void UrediArtiklForm_Load(object sender, EventArgs e)
        {
            IdTxtb.Text = _glavniObrazac!.trenutniProizvod!.Id.ToString();
            NazivTxtb.Text = _glavniObrazac!.trenutniProizvod!.Name;
            CijenaTxtb.Text = _glavniObrazac!.trenutniProizvod!.CostPrice.ToString();
            KolicinaTxtb.Text = _glavniObrazac!.trenutniProizvod!.Quantity.ToString();
            NabavnaCijenaTxtb.Text = _glavniObrazac!.trenutniProizvod!.RetailPrice.ToString();
            OpisTxtb.Text = _glavniObrazac!.trenutniProizvod!.Description.ToString();
            DimenzijeTxtb.Text = _glavniObrazac!.trenutniProizvod!.Dimensions != null ? _glavniObrazac!.trenutniProizvod!.Dimensions.ToString() : string.Empty;
            TezinaTxtb.Text = _glavniObrazac!.trenutniProizvod!.Weight != null ? _glavniObrazac!.trenutniProizvod!.Weight.ToString() : string.Empty;
            MinimalnaKolicinaTxtb.Text = _glavniObrazac!.trenutniProizvod!.MinimumStockLevel != null ? _glavniObrazac!.trenutniProizvod!.MinimumStockLevel.ToString() : string.Empty;
            DatumIstekaDtp.Value = _glavniObrazac!.trenutniProizvod!.ExpirationDate != null ? _glavniObrazac!.trenutniProizvod!.ExpirationDate.Value : DateTime.Now;
            using (var context = new DucanPlusDbContext())
            {
                bool greska = false;
                if (context.Categories != null && context.Categories.Count() > 0)
                {
                    KategorijaCmb.DataSource = context.Categories.ToList();
                    KategorijaCmb.DisplayMember = "Name";
                    KategorijaCmb.ValueMember = "Id";
                }
                else
                {
                    greska = true;
                }
                if (context.Suppliers != null && context.Suppliers.Count() > 0)
                {
                    DobavljaciCmb.DataSource = context.Suppliers.ToList();
                    DobavljaciCmb.DisplayMember = "Name";
                    DobavljaciCmb.ValueMember = "Id";
                }
                else
                {
                    greska = true;
                }
                if (greska)
                {
                    MessageBox.Show("Nema kategorija ili dobavljaca u bazi podataka!", "Greška kod spajanja na bazu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            KategorijaCmb.SelectedValue = _glavniObrazac!.trenutniProizvod!.CategoryId;
            DobavljaciCmb.SelectedValue = _glavniObrazac!.trenutniProizvod!.SupplierId;
            ObrisanoCb.Checked = !_glavniObrazac!.trenutniProizvod!.IsActive;
        }

        private void SpremiBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DucanPlusDbContext())
                {
                    var proizvod = context.Products!.Find(_glavniObrazac!.trenutniProizvod!.Id);
                    if (proizvod != null)
                    {
                        proizvod.Name = NazivTxtb.Text;
                        proizvod.CostPrice = decimal.Parse(CijenaTxtb.Text);
                        proizvod.Quantity = int.Parse(KolicinaTxtb.Text);
                        proizvod.RetailPrice = decimal.Parse(NabavnaCijenaTxtb.Text);
                        proizvod.Description = OpisTxtb.Text;
                        proizvod.Dimensions = DimenzijeTxtb.Text;
                        proizvod.Weight = float.Parse(TezinaTxtb.Text);
                        proizvod.MinimumStockLevel = int.Parse(MinimalnaKolicinaTxtb.Text);
                        proizvod.ExpirationDate = DatumIstekaDtp.Value;
                        proizvod.CategoryId = (int)KategorijaCmb.SelectedValue;
                        proizvod.SupplierId = (int)DobavljaciCmb.SelectedValue;
                        proizvod.IsActive = !ObrisanoCb.Checked;

                        context.SaveChanges();

                        MessageBox.Show("Proizvod je ažuriran.", "Ažuriranje uspješno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _glavniObrazac.OsvjeziProizvodiDGV();
                        this.Close();
                    }
                }
            }
            catch (Exception)
            {
                GreskaLbl.Visible = true;
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
    }
}
