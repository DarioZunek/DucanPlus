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
    public partial class IzdajRobuForm : Form
    {
        PocetnaForm? _glavniObrazac = null;
        ProductEntity? odabraniProizvod = null;
        public IzdajRobuForm(PocetnaForm glavniObrazac)
        {
            _glavniObrazac = glavniObrazac;
            InitializeComponent();
        }

        private void IzdajRobuForm_Load(object sender, EventArgs e)
        {
            using (var context = new DucanPlusDbContext())
            {
                if (context.Products != null && context.Products.Count() > 0)
                {
                    var proizvodi = context.Products.Where(p => p.IsActive == true).ToList();
                    ProizvodiCmb.DataSource = proizvodi;
                    ProizvodiCmb.DisplayMember = "Name";
                    ProizvodiCmb.ValueMember = "Id";
                    ProizvodiCmb.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Ne mogu dohvatiti proizvode iz baze podataka!", "Greška kod dohvaćanja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
        }

        private void ProizvodiCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            odabraniProizvod = ProizvodiCmb.SelectedItem as ProductEntity;
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

        private void IzdajBtn_Click(object sender, EventArgs e)
        {
            using (var context = new DucanPlusDbContext())
            {
                if (context.Products != null && context.Products.Count() > 0)
                {
                    if (odabraniProizvod == null)
                    {
                        MessageBox.Show("Morate odabrati proizvod!", "Greška kod odabira proizvoda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var proizvod = context.Products.Find(odabraniProizvod.Id);
                    if (proizvod == null)
                    {
                        MessageBox.Show("Ne mogu dohvatiti proizvod s navedenim ID-om!", "Greška kod dohvaćanja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int kolicina = KolicinaTxtb.Text == "" ? 0 : int.Parse(KolicinaTxtb.Text);
                    if (kolicina <= 0)
                    {
                        MessageBox.Show("Količina mora biti veća od 0!", "Greška kod unosa količine", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    proizvod.Quantity -= kolicina;
                    context.SaveChanges();
                    PovijestLb.Items.Add($"Izdano {kolicina} komada proizvoda {proizvod.Name}.");
                    _glavniObrazac!.OsvjeziProizvodiDGV();
                }
                else
                {
                    MessageBox.Show("Ne mogu dohvatiti proizvode iz baze podataka!", "Greška kod dohvaćanja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
        }
    }
}
