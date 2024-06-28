namespace WMS
{
    partial class DodajProizvodForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajProizvodForm));
            NaslovLbl = new Label();
            ObrisanoCb = new CheckBox();
            ObrisanoLbl = new Label();
            DobavljacIDLbl = new Label();
            DobavljaciCmb = new ComboBox();
            KategorijaIDLbl = new Label();
            KategorijeCmb = new ComboBox();
            RokIstekaLbl = new Label();
            DatumIstekaDtp = new DateTimePicker();
            MinimalnaKolicinaLbl = new Label();
            MinimalnaKolicinaTxtb = new TextBox();
            TezinaTxtb = new TextBox();
            TezinaLbl = new Label();
            NabavnaCijenaTxtb = new TextBox();
            NabavnaCijenaLbl = new Label();
            DimenzijeLbl = new Label();
            DimenzijeTxtb = new TextBox();
            OpisLbl = new Label();
            OpisTxtb = new TextBox();
            KolicinaLbl = new Label();
            KolicinaTxtb = new TextBox();
            CijenaLbl = new Label();
            CijenaTxtb = new TextBox();
            NazivTxtb = new TextBox();
            NazivLbl = new Label();
            SpremiBtn = new Button();
            GreskaLbl = new Label();
            SuspendLayout();
            // 
            // NaslovLbl
            // 
            NaslovLbl.AutoSize = true;
            NaslovLbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            NaslovLbl.Location = new Point(279, 9);
            NaslovLbl.Name = "NaslovLbl";
            NaslovLbl.Size = new Size(201, 37);
            NaslovLbl.TabIndex = 0;
            NaslovLbl.Text = "Dodaj proizvod";
            // 
            // ObrisanoCb
            // 
            ObrisanoCb.AutoSize = true;
            ObrisanoCb.Location = new Point(562, 184);
            ObrisanoCb.Name = "ObrisanoCb";
            ObrisanoCb.Size = new Size(74, 19);
            ObrisanoCb.TabIndex = 56;
            ObrisanoCb.Text = "obrisano";
            ObrisanoCb.UseVisualStyleBackColor = true;
            // 
            // ObrisanoLbl
            // 
            ObrisanoLbl.AutoSize = true;
            ObrisanoLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ObrisanoLbl.Location = new Point(488, 184);
            ObrisanoLbl.Name = "ObrisanoLbl";
            ObrisanoLbl.Size = new Size(65, 16);
            ObrisanoLbl.TabIndex = 55;
            ObrisanoLbl.Text = "Obrisano:";
            // 
            // DobavljacIDLbl
            // 
            DobavljacIDLbl.AutoSize = true;
            DobavljacIDLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DobavljacIDLbl.Location = new Point(482, 144);
            DobavljacIDLbl.Name = "DobavljacIDLbl";
            DobavljacIDLbl.Size = new Size(72, 16);
            DobavljacIDLbl.TabIndex = 54;
            DobavljacIDLbl.Text = "Dobavljač:";
            // 
            // DobavljaciCmb
            // 
            DobavljaciCmb.BackColor = SystemColors.InactiveCaption;
            DobavljaciCmb.FormattingEnabled = true;
            DobavljaciCmb.Location = new Point(562, 144);
            DobavljaciCmb.Name = "DobavljaciCmb";
            DobavljaciCmb.Size = new Size(200, 23);
            DobavljaciCmb.TabIndex = 53;
            DobavljaciCmb.SelectedIndexChanged += DobavljaciCmb_SelectedIndexChanged;
            // 
            // KategorijaIDLbl
            // 
            KategorijaIDLbl.AutoSize = true;
            KategorijaIDLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            KategorijaIDLbl.Location = new Point(482, 104);
            KategorijaIDLbl.Name = "KategorijaIDLbl";
            KategorijaIDLbl.Size = new Size(71, 16);
            KategorijaIDLbl.TabIndex = 52;
            KategorijaIDLbl.Text = "Kategorija:";
            // 
            // KategorijeCmb
            // 
            KategorijeCmb.BackColor = SystemColors.InactiveCaption;
            KategorijeCmb.FormattingEnabled = true;
            KategorijeCmb.Location = new Point(562, 104);
            KategorijeCmb.Name = "KategorijeCmb";
            KategorijeCmb.Size = new Size(200, 23);
            KategorijeCmb.TabIndex = 51;
            KategorijeCmb.SelectedIndexChanged += KategorijeCmb_SelectedIndexChanged;
            // 
            // RokIstekaLbl
            // 
            RokIstekaLbl.AutoSize = true;
            RokIstekaLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            RokIstekaLbl.Location = new Point(482, 67);
            RokIstekaLbl.Name = "RokIstekaLbl";
            RokIstekaLbl.Size = new Size(74, 16);
            RokIstekaLbl.TabIndex = 50;
            RokIstekaLbl.Text = "Rok isteka:";
            // 
            // DatumIstekaDtp
            // 
            DatumIstekaDtp.Location = new Point(562, 67);
            DatumIstekaDtp.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            DatumIstekaDtp.Name = "DatumIstekaDtp";
            DatumIstekaDtp.Size = new Size(200, 21);
            DatumIstekaDtp.TabIndex = 49;
            // 
            // MinimalnaKolicinaLbl
            // 
            MinimalnaKolicinaLbl.AutoSize = true;
            MinimalnaKolicinaLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            MinimalnaKolicinaLbl.Location = new Point(25, 408);
            MinimalnaKolicinaLbl.Name = "MinimalnaKolicinaLbl";
            MinimalnaKolicinaLbl.Size = new Size(120, 16);
            MinimalnaKolicinaLbl.TabIndex = 48;
            MinimalnaKolicinaLbl.Text = "Minimalna kolicina:";
            // 
            // MinimalnaKolicinaTxtb
            // 
            MinimalnaKolicinaTxtb.BackColor = SystemColors.HighlightText;
            MinimalnaKolicinaTxtb.Location = new Point(156, 407);
            MinimalnaKolicinaTxtb.MaxLength = 30;
            MinimalnaKolicinaTxtb.Name = "MinimalnaKolicinaTxtb";
            MinimalnaKolicinaTxtb.PlaceholderText = "99";
            MinimalnaKolicinaTxtb.Size = new Size(278, 21);
            MinimalnaKolicinaTxtb.TabIndex = 47;
            MinimalnaKolicinaTxtb.TextChanged += MinimalnaKolicinaTxtb_TextChanged;
            MinimalnaKolicinaTxtb.Enter += MinimalnaKolicinaTxtb_Enter;
            MinimalnaKolicinaTxtb.Leave += MinimalnaKolicinaTxtb_Leave;
            // 
            // TezinaTxtb
            // 
            TezinaTxtb.BackColor = SystemColors.HighlightText;
            TezinaTxtb.Location = new Point(156, 367);
            TezinaTxtb.MaxLength = 30;
            TezinaTxtb.Name = "TezinaTxtb";
            TezinaTxtb.PlaceholderText = "9,9";
            TezinaTxtb.Size = new Size(278, 21);
            TezinaTxtb.TabIndex = 46;
            TezinaTxtb.TextChanged += TezinaTxtb_TextChanged;
            TezinaTxtb.Enter += TezinaTxtb_Enter;
            TezinaTxtb.Leave += TezinaTxtb_Leave;
            // 
            // TezinaLbl
            // 
            TezinaLbl.AutoSize = true;
            TezinaLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TezinaLbl.Location = new Point(101, 368);
            TezinaLbl.Name = "TezinaLbl";
            TezinaLbl.Size = new Size(51, 16);
            TezinaLbl.TabIndex = 45;
            TezinaLbl.Text = "Težina:";
            // 
            // NabavnaCijenaTxtb
            // 
            NabavnaCijenaTxtb.BackColor = SystemColors.HighlightText;
            NabavnaCijenaTxtb.Location = new Point(156, 187);
            NabavnaCijenaTxtb.MaxLength = 30;
            NabavnaCijenaTxtb.Name = "NabavnaCijenaTxtb";
            NabavnaCijenaTxtb.PlaceholderText = "9,99";
            NabavnaCijenaTxtb.Size = new Size(278, 21);
            NabavnaCijenaTxtb.TabIndex = 44;
            NabavnaCijenaTxtb.TextChanged += NabavnaCijenaTxtb_TextChanged;
            NabavnaCijenaTxtb.Enter += NabavnaCijenaTxtb_Enter;
            NabavnaCijenaTxtb.Leave += NabavnaCijenaTxtb_Leave;
            // 
            // NabavnaCijenaLbl
            // 
            NabavnaCijenaLbl.AutoSize = true;
            NabavnaCijenaLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            NabavnaCijenaLbl.Location = new Point(46, 188);
            NabavnaCijenaLbl.Name = "NabavnaCijenaLbl";
            NabavnaCijenaLbl.Size = new Size(105, 16);
            NabavnaCijenaLbl.TabIndex = 43;
            NabavnaCijenaLbl.Text = "Nabavna cijena:";
            // 
            // DimenzijeLbl
            // 
            DimenzijeLbl.AutoSize = true;
            DimenzijeLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DimenzijeLbl.Location = new Point(79, 328);
            DimenzijeLbl.Name = "DimenzijeLbl";
            DimenzijeLbl.Size = new Size(69, 16);
            DimenzijeLbl.TabIndex = 42;
            DimenzijeLbl.Text = "Dimenzije:";
            // 
            // DimenzijeTxtb
            // 
            DimenzijeTxtb.BackColor = SystemColors.HighlightText;
            DimenzijeTxtb.Location = new Point(156, 327);
            DimenzijeTxtb.MaxLength = 30;
            DimenzijeTxtb.Name = "DimenzijeTxtb";
            DimenzijeTxtb.PlaceholderText = "9x9x9";
            DimenzijeTxtb.Size = new Size(278, 21);
            DimenzijeTxtb.TabIndex = 41;
            // 
            // OpisLbl
            // 
            OpisLbl.AutoSize = true;
            OpisLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            OpisLbl.Location = new Point(69, 227);
            OpisLbl.Name = "OpisLbl";
            OpisLbl.Size = new Size(77, 16);
            OpisLbl.TabIndex = 40;
            OpisLbl.Text = "Opis artikla:";
            // 
            // OpisTxtb
            // 
            OpisTxtb.BackColor = SystemColors.HighlightText;
            OpisTxtb.Location = new Point(156, 227);
            OpisTxtb.MaxLength = 300;
            OpisTxtb.Multiline = true;
            OpisTxtb.Name = "OpisTxtb";
            OpisTxtb.PlaceholderText = "Opis artikla.";
            OpisTxtb.ScrollBars = ScrollBars.Vertical;
            OpisTxtb.Size = new Size(278, 80);
            OpisTxtb.TabIndex = 39;
            // 
            // KolicinaLbl
            // 
            KolicinaLbl.AutoSize = true;
            KolicinaLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            KolicinaLbl.Location = new Point(51, 148);
            KolicinaLbl.Name = "KolicinaLbl";
            KolicinaLbl.Size = new Size(96, 16);
            KolicinaLbl.TabIndex = 38;
            KolicinaLbl.Text = "Količina artikla:";
            // 
            // KolicinaTxtb
            // 
            KolicinaTxtb.BackColor = SystemColors.HighlightText;
            KolicinaTxtb.Location = new Point(156, 147);
            KolicinaTxtb.MaxLength = 30;
            KolicinaTxtb.Name = "KolicinaTxtb";
            KolicinaTxtb.PlaceholderText = "99";
            KolicinaTxtb.Size = new Size(278, 21);
            KolicinaTxtb.TabIndex = 37;
            KolicinaTxtb.TextChanged += KolicinaTxtb_TextChanged;
            KolicinaTxtb.Enter += KolicinaTxtb_Enter;
            KolicinaTxtb.Leave += KolicinaTxtb_Leave;
            // 
            // CijenaLbl
            // 
            CijenaLbl.AutoSize = true;
            CijenaLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CijenaLbl.Location = new Point(60, 108);
            CijenaLbl.Name = "CijenaLbl";
            CijenaLbl.Size = new Size(87, 16);
            CijenaLbl.TabIndex = 36;
            CijenaLbl.Text = "Cijena artikla:";
            // 
            // CijenaTxtb
            // 
            CijenaTxtb.BackColor = SystemColors.HighlightText;
            CijenaTxtb.Location = new Point(156, 107);
            CijenaTxtb.MaxLength = 30;
            CijenaTxtb.Name = "CijenaTxtb";
            CijenaTxtb.PlaceholderText = "9,99";
            CijenaTxtb.Size = new Size(278, 21);
            CijenaTxtb.TabIndex = 35;
            CijenaTxtb.TextChanged += CijenaTxtb_TextChanged;
            CijenaTxtb.Enter += CijenaTxtb_Enter;
            CijenaTxtb.Leave += CijenaTxtb_Leave;
            // 
            // NazivTxtb
            // 
            NazivTxtb.BackColor = SystemColors.HighlightText;
            NazivTxtb.Location = new Point(156, 67);
            NazivTxtb.MaxLength = 30;
            NazivTxtb.Name = "NazivTxtb";
            NazivTxtb.PlaceholderText = "Naziv";
            NazivTxtb.Size = new Size(278, 21);
            NazivTxtb.TabIndex = 34;
            // 
            // NazivLbl
            // 
            NazivLbl.AutoSize = true;
            NazivLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            NazivLbl.Location = new Point(64, 68);
            NazivLbl.Name = "NazivLbl";
            NazivLbl.Size = new Size(83, 16);
            NazivLbl.TabIndex = 33;
            NazivLbl.Text = "Naziv artikla:";
            // 
            // SpremiBtn
            // 
            SpremiBtn.BackColor = SystemColors.ButtonHighlight;
            SpremiBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SpremiBtn.Location = new Point(335, 446);
            SpremiBtn.Name = "SpremiBtn";
            SpremiBtn.Size = new Size(99, 28);
            SpremiBtn.TabIndex = 57;
            SpremiBtn.Text = "Spremi";
            SpremiBtn.UseVisualStyleBackColor = false;
            SpremiBtn.Click += SpremiBtn_Click;
            // 
            // GreskaLbl
            // 
            GreskaLbl.AutoSize = true;
            GreskaLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            GreskaLbl.ForeColor = Color.Red;
            GreskaLbl.Location = new Point(269, 477);
            GreskaLbl.Name = "GreskaLbl";
            GreskaLbl.Size = new Size(242, 20);
            GreskaLbl.TabIndex = 58;
            GreskaLbl.Text = "Uneseni podaci nisu ispravni!";
            GreskaLbl.Visible = false;
            // 
            // DodajProizvodForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(770, 513);
            Controls.Add(GreskaLbl);
            Controls.Add(SpremiBtn);
            Controls.Add(ObrisanoCb);
            Controls.Add(ObrisanoLbl);
            Controls.Add(DobavljacIDLbl);
            Controls.Add(DobavljaciCmb);
            Controls.Add(KategorijaIDLbl);
            Controls.Add(KategorijeCmb);
            Controls.Add(RokIstekaLbl);
            Controls.Add(DatumIstekaDtp);
            Controls.Add(MinimalnaKolicinaLbl);
            Controls.Add(MinimalnaKolicinaTxtb);
            Controls.Add(TezinaTxtb);
            Controls.Add(TezinaLbl);
            Controls.Add(NabavnaCijenaTxtb);
            Controls.Add(NabavnaCijenaLbl);
            Controls.Add(DimenzijeLbl);
            Controls.Add(DimenzijeTxtb);
            Controls.Add(OpisLbl);
            Controls.Add(OpisTxtb);
            Controls.Add(KolicinaLbl);
            Controls.Add(KolicinaTxtb);
            Controls.Add(CijenaLbl);
            Controls.Add(CijenaTxtb);
            Controls.Add(NazivTxtb);
            Controls.Add(NazivLbl);
            Controls.Add(NaslovLbl);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DodajProizvodForm";
            Text = "DodajProizvodForm";
            Load += DodajProizvodForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NaslovLbl;
        private CheckBox ObrisanoCb;
        private Label ObrisanoLbl;
        private Label DobavljacIDLbl;
        private ComboBox DobavljaciCmb;
        private Label KategorijaIDLbl;
        private ComboBox KategorijeCmb;
        private Label RokIstekaLbl;
        private DateTimePicker DatumIstekaDtp;
        private Label MinimalnaKolicinaLbl;
        private TextBox MinimalnaKolicinaTxtb;
        private TextBox TezinaTxtb;
        private Label TezinaLbl;
        private TextBox NabavnaCijenaTxtb;
        private Label NabavnaCijenaLbl;
        private Label DimenzijeLbl;
        private TextBox DimenzijeTxtb;
        private Label OpisLbl;
        private TextBox OpisTxtb;
        private Label KolicinaLbl;
        private TextBox KolicinaTxtb;
        private Label CijenaLbl;
        private TextBox CijenaTxtb;
        private TextBox NazivTxtb;
        private Label NazivLbl;
        private Button SpremiBtn;
        private Label GreskaLbl;
    }
}