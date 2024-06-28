namespace WMS
{
    partial class AdminPanelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanelForm));
            DodajKategorijuLbl = new Label();
            NazivKategorijeLbl = new Label();
            OpisKategorijeLbl = new Label();
            NazivKategorijeTxtb = new TextBox();
            OpisKategorijeTxtb = new TextBox();
            DodajKategorijuBtn = new Button();
            UspjehKategorijaLbl = new Label();
            GreskaKategorijaLbl = new Label();
            BrisiKategorijuLbl = new Label();
            NazivKatBrLbl = new Label();
            KategorijeCmb = new ComboBox();
            BrisiKategorijuBtn = new Button();
            GreskaBrisiKategorijuLbl = new Label();
            UspjehBrisiKategorijuLbl = new Label();
            UspjehBrisiProizvodLbl = new Label();
            GreskaBrisiProizvodLbl = new Label();
            BrisiProizvodBtn = new Button();
            BrisiProizvodCmb = new ComboBox();
            BrisiProNazivLbl = new Label();
            BrisiProizvodLbl = new Label();
            PromjeniUloguLbl = new Label();
            KorisnikLbl = new Label();
            KorisnikCmb = new ComboBox();
            UlogaCmb = new ComboBox();
            UlogaLbl = new Label();
            PromjeniUloguBtn = new Button();
            UspjehUlogaLbl = new Label();
            GreskaUlogaLbl = new Label();
            SuspendLayout();
            // 
            // DodajKategorijuLbl
            // 
            DodajKategorijuLbl.AutoSize = true;
            DodajKategorijuLbl.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            DodajKategorijuLbl.Location = new Point(81, 20);
            DodajKategorijuLbl.Name = "DodajKategorijuLbl";
            DodajKategorijuLbl.Size = new Size(168, 25);
            DodajKategorijuLbl.TabIndex = 0;
            DodajKategorijuLbl.Text = "Dodaj kategoriju";
            // 
            // NazivKategorijeLbl
            // 
            NazivKategorijeLbl.AutoSize = true;
            NazivKategorijeLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            NazivKategorijeLbl.Location = new Point(50, 69);
            NazivKategorijeLbl.Name = "NazivKategorijeLbl";
            NazivKategorijeLbl.Size = new Size(44, 16);
            NazivKategorijeLbl.TabIndex = 1;
            NazivKategorijeLbl.Text = "Naziv:";
            // 
            // OpisKategorijeLbl
            // 
            OpisKategorijeLbl.AutoSize = true;
            OpisKategorijeLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            OpisKategorijeLbl.Location = new Point(55, 108);
            OpisKategorijeLbl.Name = "OpisKategorijeLbl";
            OpisKategorijeLbl.Size = new Size(38, 16);
            OpisKategorijeLbl.TabIndex = 2;
            OpisKategorijeLbl.Text = "Opis:";
            // 
            // NazivKategorijeTxtb
            // 
            NazivKategorijeTxtb.BackColor = SystemColors.HighlightText;
            NazivKategorijeTxtb.Location = new Point(101, 68);
            NazivKategorijeTxtb.Name = "NazivKategorijeTxtb";
            NazivKategorijeTxtb.Size = new Size(176, 21);
            NazivKategorijeTxtb.TabIndex = 3;
            // 
            // OpisKategorijeTxtb
            // 
            OpisKategorijeTxtb.BackColor = SystemColors.HighlightText;
            OpisKategorijeTxtb.Location = new Point(101, 107);
            OpisKategorijeTxtb.Name = "OpisKategorijeTxtb";
            OpisKategorijeTxtb.Size = new Size(176, 21);
            OpisKategorijeTxtb.TabIndex = 4;
            // 
            // DodajKategorijuBtn
            // 
            DodajKategorijuBtn.BackColor = SystemColors.ButtonHighlight;
            DodajKategorijuBtn.Location = new Point(119, 136);
            DodajKategorijuBtn.Name = "DodajKategorijuBtn";
            DodajKategorijuBtn.Size = new Size(104, 31);
            DodajKategorijuBtn.TabIndex = 5;
            DodajKategorijuBtn.Text = "Dodaj";
            DodajKategorijuBtn.UseVisualStyleBackColor = false;
            DodajKategorijuBtn.Click += DodajKategorijuBtn_Click;
            // 
            // UspjehKategorijaLbl
            // 
            UspjehKategorijaLbl.AutoSize = true;
            UspjehKategorijaLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            UspjehKategorijaLbl.ForeColor = Color.Green;
            UspjehKategorijaLbl.Location = new Point(72, 180);
            UspjehKategorijaLbl.Name = "UspjehKategorijaLbl";
            UspjehKategorijaLbl.Size = new Size(206, 16);
            UspjehKategorijaLbl.TabIndex = 6;
            UspjehKategorijaLbl.Text = "Kategorija uspješno dodana!";
            UspjehKategorijaLbl.Visible = false;
            // 
            // GreskaKategorijaLbl
            // 
            GreskaKategorijaLbl.AutoSize = true;
            GreskaKategorijaLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            GreskaKategorijaLbl.ForeColor = Color.Red;
            GreskaKategorijaLbl.Location = new Point(90, 199);
            GreskaKategorijaLbl.Name = "GreskaKategorijaLbl";
            GreskaKategorijaLbl.Size = new Size(169, 16);
            GreskaKategorijaLbl.TabIndex = 7;
            GreskaKategorijaLbl.Text = "Greška kod dodavanja.";
            GreskaKategorijaLbl.Visible = false;
            // 
            // BrisiKategorijuLbl
            // 
            BrisiKategorijuLbl.AutoSize = true;
            BrisiKategorijuLbl.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BrisiKategorijuLbl.Location = new Point(388, 20);
            BrisiKategorijuLbl.Name = "BrisiKategorijuLbl";
            BrisiKategorijuLbl.Size = new Size(154, 25);
            BrisiKategorijuLbl.TabIndex = 8;
            BrisiKategorijuLbl.Text = "Brisi kategoriju";
            // 
            // NazivKatBrLbl
            // 
            NazivKatBrLbl.AutoSize = true;
            NazivKatBrLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            NazivKatBrLbl.Location = new Point(328, 69);
            NazivKatBrLbl.Name = "NazivKatBrLbl";
            NazivKatBrLbl.Size = new Size(44, 16);
            NazivKatBrLbl.TabIndex = 9;
            NazivKatBrLbl.Text = "Naziv:";
            // 
            // KategorijeCmb
            // 
            KategorijeCmb.BackColor = SystemColors.InactiveCaption;
            KategorijeCmb.FormattingEnabled = true;
            KategorijeCmb.Location = new Point(379, 68);
            KategorijeCmb.Name = "KategorijeCmb";
            KategorijeCmb.Size = new Size(192, 23);
            KategorijeCmb.TabIndex = 10;
            KategorijeCmb.SelectedIndexChanged += KategorijeCmb_SelectedIndexChanged;
            // 
            // BrisiKategorijuBtn
            // 
            BrisiKategorijuBtn.BackColor = SystemColors.ButtonHighlight;
            BrisiKategorijuBtn.Location = new Point(416, 97);
            BrisiKategorijuBtn.Name = "BrisiKategorijuBtn";
            BrisiKategorijuBtn.Size = new Size(104, 31);
            BrisiKategorijuBtn.TabIndex = 11;
            BrisiKategorijuBtn.Text = "Briši";
            BrisiKategorijuBtn.UseVisualStyleBackColor = false;
            BrisiKategorijuBtn.Click += BrisiKategorijuBtn_Click;
            // 
            // GreskaBrisiKategorijuLbl
            // 
            GreskaBrisiKategorijuLbl.AutoSize = true;
            GreskaBrisiKategorijuLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            GreskaBrisiKategorijuLbl.ForeColor = Color.Red;
            GreskaBrisiKategorijuLbl.Location = new Point(388, 161);
            GreskaBrisiKategorijuLbl.Name = "GreskaBrisiKategorijuLbl";
            GreskaBrisiKategorijuLbl.Size = new Size(151, 16);
            GreskaBrisiKategorijuLbl.TabIndex = 12;
            GreskaBrisiKategorijuLbl.Text = "Greška kod brisanja.";
            GreskaBrisiKategorijuLbl.Visible = false;
            // 
            // UspjehBrisiKategorijuLbl
            // 
            UspjehBrisiKategorijuLbl.AutoSize = true;
            UspjehBrisiKategorijuLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            UspjehBrisiKategorijuLbl.ForeColor = Color.Green;
            UspjehBrisiKategorijuLbl.Location = new Point(363, 142);
            UspjehBrisiKategorijuLbl.Name = "UspjehBrisiKategorijuLbl";
            UspjehBrisiKategorijuLbl.Size = new Size(214, 16);
            UspjehBrisiKategorijuLbl.TabIndex = 13;
            UspjehBrisiKategorijuLbl.Text = "Kategorija uspješno obrisana!";
            UspjehBrisiKategorijuLbl.Visible = false;
            // 
            // UspjehBrisiProizvodLbl
            // 
            UspjehBrisiProizvodLbl.AutoSize = true;
            UspjehBrisiProizvodLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            UspjehBrisiProizvodLbl.ForeColor = Color.Green;
            UspjehBrisiProizvodLbl.Location = new Point(377, 365);
            UspjehBrisiProizvodLbl.Name = "UspjehBrisiProizvodLbl";
            UspjehBrisiProizvodLbl.Size = new Size(195, 16);
            UspjehBrisiProizvodLbl.TabIndex = 19;
            UspjehBrisiProizvodLbl.Text = "Proizvod uspješno obrisan!";
            UspjehBrisiProizvodLbl.Visible = false;
            // 
            // GreskaBrisiProizvodLbl
            // 
            GreskaBrisiProizvodLbl.AutoSize = true;
            GreskaBrisiProizvodLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            GreskaBrisiProizvodLbl.ForeColor = Color.Red;
            GreskaBrisiProizvodLbl.Location = new Point(399, 384);
            GreskaBrisiProizvodLbl.Name = "GreskaBrisiProizvodLbl";
            GreskaBrisiProizvodLbl.Size = new Size(151, 16);
            GreskaBrisiProizvodLbl.TabIndex = 18;
            GreskaBrisiProizvodLbl.Text = "Greška kod brisanja.";
            GreskaBrisiProizvodLbl.Visible = false;
            // 
            // BrisiProizvodBtn
            // 
            BrisiProizvodBtn.BackColor = SystemColors.ButtonHighlight;
            BrisiProizvodBtn.Location = new Point(413, 320);
            BrisiProizvodBtn.Name = "BrisiProizvodBtn";
            BrisiProizvodBtn.Size = new Size(104, 31);
            BrisiProizvodBtn.TabIndex = 17;
            BrisiProizvodBtn.Text = "Briši";
            BrisiProizvodBtn.UseVisualStyleBackColor = false;
            BrisiProizvodBtn.Click += BrisiProizvodBtn_Click;
            // 
            // BrisiProizvodCmb
            // 
            BrisiProizvodCmb.BackColor = SystemColors.InactiveCaption;
            BrisiProizvodCmb.FormattingEnabled = true;
            BrisiProizvodCmb.Location = new Point(376, 291);
            BrisiProizvodCmb.Name = "BrisiProizvodCmb";
            BrisiProizvodCmb.Size = new Size(192, 23);
            BrisiProizvodCmb.TabIndex = 16;
            BrisiProizvodCmb.SelectedIndexChanged += BrisiProizvodCmb_SelectedIndexChanged;
            // 
            // BrisiProNazivLbl
            // 
            BrisiProNazivLbl.AutoSize = true;
            BrisiProNazivLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BrisiProNazivLbl.Location = new Point(325, 292);
            BrisiProNazivLbl.Name = "BrisiProNazivLbl";
            BrisiProNazivLbl.Size = new Size(44, 16);
            BrisiProNazivLbl.TabIndex = 15;
            BrisiProNazivLbl.Text = "Naziv:";
            // 
            // BrisiProizvodLbl
            // 
            BrisiProizvodLbl.AutoSize = true;
            BrisiProizvodLbl.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BrisiProizvodLbl.Location = new Point(399, 243);
            BrisiProizvodLbl.Name = "BrisiProizvodLbl";
            BrisiProizvodLbl.Size = new Size(142, 25);
            BrisiProizvodLbl.TabIndex = 14;
            BrisiProizvodLbl.Text = "Brisi proizvod";
            // 
            // PromjeniUloguLbl
            // 
            PromjeniUloguLbl.AutoSize = true;
            PromjeniUloguLbl.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PromjeniUloguLbl.Location = new Point(81, 243);
            PromjeniUloguLbl.Name = "PromjeniUloguLbl";
            PromjeniUloguLbl.Size = new Size(155, 25);
            PromjeniUloguLbl.TabIndex = 20;
            PromjeniUloguLbl.Text = "Promjeni ulogu";
            // 
            // KorisnikLbl
            // 
            KorisnikLbl.AutoSize = true;
            KorisnikLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            KorisnikLbl.Location = new Point(15, 293);
            KorisnikLbl.Name = "KorisnikLbl";
            KorisnikLbl.Size = new Size(57, 16);
            KorisnikLbl.TabIndex = 21;
            KorisnikLbl.Text = "Korisnik:";
            // 
            // KorisnikCmb
            // 
            KorisnikCmb.BackColor = SystemColors.InactiveCaption;
            KorisnikCmb.FormattingEnabled = true;
            KorisnikCmb.Location = new Point(81, 292);
            KorisnikCmb.Name = "KorisnikCmb";
            KorisnikCmb.Size = new Size(192, 23);
            KorisnikCmb.TabIndex = 22;
            KorisnikCmb.SelectedIndexChanged += KorisnikCmb_SelectedIndexChanged;
            // 
            // UlogaCmb
            // 
            UlogaCmb.BackColor = SystemColors.InactiveCaption;
            UlogaCmb.FormattingEnabled = true;
            UlogaCmb.Location = new Point(81, 325);
            UlogaCmb.Name = "UlogaCmb";
            UlogaCmb.Size = new Size(192, 23);
            UlogaCmb.TabIndex = 23;
            UlogaCmb.SelectedIndexChanged += UlogaCmb_SelectedIndexChanged;
            // 
            // UlogaLbl
            // 
            UlogaLbl.AutoSize = true;
            UlogaLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            UlogaLbl.Location = new Point(27, 326);
            UlogaLbl.Name = "UlogaLbl";
            UlogaLbl.Size = new Size(47, 16);
            UlogaLbl.TabIndex = 25;
            UlogaLbl.Text = "Uloga:";
            // 
            // PromjeniUloguBtn
            // 
            PromjeniUloguBtn.BackColor = SystemColors.ButtonHighlight;
            PromjeniUloguBtn.Location = new Point(119, 354);
            PromjeniUloguBtn.Name = "PromjeniUloguBtn";
            PromjeniUloguBtn.Size = new Size(104, 31);
            PromjeniUloguBtn.TabIndex = 26;
            PromjeniUloguBtn.Text = "Promjeni";
            PromjeniUloguBtn.UseVisualStyleBackColor = false;
            PromjeniUloguBtn.Click += PromjeniUloguBtn_Click;
            // 
            // UspjehUlogaLbl
            // 
            UspjehUlogaLbl.AutoSize = true;
            UspjehUlogaLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            UspjehUlogaLbl.ForeColor = Color.Green;
            UspjehUlogaLbl.Location = new Point(72, 388);
            UspjehUlogaLbl.Name = "UspjehUlogaLbl";
            UspjehUlogaLbl.Size = new Size(210, 16);
            UspjehUlogaLbl.TabIndex = 28;
            UspjehUlogaLbl.Text = "Uloga uspješno promjenjena!";
            UspjehUlogaLbl.Visible = false;
            // 
            // GreskaUlogaLbl
            // 
            GreskaUlogaLbl.AutoSize = true;
            GreskaUlogaLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            GreskaUlogaLbl.ForeColor = Color.Red;
            GreskaUlogaLbl.Location = new Point(94, 407);
            GreskaUlogaLbl.Name = "GreskaUlogaLbl";
            GreskaUlogaLbl.Size = new Size(148, 16);
            GreskaUlogaLbl.TabIndex = 27;
            GreskaUlogaLbl.Text = "Greška kod izmjene.";
            GreskaUlogaLbl.Visible = false;
            // 
            // AdminPanelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(591, 450);
            Controls.Add(UspjehUlogaLbl);
            Controls.Add(GreskaUlogaLbl);
            Controls.Add(PromjeniUloguBtn);
            Controls.Add(UlogaLbl);
            Controls.Add(UlogaCmb);
            Controls.Add(KorisnikCmb);
            Controls.Add(KorisnikLbl);
            Controls.Add(PromjeniUloguLbl);
            Controls.Add(UspjehBrisiProizvodLbl);
            Controls.Add(GreskaBrisiProizvodLbl);
            Controls.Add(BrisiProizvodBtn);
            Controls.Add(BrisiProizvodCmb);
            Controls.Add(BrisiProNazivLbl);
            Controls.Add(BrisiProizvodLbl);
            Controls.Add(UspjehBrisiKategorijuLbl);
            Controls.Add(GreskaBrisiKategorijuLbl);
            Controls.Add(BrisiKategorijuBtn);
            Controls.Add(KategorijeCmb);
            Controls.Add(NazivKatBrLbl);
            Controls.Add(BrisiKategorijuLbl);
            Controls.Add(GreskaKategorijaLbl);
            Controls.Add(UspjehKategorijaLbl);
            Controls.Add(DodajKategorijuBtn);
            Controls.Add(OpisKategorijeTxtb);
            Controls.Add(NazivKategorijeTxtb);
            Controls.Add(OpisKategorijeLbl);
            Controls.Add(NazivKategorijeLbl);
            Controls.Add(DodajKategorijuLbl);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminPanelForm";
            Text = "Admin Panel";
            Load += AdminPanelForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DodajKategorijuLbl;
        private Label NazivKategorijeLbl;
        private Label OpisKategorijeLbl;
        private TextBox NazivKategorijeTxtb;
        private TextBox OpisKategorijeTxtb;
        private Button DodajKategorijuBtn;
        private Label UspjehKategorijaLbl;
        private Label GreskaKategorijaLbl;
        private Label BrisiKategorijuLbl;
        private Label NazivKatBrLbl;
        private ComboBox KategorijeCmb;
        private Button BrisiKategorijuBtn;
        private Label GreskaBrisiKategorijuLbl;
        private Label UspjehBrisiKategorijuLbl;
        private Label UspjehBrisiProizvodLbl;
        private Label GreskaBrisiProizvodLbl;
        private Button BrisiProizvodBtn;
        private ComboBox BrisiProizvodCmb;
        private Label BrisiProNazivLbl;
        private Label BrisiProizvodLbl;
        private Label PromjeniUloguLbl;
        private Label KorisnikLbl;
        private ComboBox KorisnikCmb;
        private ComboBox UlogaCmb;
        private Label UlogaLbl;
        private Button PromjeniUloguBtn;
        private Label UspjehUlogaLbl;
        private Label GreskaUlogaLbl;
    }
}