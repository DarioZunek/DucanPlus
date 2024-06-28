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
    public partial class ZaNarucitiForm : Form
    {
        PocetnaForm? _glavniObrazac;
        public ZaNarucitiForm(PocetnaForm glavniObrazac)
        {
            _glavniObrazac = glavniObrazac;
            InitializeComponent();
        }

        private void ZaNarucitiForm_Load(object sender, EventArgs e)
        {
            using (var context = new DucanPlusDbContext())
            {
                if (context.Products != null && context.Products.Count() > 0)
                {
                    var proizvodi = context.Products.Where(p => p.MinimumStockLevel > p.Quantity).ToList();
                    if (proizvodi.Count == 0)
                    {
                        PorukaLbl.Visible = true;
                    }
                    else
                    {
                        ZaNarucitiDGV.DataSource = proizvodi;
                        DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                        column.HeaderText = "Minimum order quantity";
                        column.Name = "MinimumOrderQuantity";
                        ZaNarucitiDGV.Columns.Insert(2, column);

                        foreach (DataGridViewRow row in ZaNarucitiDGV.Rows)
                        {
                            var minimumStockLevel = Convert.ToInt32(row.Cells["MinimumStockLevel"].Value);
                            var quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                            var difference = minimumStockLevel - quantity;
                            row.Cells["MinimumOrderQuantity"].Value = difference;
                        }
                        _glavniObrazac!.OsvjeziProizvodiDGV();
                    }
                }
                else
                {
                    MessageBox.Show("Ne mogu dohvatiti proizvode!", "Greška kod dohvaćanja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }
    }
}
