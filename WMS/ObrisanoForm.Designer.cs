namespace WMS
{
    partial class ObrisanoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObrisanoForm));
            NaslovLbl = new Label();
            VratiProizvodBtn = new Button();
            ObrisaniProizvodiDGV = new DataGridView();
            ProizvodiLbl = new Label();
            ObrisaneKategorijeDGV = new DataGridView();
            KategorijeLbl = new Label();
            VratiKategorijuBtn = new Button();
            PotvrdaLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)ObrisaniProizvodiDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ObrisaneKategorijeDGV).BeginInit();
            SuspendLayout();
            // 
            // NaslovLbl
            // 
            NaslovLbl.AutoSize = true;
            NaslovLbl.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            NaslovLbl.Location = new Point(402, 9);
            NaslovLbl.Name = "NaslovLbl";
            NaslovLbl.Size = new Size(211, 31);
            NaslovLbl.TabIndex = 0;
            NaslovLbl.Text = "Obrisane stavke";
            // 
            // VratiProizvodBtn
            // 
            VratiProizvodBtn.BackColor = SystemColors.ButtonHighlight;
            VratiProizvodBtn.Location = new Point(856, 30);
            VratiProizvodBtn.Name = "VratiProizvodBtn";
            VratiProizvodBtn.Size = new Size(116, 28);
            VratiProizvodBtn.TabIndex = 1;
            VratiProizvodBtn.Text = "Vrati stavku";
            VratiProizvodBtn.UseVisualStyleBackColor = false;
            VratiProizvodBtn.Click += VratiProizvodBtn_Click;
            // 
            // ObrisaniProizvodiDGV
            // 
            ObrisaniProizvodiDGV.BackgroundColor = SystemColors.ControlDarkDark;
            ObrisaniProizvodiDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ObrisaniProizvodiDGV.Location = new Point(12, 61);
            ObrisaniProizvodiDGV.Name = "ObrisaniProizvodiDGV";
            ObrisaniProizvodiDGV.RowTemplate.Height = 25;
            ObrisaniProizvodiDGV.Size = new Size(960, 318);
            ObrisaniProizvodiDGV.TabIndex = 2;
            ObrisaniProizvodiDGV.SelectionChanged += ObrisaniProizvodiDGV_SelectionChanged;
            // 
            // ProizvodiLbl
            // 
            ProizvodiLbl.AutoSize = true;
            ProizvodiLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProizvodiLbl.Location = new Point(12, 37);
            ProizvodiLbl.Name = "ProizvodiLbl";
            ProizvodiLbl.Size = new Size(76, 20);
            ProizvodiLbl.TabIndex = 4;
            ProizvodiLbl.Text = "Proizvodi:";
            // 
            // ObrisaneKategorijeDGV
            // 
            ObrisaneKategorijeDGV.BackgroundColor = SystemColors.ControlDarkDark;
            ObrisaneKategorijeDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ObrisaneKategorijeDGV.Location = new Point(12, 414);
            ObrisaneKategorijeDGV.Name = "ObrisaneKategorijeDGV";
            ObrisaneKategorijeDGV.RowTemplate.Height = 25;
            ObrisaneKategorijeDGV.Size = new Size(960, 135);
            ObrisaneKategorijeDGV.TabIndex = 3;
            ObrisaneKategorijeDGV.SelectionChanged += ObrisaneKategorijeDGV_SelectionChanged;
            // 
            // KategorijeLbl
            // 
            KategorijeLbl.AutoSize = true;
            KategorijeLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            KategorijeLbl.Location = new Point(12, 382);
            KategorijeLbl.Name = "KategorijeLbl";
            KategorijeLbl.Size = new Size(84, 20);
            KategorijeLbl.TabIndex = 5;
            KategorijeLbl.Text = "Kategorije:";
            // 
            // VratiKategorijuBtn
            // 
            VratiKategorijuBtn.BackColor = SystemColors.ButtonHighlight;
            VratiKategorijuBtn.Location = new Point(856, 382);
            VratiKategorijuBtn.Name = "VratiKategorijuBtn";
            VratiKategorijuBtn.Size = new Size(116, 28);
            VratiKategorijuBtn.TabIndex = 6;
            VratiKategorijuBtn.Text = "Vrati stavku";
            VratiKategorijuBtn.UseVisualStyleBackColor = false;
            VratiKategorijuBtn.Click += VratiKategorijuBtn_Click;
            // 
            // PotvrdaLbl
            // 
            PotvrdaLbl.AutoSize = true;
            PotvrdaLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            PotvrdaLbl.ForeColor = Color.FromArgb(0, 192, 0);
            PotvrdaLbl.Location = new Point(471, 389);
            PotvrdaLbl.Name = "PotvrdaLbl";
            PotvrdaLbl.Size = new Size(119, 16);
            PotvrdaLbl.TabIndex = 7;
            PotvrdaLbl.Text = "Stavka vraćena!";
            // 
            // ObrisanoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(984, 561);
            Controls.Add(PotvrdaLbl);
            Controls.Add(VratiKategorijuBtn);
            Controls.Add(KategorijeLbl);
            Controls.Add(ProizvodiLbl);
            Controls.Add(ObrisaneKategorijeDGV);
            Controls.Add(ObrisaniProizvodiDGV);
            Controls.Add(VratiProizvodBtn);
            Controls.Add(NaslovLbl);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ObrisanoForm";
            Text = "ObrisanoForm";
            Load += ObrisanoForm_Load;
            ((System.ComponentModel.ISupportInitialize)ObrisaniProizvodiDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)ObrisaneKategorijeDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NaslovLbl;
        private Button VratiProizvodBtn;
        private DataGridView ObrisaniProizvodiDGV;
        private Label ProizvodiLbl;
        private DataGridView ObrisaneKategorijeDGV;
        private Label KategorijeLbl;
        private Button VratiKategorijuBtn;
        private Label PotvrdaLbl;
    }
}