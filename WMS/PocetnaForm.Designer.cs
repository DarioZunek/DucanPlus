namespace WMS
{
    partial class PocetnaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PocetnaForm));
            PrijavaBtn = new Button();
            RegistracijaBtn = new Button();
            KorisnikLbl = new Label();
            KorisnikPictureBox = new PictureBox();
            KorImeLbl = new Label();
            PodaciDGV = new DataGridView();
            PregledKategorijaLbl = new Label();
            PregledProizvodaLbl = new Label();
            KategorijeCmb = new ComboBox();
            OdaberiKategorijuBtn = new Button();
            OdabranaKategorijaPokazLbl = new Label();
            OdabranaKategorijaLbl = new Label();
            ProizvodiDGV = new DataGridView();
            UrediProizvodBtn = new Button();
            OdjavaBtn = new Button();
            UrediProizvodTt = new ToolTip(components);
            ObrisanoBtn = new Button();
            BrisiKategorijuBtn = new Button();
            DodajProizvodBtn = new Button();
            pictureBox1 = new PictureBox();
            ZaNarucitiBtn = new Button();
            ZaprimiBtn = new Button();
            IzdajBtn = new Button();
            AdminPanelBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)KorisnikPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PodaciDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProizvodiDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PrijavaBtn
            // 
            PrijavaBtn.BackColor = SystemColors.ButtonHighlight;
            PrijavaBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PrijavaBtn.Location = new Point(12, 12);
            PrijavaBtn.Name = "PrijavaBtn";
            PrijavaBtn.Size = new Size(120, 32);
            PrijavaBtn.TabIndex = 0;
            PrijavaBtn.Text = "Prijavi se";
            PrijavaBtn.UseVisualStyleBackColor = false;
            PrijavaBtn.Click += PrijavaBtn_Click;
            // 
            // RegistracijaBtn
            // 
            RegistracijaBtn.BackColor = SystemColors.ButtonHighlight;
            RegistracijaBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            RegistracijaBtn.Location = new Point(12, 50);
            RegistracijaBtn.Name = "RegistracijaBtn";
            RegistracijaBtn.Size = new Size(120, 32);
            RegistracijaBtn.TabIndex = 1;
            RegistracijaBtn.Text = "Registriraj se";
            RegistracijaBtn.UseVisualStyleBackColor = false;
            RegistracijaBtn.Click += RegistracijaBtn_Click;
            // 
            // KorisnikLbl
            // 
            KorisnikLbl.AutoSize = true;
            KorisnikLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            KorisnikLbl.Location = new Point(1097, 9);
            KorisnikLbl.Name = "KorisnikLbl";
            KorisnikLbl.Size = new Size(54, 15);
            KorisnikLbl.TabIndex = 3;
            KorisnikLbl.Text = "Korisnik:";
            // 
            // KorisnikPictureBox
            // 
            KorisnikPictureBox.InitialImage = (Image)resources.GetObject("KorisnikPictureBox.InitialImage");
            KorisnikPictureBox.Location = new Point(1220, 9);
            KorisnikPictureBox.Name = "KorisnikPictureBox";
            KorisnikPictureBox.Size = new Size(32, 32);
            KorisnikPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            KorisnikPictureBox.TabIndex = 4;
            KorisnikPictureBox.TabStop = false;
            // 
            // KorImeLbl
            // 
            KorImeLbl.AutoSize = true;
            KorImeLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            KorImeLbl.Location = new Point(1097, 29);
            KorImeLbl.Name = "KorImeLbl";
            KorImeLbl.Size = new Size(120, 15);
            KorImeLbl.TabIndex = 5;
            KorImeLbl.Text = "Neprijavljeni korisnik";
            // 
            // PodaciDGV
            // 
            PodaciDGV.AllowUserToAddRows = false;
            PodaciDGV.AllowUserToDeleteRows = false;
            PodaciDGV.BackgroundColor = SystemColors.ControlDarkDark;
            PodaciDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PodaciDGV.Location = new Point(12, 251);
            PodaciDGV.Name = "PodaciDGV";
            PodaciDGV.ReadOnly = true;
            PodaciDGV.RowTemplate.Height = 25;
            PodaciDGV.Size = new Size(278, 418);
            PodaciDGV.TabIndex = 6;
            PodaciDGV.SelectionChanged += PodaciDGV_SelectionChanged;
            // 
            // PregledKategorijaLbl
            // 
            PregledKategorijaLbl.AutoSize = true;
            PregledKategorijaLbl.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            PregledKategorijaLbl.Location = new Point(12, 133);
            PregledKategorijaLbl.Name = "PregledKategorijaLbl";
            PregledKategorijaLbl.Size = new Size(232, 31);
            PregledKategorijaLbl.TabIndex = 7;
            PregledKategorijaLbl.Text = "Pregled kategorija";
            // 
            // PregledProizvodaLbl
            // 
            PregledProizvodaLbl.AutoSize = true;
            PregledProizvodaLbl.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            PregledProizvodaLbl.Location = new Point(641, 78);
            PregledProizvodaLbl.Name = "PregledProizvodaLbl";
            PregledProizvodaLbl.Size = new Size(232, 31);
            PregledProizvodaLbl.TabIndex = 8;
            PregledProizvodaLbl.Text = "Pregled proizvoda";
            // 
            // KategorijeCmb
            // 
            KategorijeCmb.BackColor = SystemColors.GradientActiveCaption;
            KategorijeCmb.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            KategorijeCmb.FormattingEnabled = true;
            KategorijeCmb.Location = new Point(12, 183);
            KategorijeCmb.Name = "KategorijeCmb";
            KategorijeCmb.Size = new Size(234, 24);
            KategorijeCmb.TabIndex = 9;
            KategorijeCmb.SelectedIndexChanged += KategorijeCmb_SelectedIndexChanged;
            // 
            // OdaberiKategorijuBtn
            // 
            OdaberiKategorijuBtn.BackColor = SystemColors.ButtonHighlight;
            OdaberiKategorijuBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            OdaberiKategorijuBtn.Location = new Point(84, 212);
            OdaberiKategorijuBtn.Name = "OdaberiKategorijuBtn";
            OdaberiKategorijuBtn.Size = new Size(75, 23);
            OdaberiKategorijuBtn.TabIndex = 10;
            OdaberiKategorijuBtn.Text = "Odabir";
            OdaberiKategorijuBtn.UseVisualStyleBackColor = false;
            OdaberiKategorijuBtn.Click += odaberiKategorijuBtn_Click;
            // 
            // OdabranaKategorijaPokazLbl
            // 
            OdabranaKategorijaPokazLbl.AutoSize = true;
            OdabranaKategorijaPokazLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OdabranaKategorijaPokazLbl.Location = new Point(310, 100);
            OdabranaKategorijaPokazLbl.Name = "OdabranaKategorijaPokazLbl";
            OdabranaKategorijaPokazLbl.Size = new Size(157, 20);
            OdabranaKategorijaPokazLbl.TabIndex = 11;
            OdabranaKategorijaPokazLbl.Text = "Odabrana kategorija:";
            // 
            // OdabranaKategorijaLbl
            // 
            OdabranaKategorijaLbl.AutoSize = true;
            OdabranaKategorijaLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OdabranaKategorijaLbl.Location = new Point(471, 100);
            OdabranaKategorijaLbl.Name = "OdabranaKategorijaLbl";
            OdabranaKategorijaLbl.Size = new Size(24, 20);
            OdabranaKategorijaLbl.TabIndex = 12;
            OdabranaKategorijaLbl.Text = "---";
            // 
            // ProizvodiDGV
            // 
            ProizvodiDGV.BackgroundColor = SystemColors.ControlDarkDark;
            ProizvodiDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProizvodiDGV.Location = new Point(310, 133);
            ProizvodiDGV.Name = "ProizvodiDGV";
            ProizvodiDGV.RowTemplate.Height = 25;
            ProizvodiDGV.Size = new Size(942, 536);
            ProizvodiDGV.TabIndex = 13;
            ProizvodiDGV.SelectionChanged += ProizvodiDGV_SelectionChanged;
            // 
            // UrediProizvodBtn
            // 
            UrediProizvodBtn.BackColor = SystemColors.ButtonHighlight;
            UrediProizvodBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UrediProizvodBtn.Location = new Point(1132, 100);
            UrediProizvodBtn.Name = "UrediProizvodBtn";
            UrediProizvodBtn.Size = new Size(107, 28);
            UrediProizvodBtn.TabIndex = 14;
            UrediProizvodBtn.Text = "Uredi proizvod";
            UrediProizvodBtn.UseVisualStyleBackColor = false;
            UrediProizvodBtn.Click += UrediProizvodBtn_Click;
            // 
            // OdjavaBtn
            // 
            OdjavaBtn.BackColor = SystemColors.ButtonHighlight;
            OdjavaBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            OdjavaBtn.Location = new Point(971, 9);
            OdjavaBtn.Name = "OdjavaBtn";
            OdjavaBtn.Size = new Size(120, 32);
            OdjavaBtn.TabIndex = 15;
            OdjavaBtn.Text = "Odjavi se";
            OdjavaBtn.UseVisualStyleBackColor = false;
            OdjavaBtn.Visible = false;
            OdjavaBtn.Click += OdjavaBtn_Click;
            // 
            // ObrisanoBtn
            // 
            ObrisanoBtn.BackColor = SystemColors.ButtonHighlight;
            ObrisanoBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ObrisanoBtn.Location = new Point(1019, 100);
            ObrisanoBtn.Name = "ObrisanoBtn";
            ObrisanoBtn.Size = new Size(107, 28);
            ObrisanoBtn.TabIndex = 16;
            ObrisanoBtn.Text = "Obrisano";
            ObrisanoBtn.UseVisualStyleBackColor = false;
            ObrisanoBtn.Click += ObrisanoBtn_Click;
            // 
            // BrisiKategorijuBtn
            // 
            BrisiKategorijuBtn.BackColor = SystemColors.ButtonHighlight;
            BrisiKategorijuBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BrisiKategorijuBtn.Location = new Point(192, 222);
            BrisiKategorijuBtn.Name = "BrisiKategorijuBtn";
            BrisiKategorijuBtn.Size = new Size(98, 23);
            BrisiKategorijuBtn.TabIndex = 17;
            BrisiKategorijuBtn.Text = "Briši kategoriju";
            BrisiKategorijuBtn.UseVisualStyleBackColor = false;
            BrisiKategorijuBtn.Click += BrisiKategorijuBtn_Click;
            // 
            // DodajProizvodBtn
            // 
            DodajProizvodBtn.BackColor = SystemColors.ButtonHighlight;
            DodajProizvodBtn.Enabled = false;
            DodajProizvodBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DodajProizvodBtn.Location = new Point(906, 100);
            DodajProizvodBtn.Name = "DodajProizvodBtn";
            DodajProizvodBtn.Size = new Size(107, 28);
            DodajProizvodBtn.TabIndex = 18;
            DodajProizvodBtn.Text = "Dodaj proizvod";
            DodajProizvodBtn.UseVisualStyleBackColor = false;
            DodajProizvodBtn.Click += DodajProizvodBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(154, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // ZaNarucitiBtn
            // 
            ZaNarucitiBtn.BackColor = SystemColors.ButtonHighlight;
            ZaNarucitiBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ZaNarucitiBtn.Location = new Point(310, 12);
            ZaNarucitiBtn.Name = "ZaNarucitiBtn";
            ZaNarucitiBtn.Size = new Size(107, 28);
            ZaNarucitiBtn.TabIndex = 20;
            ZaNarucitiBtn.Text = "Za narudžbu";
            ZaNarucitiBtn.UseVisualStyleBackColor = false;
            ZaNarucitiBtn.Click += ZaNarucitiBtn_Click;
            // 
            // ZaprimiBtn
            // 
            ZaprimiBtn.BackColor = SystemColors.ButtonHighlight;
            ZaprimiBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ZaprimiBtn.Location = new Point(310, 46);
            ZaprimiBtn.Name = "ZaprimiBtn";
            ZaprimiBtn.Size = new Size(107, 28);
            ZaprimiBtn.TabIndex = 21;
            ZaprimiBtn.Text = "Zaprimi robu";
            ZaprimiBtn.UseVisualStyleBackColor = false;
            ZaprimiBtn.Click += ZaprimiBtn_Click;
            // 
            // IzdajBtn
            // 
            IzdajBtn.BackColor = SystemColors.ButtonHighlight;
            IzdajBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            IzdajBtn.Location = new Point(423, 12);
            IzdajBtn.Name = "IzdajBtn";
            IzdajBtn.Size = new Size(107, 28);
            IzdajBtn.TabIndex = 22;
            IzdajBtn.Text = "Izdaj robu";
            IzdajBtn.UseVisualStyleBackColor = false;
            IzdajBtn.Click += IzdajBtn_Click;
            // 
            // AdminPanelBtn
            // 
            AdminPanelBtn.BackColor = SystemColors.ButtonHighlight;
            AdminPanelBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AdminPanelBtn.Location = new Point(12, 98);
            AdminPanelBtn.Name = "AdminPanelBtn";
            AdminPanelBtn.Size = new Size(120, 32);
            AdminPanelBtn.TabIndex = 23;
            AdminPanelBtn.Text = "Admin panel";
            AdminPanelBtn.UseVisualStyleBackColor = false;
            AdminPanelBtn.Visible = false;
            AdminPanelBtn.Click += AdminPanelBtn_Click;
            // 
            // GlavniObrazac
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1264, 681);
            Controls.Add(AdminPanelBtn);
            Controls.Add(IzdajBtn);
            Controls.Add(ZaprimiBtn);
            Controls.Add(ZaNarucitiBtn);
            Controls.Add(pictureBox1);
            Controls.Add(DodajProizvodBtn);
            Controls.Add(BrisiKategorijuBtn);
            Controls.Add(ObrisanoBtn);
            Controls.Add(OdjavaBtn);
            Controls.Add(UrediProizvodBtn);
            Controls.Add(ProizvodiDGV);
            Controls.Add(OdabranaKategorijaLbl);
            Controls.Add(OdabranaKategorijaPokazLbl);
            Controls.Add(OdaberiKategorijuBtn);
            Controls.Add(KategorijeCmb);
            Controls.Add(PregledProizvodaLbl);
            Controls.Add(PregledKategorijaLbl);
            Controls.Add(PodaciDGV);
            Controls.Add(KorImeLbl);
            Controls.Add(KorisnikPictureBox);
            Controls.Add(KorisnikLbl);
            Controls.Add(RegistracijaBtn);
            Controls.Add(PrijavaBtn);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GlavniObrazac";
            Text = "Glavni obrazac";
            Load += GlavniObrazac_Load;
            ((System.ComponentModel.ISupportInitialize)KorisnikPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PodaciDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProizvodiDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PrijavaBtn;
        private Button RegistracijaBtn;
        private Label KorisnikLbl;
        private PictureBox KorisnikPictureBox;
        private Label KorImeLbl;
        private DataGridView PodaciDGV;
        private Label PregledKategorijaLbl;
        private Label PregledProizvodaLbl;
        private ComboBox KategorijeCmb;
        private Button OdaberiKategorijuBtn;
        private Label OdabranaKategorijaPokazLbl;
        private Label OdabranaKategorijaLbl;
        private DataGridView ProizvodiDGV;
        private Button UrediProizvodBtn;
        private Button OdjavaBtn;
        private ToolTip UrediProizvodTt;
        private Button ObrisanoBtn;
        private Button BrisiKategorijuBtn;
        private Button DodajProizvodBtn;
        private PictureBox pictureBox1;
        private Button ZaNarucitiBtn;
        private Button ZaprimiBtn;
        private Button IzdajBtn;
        private Button AdminPanelBtn;
    }
}
