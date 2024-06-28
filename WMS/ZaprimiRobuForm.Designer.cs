namespace WMS
{
    partial class ZaprimiRobuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZaprimiRobuForm));
            NaslovLbl = new Label();
            ProizvodLbl = new Label();
            ProizvodiCmb = new ComboBox();
            KolicinaLbl = new Label();
            KolicinaTxtb = new TextBox();
            ZaprimiBtn = new Button();
            PovijestLb = new ListBox();
            SuspendLayout();
            // 
            // NaslovLbl
            // 
            NaslovLbl.AutoSize = true;
            NaslovLbl.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            NaslovLbl.Location = new Point(197, 9);
            NaslovLbl.Name = "NaslovLbl";
            NaslovLbl.Size = new Size(165, 31);
            NaslovLbl.TabIndex = 0;
            NaslovLbl.Text = "Zaprimi robu";
            // 
            // ProizvodLbl
            // 
            ProizvodLbl.AutoSize = true;
            ProizvodLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ProizvodLbl.Location = new Point(40, 66);
            ProizvodLbl.Name = "ProizvodLbl";
            ProizvodLbl.Size = new Size(63, 16);
            ProizvodLbl.TabIndex = 1;
            ProizvodLbl.Text = "Proizvod:";
            // 
            // ProizvodiCmb
            // 
            ProizvodiCmb.BackColor = SystemColors.GradientInactiveCaption;
            ProizvodiCmb.FormattingEnabled = true;
            ProizvodiCmb.Location = new Point(111, 65);
            ProizvodiCmb.Name = "ProizvodiCmb";
            ProizvodiCmb.Size = new Size(192, 23);
            ProizvodiCmb.TabIndex = 2;
            ProizvodiCmb.SelectedIndexChanged += ProizvodiCmb_SelectedIndexChanged;
            // 
            // KolicinaLbl
            // 
            KolicinaLbl.AutoSize = true;
            KolicinaLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            KolicinaLbl.Location = new Point(47, 95);
            KolicinaLbl.Name = "KolicinaLbl";
            KolicinaLbl.Size = new Size(57, 16);
            KolicinaLbl.TabIndex = 3;
            KolicinaLbl.Text = "Količina:";
            // 
            // KolicinaTxtb
            // 
            KolicinaTxtb.BackColor = SystemColors.HighlightText;
            KolicinaTxtb.Location = new Point(111, 94);
            KolicinaTxtb.Name = "KolicinaTxtb";
            KolicinaTxtb.Size = new Size(192, 21);
            KolicinaTxtb.TabIndex = 4;
            KolicinaTxtb.TextChanged += KolicinaTxtb_TextChanged;
            KolicinaTxtb.Enter += KolicinaTxtb_Enter;
            KolicinaTxtb.Leave += KolicinaTxtb_Leave;
            // 
            // ZaprimiBtn
            // 
            ZaprimiBtn.BackColor = SystemColors.ButtonHighlight;
            ZaprimiBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ZaprimiBtn.Location = new Point(325, 65);
            ZaprimiBtn.Name = "ZaprimiBtn";
            ZaprimiBtn.Size = new Size(120, 37);
            ZaprimiBtn.TabIndex = 6;
            ZaprimiBtn.Text = "Zaprimi";
            ZaprimiBtn.UseVisualStyleBackColor = false;
            ZaprimiBtn.Click += ZaprimiBtn_Click;
            // 
            // PovijestLb
            // 
            PovijestLb.BackColor = SystemColors.InactiveBorder;
            PovijestLb.ColumnWidth = 250;
            PovijestLb.FormattingEnabled = true;
            PovijestLb.HorizontalScrollbar = true;
            PovijestLb.ItemHeight = 15;
            PovijestLb.Location = new Point(25, 140);
            PovijestLb.MultiColumn = true;
            PovijestLb.Name = "PovijestLb";
            PovijestLb.SelectionMode = SelectionMode.None;
            PovijestLb.Size = new Size(539, 229);
            PovijestLb.TabIndex = 7;
            // 
            // ZaprimiRobuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(595, 387);
            Controls.Add(PovijestLb);
            Controls.Add(ZaprimiBtn);
            Controls.Add(KolicinaTxtb);
            Controls.Add(KolicinaLbl);
            Controls.Add(ProizvodiCmb);
            Controls.Add(ProizvodLbl);
            Controls.Add(NaslovLbl);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ZaprimiRobuForm";
            Text = "ZaprimiRobuForm";
            Load += ZaprimiRobuForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NaslovLbl;
        private Label ProizvodLbl;
        private ComboBox ProizvodiCmb;
        private Label KolicinaLbl;
        private TextBox KolicinaTxtb;
        private Button ZaprimiBtn;
        private ListBox PovijestLb;
    }
}