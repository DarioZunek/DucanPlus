namespace WMS
{
    partial class UrediProizvodForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrediProizvodForm));
            NaslovLbl = new Label();
            IdLbl = new Label();
            IdTxtb = new TextBox();
            NazivLbl = new Label();
            NazivTxtb = new TextBox();
            CijenaTxtb = new TextBox();
            CijenaLbl = new Label();
            KolicinaTxtb = new TextBox();
            KolicinaLbl = new Label();
            OpisTxtb = new TextBox();
            OpisLbl = new Label();
            DimenzijeTxtb = new TextBox();
            DimenzijeLbl = new Label();
            SpremiBtn = new Button();
            GreskaLbl = new Label();
            NabavnaCijenaLbl = new Label();
            NabavnaCijenaTxtb = new TextBox();
            TezinaLbl = new Label();
            TezinaTxtb = new TextBox();
            MinimalnaKolicinaTxtb = new TextBox();
            MinimalnaKolicinaLbl = new Label();
            DatumIstekaDtp = new DateTimePicker();
            RokIstekaLbl = new Label();
            KategorijaCmb = new ComboBox();
            KategorijaIDLbl = new Label();
            DobavljaciCmb = new ComboBox();
            DobavljacIDLbl = new Label();
            ObrisanoLbl = new Label();
            ObrisanoCb = new CheckBox();
            SuspendLayout();
            // 
            // NaslovLbl
            // 
            NaslovLbl.AutoSize = true;
            NaslovLbl.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            NaslovLbl.Location = new Point(367, 10);
            NaslovLbl.Name = "NaslovLbl";
            NaslovLbl.Size = new Size(189, 31);
            NaslovLbl.TabIndex = 0;
            NaslovLbl.Text = "Uredi proizvod";
            // 
            // IdLbl
            // 
            IdLbl.AutoSize = true;
            IdLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            IdLbl.Location = new Point(77, 73);
            IdLbl.Name = "IdLbl";
            IdLbl.Size = new Size(62, 16);
            IdLbl.TabIndex = 1;
            IdLbl.Text = "ID artikla:";
            // 
            // IdTxtb
            // 
            IdTxtb.Location = new Point(160, 71);
            IdTxtb.MaxLength = 30;
            IdTxtb.Name = "IdTxtb";
            IdTxtb.ReadOnly = true;
            IdTxtb.Size = new Size(317, 22);
            IdTxtb.TabIndex = 2;
            // 
            // NazivLbl
            // 
            NazivLbl.AutoSize = true;
            NazivLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            NazivLbl.Location = new Point(55, 115);
            NazivLbl.Name = "NazivLbl";
            NazivLbl.Size = new Size(83, 16);
            NazivLbl.TabIndex = 3;
            NazivLbl.Text = "Naziv artikla:";
            // 
            // NazivTxtb
            // 
            NazivTxtb.BackColor = SystemColors.HighlightText;
            NazivTxtb.Location = new Point(160, 114);
            NazivTxtb.MaxLength = 30;
            NazivTxtb.Name = "NazivTxtb";
            NazivTxtb.Size = new Size(317, 22);
            NazivTxtb.TabIndex = 4;
            // 
            // CijenaTxtb
            // 
            CijenaTxtb.BackColor = SystemColors.HighlightText;
            CijenaTxtb.Location = new Point(160, 157);
            CijenaTxtb.MaxLength = 30;
            CijenaTxtb.Name = "CijenaTxtb";
            CijenaTxtb.Size = new Size(317, 22);
            CijenaTxtb.TabIndex = 5;
            CijenaTxtb.TextChanged += CijenaTxtb_TextChanged;
            CijenaTxtb.Enter += CijenaTxtb_Enter;
            CijenaTxtb.Leave += CijenaTxtb_Leave;
            // 
            // CijenaLbl
            // 
            CijenaLbl.AutoSize = true;
            CijenaLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CijenaLbl.Location = new Point(50, 158);
            CijenaLbl.Name = "CijenaLbl";
            CijenaLbl.Size = new Size(87, 16);
            CijenaLbl.TabIndex = 6;
            CijenaLbl.Text = "Cijena artikla:";
            // 
            // KolicinaTxtb
            // 
            KolicinaTxtb.BackColor = SystemColors.HighlightText;
            KolicinaTxtb.Location = new Point(160, 199);
            KolicinaTxtb.MaxLength = 30;
            KolicinaTxtb.Name = "KolicinaTxtb";
            KolicinaTxtb.Size = new Size(317, 22);
            KolicinaTxtb.TabIndex = 7;
            KolicinaTxtb.TextChanged += KolicinaTxtb_TextChanged;
            KolicinaTxtb.Enter += KolicinaTxtb_Enter;
            KolicinaTxtb.Leave += KolicinaTxtb_Leave;
            // 
            // KolicinaLbl
            // 
            KolicinaLbl.AutoSize = true;
            KolicinaLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            KolicinaLbl.Location = new Point(40, 201);
            KolicinaLbl.Name = "KolicinaLbl";
            KolicinaLbl.Size = new Size(96, 16);
            KolicinaLbl.TabIndex = 8;
            KolicinaLbl.Text = "Količina artikla:";
            // 
            // OpisTxtb
            // 
            OpisTxtb.BackColor = SystemColors.HighlightText;
            OpisTxtb.Location = new Point(160, 285);
            OpisTxtb.MaxLength = 300;
            OpisTxtb.Multiline = true;
            OpisTxtb.Name = "OpisTxtb";
            OpisTxtb.ScrollBars = ScrollBars.Vertical;
            OpisTxtb.Size = new Size(317, 85);
            OpisTxtb.TabIndex = 9;
            // 
            // OpisLbl
            // 
            OpisLbl.AutoSize = true;
            OpisLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            OpisLbl.Location = new Point(61, 285);
            OpisLbl.Name = "OpisLbl";
            OpisLbl.Size = new Size(77, 16);
            OpisLbl.TabIndex = 10;
            OpisLbl.Text = "Opis artikla:";
            // 
            // DimenzijeTxtb
            // 
            DimenzijeTxtb.BackColor = SystemColors.HighlightText;
            DimenzijeTxtb.Location = new Point(160, 391);
            DimenzijeTxtb.MaxLength = 30;
            DimenzijeTxtb.Name = "DimenzijeTxtb";
            DimenzijeTxtb.Size = new Size(317, 22);
            DimenzijeTxtb.TabIndex = 13;
            // 
            // DimenzijeLbl
            // 
            DimenzijeLbl.AutoSize = true;
            DimenzijeLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DimenzijeLbl.Location = new Point(72, 393);
            DimenzijeLbl.Name = "DimenzijeLbl";
            DimenzijeLbl.Size = new Size(69, 16);
            DimenzijeLbl.TabIndex = 14;
            DimenzijeLbl.Text = "Dimenzije:";
            // 
            // SpremiBtn
            // 
            SpremiBtn.BackColor = SystemColors.ButtonHighlight;
            SpremiBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            SpremiBtn.Location = new Point(408, 551);
            SpremiBtn.Name = "SpremiBtn";
            SpremiBtn.Size = new Size(129, 30);
            SpremiBtn.TabIndex = 15;
            SpremiBtn.Text = "Spremi";
            SpremiBtn.UseVisualStyleBackColor = false;
            SpremiBtn.Click += SpremiBtn_Click;
            // 
            // GreskaLbl
            // 
            GreskaLbl.AutoSize = true;
            GreskaLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            GreskaLbl.ForeColor = Color.Red;
            GreskaLbl.Location = new Point(346, 585);
            GreskaLbl.Name = "GreskaLbl";
            GreskaLbl.Size = new Size(242, 20);
            GreskaLbl.TabIndex = 16;
            GreskaLbl.Text = "Uneseni podaci nisu ispravni!";
            GreskaLbl.Visible = false;
            // 
            // NabavnaCijenaLbl
            // 
            NabavnaCijenaLbl.AutoSize = true;
            NabavnaCijenaLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            NabavnaCijenaLbl.Location = new Point(34, 243);
            NabavnaCijenaLbl.Name = "NabavnaCijenaLbl";
            NabavnaCijenaLbl.Size = new Size(105, 16);
            NabavnaCijenaLbl.TabIndex = 17;
            NabavnaCijenaLbl.Text = "Nabavna cijena:";
            // 
            // NabavnaCijenaTxtb
            // 
            NabavnaCijenaTxtb.BackColor = SystemColors.HighlightText;
            NabavnaCijenaTxtb.Location = new Point(160, 242);
            NabavnaCijenaTxtb.MaxLength = 30;
            NabavnaCijenaTxtb.Name = "NabavnaCijenaTxtb";
            NabavnaCijenaTxtb.Size = new Size(317, 22);
            NabavnaCijenaTxtb.TabIndex = 18;
            NabavnaCijenaTxtb.TextChanged += NabavnaCijenaTxtb_TextChanged;
            NabavnaCijenaTxtb.Enter += NabavnaCijenaTxtb_Enter;
            NabavnaCijenaTxtb.Leave += NabavnaCijenaTxtb_Leave;
            // 
            // TezinaLbl
            // 
            TezinaLbl.AutoSize = true;
            TezinaLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TezinaLbl.Location = new Point(97, 435);
            TezinaLbl.Name = "TezinaLbl";
            TezinaLbl.Size = new Size(51, 16);
            TezinaLbl.TabIndex = 19;
            TezinaLbl.Text = "Težina:";
            // 
            // TezinaTxtb
            // 
            TezinaTxtb.BackColor = SystemColors.HighlightText;
            TezinaTxtb.Location = new Point(160, 434);
            TezinaTxtb.MaxLength = 30;
            TezinaTxtb.Name = "TezinaTxtb";
            TezinaTxtb.Size = new Size(317, 22);
            TezinaTxtb.TabIndex = 20;
            TezinaTxtb.TextChanged += TezinaTxtb_TextChanged;
            TezinaTxtb.Enter += TezinaTxtb_Enter;
            TezinaTxtb.Leave += TezinaTxtb_Leave;
            // 
            // MinimalnaKolicinaTxtb
            // 
            MinimalnaKolicinaTxtb.BackColor = SystemColors.HighlightText;
            MinimalnaKolicinaTxtb.Location = new Point(160, 477);
            MinimalnaKolicinaTxtb.MaxLength = 30;
            MinimalnaKolicinaTxtb.Name = "MinimalnaKolicinaTxtb";
            MinimalnaKolicinaTxtb.Size = new Size(317, 22);
            MinimalnaKolicinaTxtb.TabIndex = 21;
            MinimalnaKolicinaTxtb.TextChanged += MinimalnaKolicinaTxtb_TextChanged;
            MinimalnaKolicinaTxtb.Enter += MinimalnaKolicinaTxtb_Enter;
            MinimalnaKolicinaTxtb.Leave += MinimalnaKolicinaTxtb_Leave;
            // 
            // MinimalnaKolicinaLbl
            // 
            MinimalnaKolicinaLbl.AutoSize = true;
            MinimalnaKolicinaLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            MinimalnaKolicinaLbl.Location = new Point(10, 478);
            MinimalnaKolicinaLbl.Name = "MinimalnaKolicinaLbl";
            MinimalnaKolicinaLbl.Size = new Size(120, 16);
            MinimalnaKolicinaLbl.TabIndex = 22;
            MinimalnaKolicinaLbl.Text = "Minimalna kolicina:";
            // 
            // DatumIstekaDtp
            // 
            DatumIstekaDtp.Location = new Point(624, 73);
            DatumIstekaDtp.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            DatumIstekaDtp.Name = "DatumIstekaDtp";
            DatumIstekaDtp.Size = new Size(228, 22);
            DatumIstekaDtp.TabIndex = 23;
            // 
            // RokIstekaLbl
            // 
            RokIstekaLbl.AutoSize = true;
            RokIstekaLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            RokIstekaLbl.Location = new Point(533, 73);
            RokIstekaLbl.Name = "RokIstekaLbl";
            RokIstekaLbl.Size = new Size(74, 16);
            RokIstekaLbl.TabIndex = 24;
            RokIstekaLbl.Text = "Rok isteka:";
            // 
            // KategorijaCmb
            // 
            KategorijaCmb.BackColor = SystemColors.GradientInactiveCaption;
            KategorijaCmb.FormattingEnabled = true;
            KategorijaCmb.Location = new Point(624, 112);
            KategorijaCmb.Name = "KategorijaCmb";
            KategorijaCmb.Size = new Size(228, 24);
            KategorijaCmb.TabIndex = 25;
            // 
            // KategorijaIDLbl
            // 
            KategorijaIDLbl.AutoSize = true;
            KategorijaIDLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            KategorijaIDLbl.Location = new Point(533, 112);
            KategorijaIDLbl.Name = "KategorijaIDLbl";
            KategorijaIDLbl.Size = new Size(71, 16);
            KategorijaIDLbl.TabIndex = 26;
            KategorijaIDLbl.Text = "Kategorija:";
            // 
            // DobavljaciCmb
            // 
            DobavljaciCmb.BackColor = SystemColors.GradientInactiveCaption;
            DobavljaciCmb.FormattingEnabled = true;
            DobavljaciCmb.Location = new Point(624, 155);
            DobavljaciCmb.Name = "DobavljaciCmb";
            DobavljaciCmb.Size = new Size(228, 24);
            DobavljaciCmb.TabIndex = 27;
            // 
            // DobavljacIDLbl
            // 
            DobavljacIDLbl.AutoSize = true;
            DobavljacIDLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DobavljacIDLbl.Location = new Point(533, 155);
            DobavljacIDLbl.Name = "DobavljacIDLbl";
            DobavljacIDLbl.Size = new Size(72, 16);
            DobavljacIDLbl.TabIndex = 28;
            DobavljacIDLbl.Text = "Dobavljač:";
            // 
            // ObrisanoLbl
            // 
            ObrisanoLbl.AutoSize = true;
            ObrisanoLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ObrisanoLbl.Location = new Point(539, 197);
            ObrisanoLbl.Name = "ObrisanoLbl";
            ObrisanoLbl.Size = new Size(65, 16);
            ObrisanoLbl.TabIndex = 29;
            ObrisanoLbl.Text = "Obrisano:";
            // 
            // ObrisanoCb
            // 
            ObrisanoCb.AutoSize = true;
            ObrisanoCb.Location = new Point(624, 197);
            ObrisanoCb.Name = "ObrisanoCb";
            ObrisanoCb.Size = new Size(79, 20);
            ObrisanoCb.TabIndex = 30;
            ObrisanoCb.Text = "obrisano";
            ObrisanoCb.UseVisualStyleBackColor = true;
            // 
            // UrediProizvodForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(866, 622);
            Controls.Add(ObrisanoCb);
            Controls.Add(ObrisanoLbl);
            Controls.Add(DobavljacIDLbl);
            Controls.Add(DobavljaciCmb);
            Controls.Add(KategorijaIDLbl);
            Controls.Add(KategorijaCmb);
            Controls.Add(RokIstekaLbl);
            Controls.Add(DatumIstekaDtp);
            Controls.Add(MinimalnaKolicinaLbl);
            Controls.Add(MinimalnaKolicinaTxtb);
            Controls.Add(TezinaTxtb);
            Controls.Add(TezinaLbl);
            Controls.Add(NabavnaCijenaTxtb);
            Controls.Add(NabavnaCijenaLbl);
            Controls.Add(GreskaLbl);
            Controls.Add(SpremiBtn);
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
            Controls.Add(IdTxtb);
            Controls.Add(IdLbl);
            Controls.Add(NaslovLbl);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UrediProizvodForm";
            Text = "Uredi artikl";
            Load += UrediArtiklForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NaslovLbl;
        private Label IdLbl;
        private TextBox IdTxtb;
        private Label NazivLbl;
        private TextBox NazivTxtb;
        private TextBox CijenaTxtb;
        private Label CijenaLbl;
        private TextBox KolicinaTxtb;
        private Label KolicinaLbl;
        private TextBox OpisTxtb;
        private Label OpisLbl;
        private TextBox DimenzijeTxtb;
        private Label DimenzijeLbl;
        private Button SpremiBtn;
        private Label GreskaLbl;
        private Label NabavnaCijenaLbl;
        private TextBox NabavnaCijenaTxtb;
        private Label TezinaLbl;
        private TextBox TezinaTxtb;
        private TextBox MinimalnaKolicinaTxtb;
        private Label MinimalnaKolicinaLbl;
        private DateTimePicker DatumIstekaDtp;
        private Label RokIstekaLbl;
        private ComboBox KategorijaCmb;
        private Label KategorijaIDLbl;
        private ComboBox DobavljaciCmb;
        private Label DobavljacIDLbl;
        private Label ObrisanoLbl;
        private CheckBox ObrisanoCb;
    }
}