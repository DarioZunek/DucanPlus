using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WMS
{
    public partial class PrijavaForm : Form
    {
        PocetnaForm _glavniObrazac;
        public PrijavaForm(PocetnaForm glavniObrazac)
        {
            InitializeComponent();
            _glavniObrazac = glavniObrazac;
        }

        private void PrijavaForm_Load(object sender, EventArgs e)
        {

        }

        private void PrijavaBtn_Click(object sender, EventArgs e)
        {
            using (var context = new DucanPlusDbContext())
            {
                var username = KorimeTxtb.Text;
                var password = LozinkaTxtb.Text;
                UserEntity? user = null;
                try
                {
                    if (context.Users != null) 
                    {
                        user = context.Users.FirstOrDefault(u => u.Username == username);
                    }
                    else
                    {
                        throw new NullReferenceException();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ne mogu pronaći bazu korisnika", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (user != null && BCrypt.Net.BCrypt.Verify(password, user.PasswordHash) && user.RoleId <=2)
                {
                    _glavniObrazac.prijavljeniKorisnik = user;
                    _glavniObrazac.OsvjeziKorisnika();
                    this.Close();
                }
                else
                {
                    KorimeTxtb.ForeColor = Color.Red;
                    LozinkaTxtb.ForeColor = Color.Red;
                    GreskaLbl.Visible = true;
                }
            }
        }

        private void KorimeTxtb_TextChanged(object sender, EventArgs e)
        {
            KorimeTxtb.ForeColor = Color.Black;
            LozinkaTxtb.ForeColor = Color.Black;
            GreskaLbl.Visible = false;
        }

        private void LozinkaTxtb_TextChanged(object sender, EventArgs e)
        {
            KorimeTxtb.ForeColor = Color.Black;
            LozinkaTxtb.ForeColor = Color.Black;
            GreskaLbl.Visible = false;
        }
    }
}
