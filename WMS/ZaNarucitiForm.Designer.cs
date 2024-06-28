namespace WMS
{
    partial class ZaNarucitiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZaNarucitiForm));
            NaslovLbl = new Label();
            ZaNarucitiDGV = new DataGridView();
            PorukaLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)ZaNarucitiDGV).BeginInit();
            SuspendLayout();
            // 
            // NaslovLbl
            // 
            NaslovLbl.AutoSize = true;
            NaslovLbl.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            NaslovLbl.Location = new Point(355, 9);
            NaslovLbl.Name = "NaslovLbl";
            NaslovLbl.Size = new Size(282, 31);
            NaslovLbl.TabIndex = 0;
            NaslovLbl.Text = "Proizvodi za narudžbu";
            // 
            // ZaNarucitiDGV
            // 
            ZaNarucitiDGV.BackgroundColor = SystemColors.ControlDarkDark;
            ZaNarucitiDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ZaNarucitiDGV.Location = new Point(12, 60);
            ZaNarucitiDGV.Name = "ZaNarucitiDGV";
            ZaNarucitiDGV.RowTemplate.Height = 25;
            ZaNarucitiDGV.Size = new Size(932, 535);
            ZaNarucitiDGV.TabIndex = 1;
            // 
            // PorukaLbl
            // 
            PorukaLbl.AutoSize = true;
            PorukaLbl.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            PorukaLbl.ForeColor = Color.FromArgb(0, 192, 0);
            PorukaLbl.Location = new Point(12, 20);
            PorukaLbl.Name = "PorukaLbl";
            PorukaLbl.Size = new Size(332, 18);
            PorukaLbl.TabIndex = 2;
            PorukaLbl.Text = "Ne postoji proizvod koji zahtjeva narudžbu!";
            PorukaLbl.Visible = false;
            // 
            // ZaNarucitiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(956, 607);
            Controls.Add(PorukaLbl);
            Controls.Add(ZaNarucitiDGV);
            Controls.Add(NaslovLbl);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ZaNarucitiForm";
            Text = "ZaNarucitiForm";
            Load += ZaNarucitiForm_Load;
            ((System.ComponentModel.ISupportInitialize)ZaNarucitiDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NaslovLbl;
        private DataGridView ZaNarucitiDGV;
        private Label PorukaLbl;
    }
}