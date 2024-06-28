namespace WMS
{
    partial class PrijavaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrijavaForm));
            NaslovLbl = new Label();
            KorimeLbl = new Label();
            KorimeTxtb = new TextBox();
            LozinkaLbl = new Label();
            LozinkaTxtb = new TextBox();
            PrijavaBtn = new Button();
            GreskaLbl = new Label();
            SuspendLayout();
            // 
            // NaslovLbl
            // 
            NaslovLbl.AutoSize = true;
            NaslovLbl.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            NaslovLbl.Location = new Point(147, 9);
            NaslovLbl.Name = "NaslovLbl";
            NaslovLbl.Size = new Size(147, 31);
            NaslovLbl.TabIndex = 0;
            NaslovLbl.Text = "Prijavite se";
            // 
            // KorimeLbl
            // 
            KorimeLbl.AutoSize = true;
            KorimeLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            KorimeLbl.Location = new Point(33, 61);
            KorimeLbl.Name = "KorimeLbl";
            KorimeLbl.Size = new Size(114, 20);
            KorimeLbl.TabIndex = 1;
            KorimeLbl.Text = "Korisničko ime:";
            // 
            // KorimeTxtb
            // 
            KorimeTxtb.BackColor = SystemColors.HighlightText;
            KorimeTxtb.Location = new Point(147, 61);
            KorimeTxtb.Name = "KorimeTxtb";
            KorimeTxtb.PlaceholderText = "korisnicko ime";
            KorimeTxtb.Size = new Size(205, 21);
            KorimeTxtb.TabIndex = 2;
            KorimeTxtb.TextChanged += KorimeTxtb_TextChanged;
            // 
            // LozinkaLbl
            // 
            LozinkaLbl.AutoSize = true;
            LozinkaLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LozinkaLbl.Location = new Point(82, 100);
            LozinkaLbl.Name = "LozinkaLbl";
            LozinkaLbl.Size = new Size(68, 20);
            LozinkaLbl.TabIndex = 3;
            LozinkaLbl.Text = "Lozinka:";
            // 
            // LozinkaTxtb
            // 
            LozinkaTxtb.BackColor = SystemColors.HighlightText;
            LozinkaTxtb.Location = new Point(147, 102);
            LozinkaTxtb.Name = "LozinkaTxtb";
            LozinkaTxtb.PlaceholderText = "lozinka";
            LozinkaTxtb.Size = new Size(205, 21);
            LozinkaTxtb.TabIndex = 4;
            LozinkaTxtb.UseSystemPasswordChar = true;
            LozinkaTxtb.TextChanged += LozinkaTxtb_TextChanged;
            // 
            // PrijavaBtn
            // 
            PrijavaBtn.BackColor = SystemColors.ButtonHighlight;
            PrijavaBtn.Location = new Point(147, 146);
            PrijavaBtn.Name = "PrijavaBtn";
            PrijavaBtn.Size = new Size(112, 23);
            PrijavaBtn.TabIndex = 5;
            PrijavaBtn.Text = "Prijavi se";
            PrijavaBtn.UseVisualStyleBackColor = false;
            PrijavaBtn.Click += PrijavaBtn_Click;
            // 
            // GreskaLbl
            // 
            GreskaLbl.AutoSize = true;
            GreskaLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            GreskaLbl.ForeColor = Color.Red;
            GreskaLbl.Location = new Point(54, 182);
            GreskaLbl.Name = "GreskaLbl";
            GreskaLbl.Size = new Size(333, 16);
            GreskaLbl.TabIndex = 6;
            GreskaLbl.Text = "Unijeli ste neispravno korisničko ime ili lozinku!";
            GreskaLbl.Visible = false;
            // 
            // PrijavaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(423, 221);
            Controls.Add(GreskaLbl);
            Controls.Add(PrijavaBtn);
            Controls.Add(LozinkaTxtb);
            Controls.Add(LozinkaLbl);
            Controls.Add(KorimeTxtb);
            Controls.Add(KorimeLbl);
            Controls.Add(NaslovLbl);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PrijavaForm";
            Text = "Prijava";
            Load += PrijavaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NaslovLbl;
        private Label KorimeLbl;
        private TextBox KorimeTxtb;
        private Label LozinkaLbl;
        private TextBox LozinkaTxtb;
        private Button PrijavaBtn;
        private Label GreskaLbl;
    }
}