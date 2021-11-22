
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
            this.Liste = new System.Windows.Forms.DataGridView();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GenelNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaturaNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaturaT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisTipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.pnlTop.SuspendLayout();
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
            this.GenelNo,
            this.CariAdi,
            this.FaturaNo,
            this.FaturaT,
            this.GirisTipi,
            this.Id});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 41);
            this.Liste.MultiSelect = false;
            this.Liste.Name = "Liste";
            this.Liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Liste.Size = new System.Drawing.Size(800, 409);
            this.Liste.TabIndex = 5;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlTop.Controls.Add(this.btnKapat);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 41);
            this.pnlTop.TabIndex = 6;
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Location = new System.Drawing.Point(628, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(172, 41);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Form Çıkış";
            this.btnKapat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stok Giriş Kartı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GenelNo
            // 
            this.GenelNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GenelNo.HeaderText = "Genel No";
            this.GenelNo.Name = "GenelNo";
            this.GenelNo.Width = 77;
            // 
            // CariAdi
            // 
            this.CariAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CariAdi.HeaderText = "Cari Adi";
            this.CariAdi.Name = "CariAdi";
            // 
            // FaturaNo
            // 
            this.FaturaNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FaturaNo.HeaderText = "Fatura No";
            this.FaturaNo.Name = "FaturaNo";
            this.FaturaNo.Width = 79;
            // 
            // FaturaT
            // 
            this.FaturaT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FaturaT.HeaderText = "Fatura Tarih";
            this.FaturaT.Name = "FaturaT";
            this.FaturaT.Width = 89;
            // 
            // GirisTipi
            // 
            this.GirisTipi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GirisTipi.HeaderText = "Giriş Tipi";
            this.GirisTipi.Name = "GirisTipi";
            this.GirisTipi.Width = 72;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // frmStokGirisListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmStokGirisListe";
            this.Text = "frmStokGirisListe";
            this.Load += new System.EventHandler(this.frmStokGirisListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenelNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaturaNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaturaT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisTipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}