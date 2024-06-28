namespace WMS
{
    partial class RegistracijaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistracijaForm));
            NaslovLbl = new Label();
            ImeLbl = new Label();
            PrezimeLbl = new Label();
            KorimeLbl = new Label();
            LozinkaLbl = new Label();
            DatumRodenjaLbl = new Label();
            DatumRodenjaDTP = new DateTimePicker();
            ImeTxtb = new TextBox();
            PrezimeTxtb = new TextBox();
            KorimeTxtb = new TextBox();
            EmailTxtb = new TextBox();
            EmailLbl = new Label();
            LozinkaTxtb = new TextBox();
            PonovljenLozinkaTxtb = new TextBox();
            PonovljenaLozinkaLbl = new Label();
            RegistracijaBtn = new Button();
            GreskaLbl = new Label();
            SuspendLayout();
            // 
            // NaslovLbl
            // 
            NaslovLbl.AutoSize = true;
            NaslovLbl.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            NaslovLbl.Location = new Point(101, 9);
            NaslovLbl.Name = "NaslovLbl";
            NaslovLbl.Size = new Size(196, 31);
            NaslovLbl.TabIndex = 0;
            NaslovLbl.Text = "Registrirajte se";
            // 
            // ImeLbl
            // 
            ImeLbl.AutoSize = true;
            ImeLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ImeLbl.Location = new Point(101, 56);
            ImeLbl.Name = "ImeLbl";
            ImeLbl.Size = new Size(32, 16);
            ImeLbl.TabIndex = 1;
            ImeLbl.Text = "Ime:";
            // 
            // PrezimeLbl
            // 
            PrezimeLbl.AutoSize = true;
            PrezimeLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PrezimeLbl.Location = new Point(76, 85);
            PrezimeLbl.Name = "PrezimeLbl";
            PrezimeLbl.Size = new Size(59, 16);
            PrezimeLbl.TabIndex = 2;
            PrezimeLbl.Text = "Prezime:";
            // 
            // KorimeLbl
            // 
            KorimeLbl.AutoSize = true;
            KorimeLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            KorimeLbl.Location = new Point(36, 172);
            KorimeLbl.Name = "KorimeLbl";
            KorimeLbl.Size = new Size(97, 16);
            KorimeLbl.TabIndex = 3;
            KorimeLbl.Text = "Korisničko ime:";
            // 
            // LozinkaLbl
            // 
            LozinkaLbl.AutoSize = true;
            LozinkaLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LozinkaLbl.Location = new Point(78, 200);
            LozinkaLbl.Name = "LozinkaLbl";
            LozinkaLbl.Size = new Size(56, 16);
            LozinkaLbl.TabIndex = 4;
            LozinkaLbl.Text = "Lozinka:";
            // 
            // DatumRodenjaLbl
            // 
            DatumRodenjaLbl.AutoSize = true;
            DatumRodenjaLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DatumRodenjaLbl.Location = new Point(32, 142);
            DatumRodenjaLbl.Name = "DatumRodenjaLbl";
            DatumRodenjaLbl.Size = new Size(98, 16);
            DatumRodenjaLbl.TabIndex = 5;
            DatumRodenjaLbl.Text = "Datum rođenja:";
            // 
            // DatumRodenjaDTP
            // 
            DatumRodenjaDTP.Location = new Point(142, 142);
            DatumRodenjaDTP.MaxDate = new DateTime(2999, 12, 31, 0, 0, 0, 0);
            DatumRodenjaDTP.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            DatumRodenjaDTP.Name = "DatumRodenjaDTP";
            DatumRodenjaDTP.Size = new Size(158, 21);
            DatumRodenjaDTP.TabIndex = 6;
            DatumRodenjaDTP.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            DatumRodenjaDTP.ValueChanged += DatumRodenjaDTP_ValueChanged;
            // 
            // ImeTxtb
            // 
            ImeTxtb.BackColor = SystemColors.HighlightText;
            ImeTxtb.ForeColor = SystemColors.WindowText;
            ImeTxtb.Location = new Point(142, 55);
            ImeTxtb.MaxLength = 30;
            ImeTxtb.Name = "ImeTxtb";
            ImeTxtb.PlaceholderText = "Ime";
            ImeTxtb.Size = new Size(158, 21);
            ImeTxtb.TabIndex = 7;
            ImeTxtb.TextChanged += ImeTxtb_TextChanged;
            // 
            // PrezimeTxtb
            // 
            PrezimeTxtb.BackColor = SystemColors.HighlightText;
            PrezimeTxtb.ForeColor = SystemColors.WindowText;
            PrezimeTxtb.Location = new Point(142, 84);
            PrezimeTxtb.MaxLength = 30;
            PrezimeTxtb.Name = "PrezimeTxtb";
            PrezimeTxtb.PlaceholderText = "Prezime";
            PrezimeTxtb.Size = new Size(158, 21);
            PrezimeTxtb.TabIndex = 8;
            PrezimeTxtb.TextChanged += PrezimeTxtb_TextChanged;
            // 
            // KorimeTxtb
            // 
            KorimeTxtb.BackColor = SystemColors.HighlightText;
            KorimeTxtb.ForeColor = SystemColors.WindowText;
            KorimeTxtb.Location = new Point(142, 171);
            KorimeTxtb.MaxLength = 30;
            KorimeTxtb.Name = "KorimeTxtb";
            KorimeTxtb.PlaceholderText = "korisnickoime";
            KorimeTxtb.Size = new Size(158, 21);
            KorimeTxtb.TabIndex = 9;
            KorimeTxtb.TextChanged += KorimeTxtb_TextChanged;
            // 
            // EmailTxtb
            // 
            EmailTxtb.BackColor = SystemColors.HighlightText;
            EmailTxtb.ForeColor = SystemColors.WindowText;
            EmailTxtb.Location = new Point(142, 113);
            EmailTxtb.MaxLength = 30;
            EmailTxtb.Name = "EmailTxtb";
            EmailTxtb.PlaceholderText = "e-mail";
            EmailTxtb.Size = new Size(158, 21);
            EmailTxtb.TabIndex = 10;
            EmailTxtb.TextChanged += EmailTxtb_TextChanged;
            // 
            // EmailLbl
            // 
            EmailLbl.AutoSize = true;
            EmailLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLbl.Location = new Point(86, 114);
            EmailLbl.Name = "EmailLbl";
            EmailLbl.Size = new Size(47, 16);
            EmailLbl.TabIndex = 11;
            EmailLbl.Text = "e-mail:";
            // 
            // LozinkaTxtb
            // 
            LozinkaTxtb.BackColor = SystemColors.HighlightText;
            LozinkaTxtb.ForeColor = SystemColors.WindowText;
            LozinkaTxtb.Location = new Point(142, 200);
            LozinkaTxtb.MaxLength = 30;
            LozinkaTxtb.Name = "LozinkaTxtb";
            LozinkaTxtb.PlaceholderText = "********";
            LozinkaTxtb.Size = new Size(158, 21);
            LozinkaTxtb.TabIndex = 12;
            LozinkaTxtb.UseSystemPasswordChar = true;
            LozinkaTxtb.TextChanged += LozinkaTxtb_TextChanged;
            // 
            // PonovljenLozinkaTxtb
            // 
            PonovljenLozinkaTxtb.BackColor = SystemColors.HighlightText;
            PonovljenLozinkaTxtb.ForeColor = SystemColors.WindowText;
            PonovljenLozinkaTxtb.Location = new Point(142, 229);
            PonovljenLozinkaTxtb.MaxLength = 30;
            PonovljenLozinkaTxtb.Name = "PonovljenLozinkaTxtb";
            PonovljenLozinkaTxtb.PlaceholderText = "********";
            PonovljenLozinkaTxtb.Size = new Size(158, 21);
            PonovljenLozinkaTxtb.TabIndex = 13;
            PonovljenLozinkaTxtb.UseSystemPasswordChar = true;
            PonovljenLozinkaTxtb.TextChanged += PonovljenLozinkaTxtb_TextChanged;
            // 
            // PonovljenaLozinkaLbl
            // 
            PonovljenaLozinkaLbl.AutoSize = true;
            PonovljenaLozinkaLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PonovljenaLozinkaLbl.Location = new Point(12, 230);
            PonovljenaLozinkaLbl.Name = "PonovljenaLozinkaLbl";
            PonovljenaLozinkaLbl.Size = new Size(123, 16);
            PonovljenaLozinkaLbl.TabIndex = 14;
            PonovljenaLozinkaLbl.Text = "Ponovljena lozinka:";
            // 
            // RegistracijaBtn
            // 
            RegistracijaBtn.BackColor = SystemColors.ButtonHighlight;
            RegistracijaBtn.Location = new Point(142, 258);
            RegistracijaBtn.Name = "RegistracijaBtn";
            RegistracijaBtn.Size = new Size(89, 23);
            RegistracijaBtn.TabIndex = 15;
            RegistracijaBtn.Text = "Registracija";
            RegistracijaBtn.UseVisualStyleBackColor = false;
            RegistracijaBtn.Click += RegistracijaBtn_Click;
            // 
            // GreskaLbl
            // 
            GreskaLbl.AutoSize = true;
            GreskaLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            GreskaLbl.ForeColor = Color.Red;
            GreskaLbl.Location = new Point(86, 296);
            GreskaLbl.Name = "GreskaLbl";
            GreskaLbl.Size = new Size(174, 16);
            GreskaLbl.TabIndex = 16;
            GreskaLbl.Text = "Ispravno popunite polja!";
            GreskaLbl.Visible = false;
            // 
            // RegistracijaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(366, 324);
            Controls.Add(GreskaLbl);
            Controls.Add(RegistracijaBtn);
            Controls.Add(PonovljenaLozinkaLbl);
            Controls.Add(PonovljenLozinkaTxtb);
            Controls.Add(LozinkaTxtb);
            Controls.Add(EmailLbl);
            Controls.Add(EmailTxtb);
            Controls.Add(KorimeTxtb);
            Controls.Add(PrezimeTxtb);
            Controls.Add(ImeTxtb);
            Controls.Add(DatumRodenjaDTP);
            Controls.Add(DatumRodenjaLbl);
            Controls.Add(LozinkaLbl);
            Controls.Add(KorimeLbl);
            Controls.Add(PrezimeLbl);
            Controls.Add(ImeLbl);
            Controls.Add(NaslovLbl);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegistracijaForm";
            Text = "Registracija";
            Load += RegistracijaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NaslovLbl;
        private Label ImeLbl;
        private Label PrezimeLbl;
        private Label KorimeLbl;
        private Label LozinkaLbl;
        private Label DatumRodenjaLbl;
        private DateTimePicker DatumRodenjaDTP;
        private TextBox ImeTxtb;
        private TextBox PrezimeTxtb;
        private TextBox KorimeTxtb;
        private TextBox EmailTxtb;
        private Label EmailLbl;
        private TextBox LozinkaTxtb;
        private TextBox PonovljenLozinkaTxtb;
        private Label PonovljenaLozinkaLbl;
        private Button RegistracijaBtn;
        private Label GreskaLbl;
    }
}