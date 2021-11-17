
namespace IEA_ErpProject101_Main.Depoİslemleri.Stokİslemleri
{
    partial class frmStokGirisListe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ukod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lot_SeriNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Not = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlisFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // Liste
            // 
            this.Liste.AllowDrop = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Liste.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sira,
            this.barcode,
            this.Ukod,
            this.Lot_SeriNo,
            this.GAdet,
            this.Not,
            this.UTarihi,
            this.SKT,
            this.AlisFiyat});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.MultiSelect = false;
            this.Liste.Name = "Liste";
            this.Liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Liste.Size = new System.Drawing.Size(800, 450);
            this.Liste.TabIndex = 5;
            // 
            // Sira
            // 
            this.Sira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sira.HeaderText = "Sıra";
            this.Sira.Name = "Sira";
            this.Sira.Visible = false;
            // 
            // barcode
            // 
            this.barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.barcode.HeaderText = "Barkod";
            this.barcode.Name = "barcode";
            this.barcode.Visible = false;
            // 
            // Ukod
            // 
            this.Ukod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ukod.HeaderText = "Urun Kodu";
            this.Ukod.Name = "Ukod";
            // 
            // Lot_SeriNo
            // 
            this.Lot_SeriNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Lot_SeriNo.HeaderText = "Lot / Seri No";
            this.Lot_SeriNo.Name = "Lot_SeriNo";
            this.Lot_SeriNo.Width = 93;
            // 
            // GAdet
            // 
            this.GAdet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GAdet.HeaderText = "Giriş Adet";
            this.GAdet.Name = "GAdet";
            this.GAdet.Width = 77;
            // 
            // Not
            // 
            this.Not.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Not.HeaderText = "Not";
            this.Not.Name = "Not";
            // 
            // UTarihi
            // 
            this.UTarihi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = "-";
            this.UTarihi.DefaultCellStyle = dataGridViewCellStyle2;
            this.UTarihi.HeaderText = "ÜT";
            this.UTarihi.Name = "UTarihi";
            this.UTarihi.Width = 47;
            // 
            // SKT
            // 
            this.SKT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = "-";
            this.SKT.DefaultCellStyle = dataGridViewCellStyle3;
            this.SKT.HeaderText = "SKT";
            this.SKT.Name = "SKT";
            this.SKT.Width = 53;
            // 
            // AlisFiyat
            // 
            this.AlisFiyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AlisFiyat.HeaderText = "Alış Fiyatı";
            this.AlisFiyat.Name = "AlisFiyat";
            this.AlisFiyat.Width = 75;
            // 
            // frmStokGirisListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Liste);
            this.Name = "frmStokGirisListe";
            this.Text = "frmStokListes";
            this.Load += new System.EventHandler(this.frmStokGirisListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ukod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lot_SeriNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Not;
        private System.Windows.Forms.DataGridViewTextBoxColumn UTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlisFiyat;
    }
}