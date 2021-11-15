
namespace IEA_ErpProject101_Main.Urunİslemleri
{
    partial class frmUrunGiris
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
            this.Liste = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUrunKodu = new System.Windows.Forms.Label();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.txtUrunTedarikciId = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrunAciklama = new System.Windows.Forms.TextBox();
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.pnlOrta = new System.Windows.Forms.Panel();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnFormCikis = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.txtKayitBul = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKutu = new System.Windows.Forms.TextBox();
            this.txtAlis = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSatis = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenelNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.pnlUst.SuspendLayout();
            this.pnlOrta.SuspendLayout();
            this.SuspendLayout();
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.sira,
            this.GenelNo,
            this.UrunKodu,
            this.UrunAdı});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Liste.Location = new System.Drawing.Point(0, 317);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(887, 118);
            this.Liste.TabIndex = 24;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Maroon;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 307);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(887, 10);
            this.splitter1.TabIndex = 26;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(10, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Genel No :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(12, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tedarikçi :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUrunKodu
            // 
            this.lblUrunKodu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUrunKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunKodu.Location = new System.Drawing.Point(298, 14);
            this.lblUrunKodu.Name = "lblUrunKodu";
            this.lblUrunKodu.Size = new System.Drawing.Size(223, 28);
            this.lblUrunKodu.TabIndex = 1;
            this.lblUrunKodu.Text = "***";
            this.lblUrunKodu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlUst.Controls.Add(this.lblUrunKodu);
            this.pnlUst.Controls.Add(this.btnTemizle);
            this.pnlUst.Controls.Add(this.btnSil);
            this.pnlUst.Controls.Add(this.btnGuncelle);
            this.pnlUst.Controls.Add(this.btnKayit);
            this.pnlUst.Controls.Add(this.btnFormCikis);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(887, 56);
            this.pnlUst.TabIndex = 23;
            // 
            // txtUrunTedarikciId
            // 
            this.txtUrunTedarikciId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtUrunTedarikciId.FormattingEnabled = true;
            this.txtUrunTedarikciId.Location = new System.Drawing.Point(103, 71);
            this.txtUrunTedarikciId.Name = "txtUrunTedarikciId";
            this.txtUrunTedarikciId.Size = new System.Drawing.Size(211, 21);
            this.txtUrunTedarikciId.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(503, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ürün Açıklama :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUrunAciklama
            // 
            this.txtUrunAciklama.Location = new System.Drawing.Point(593, 44);
            this.txtUrunAciklama.Multiline = true;
            this.txtUrunAciklama.Name = "txtUrunAciklama";
            this.txtUrunAciklama.Size = new System.Drawing.Size(273, 38);
            this.txtUrunAciklama.TabIndex = 4;
            // 
            // pnlAlt
            // 
            this.pnlAlt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.Location = new System.Drawing.Point(0, 435);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(887, 10);
            this.pnlAlt.TabIndex = 25;
            // 
            // pnlOrta
            // 
            this.pnlOrta.AutoScroll = true;
            this.pnlOrta.Controls.Add(this.label7);
            this.pnlOrta.Controls.Add(this.txtKutu);
            this.pnlOrta.Controls.Add(this.label18);
            this.pnlOrta.Controls.Add(this.label5);
            this.pnlOrta.Controls.Add(this.txtSatis);
            this.pnlOrta.Controls.Add(this.txtUrunAdi);
            this.pnlOrta.Controls.Add(this.label14);
            this.pnlOrta.Controls.Add(this.label3);
            this.pnlOrta.Controls.Add(this.txtAlis);
            this.pnlOrta.Controls.Add(this.txtKayitBul);
            this.pnlOrta.Controls.Add(this.txtUrunKodu);
            this.pnlOrta.Controls.Add(this.label1);
            this.pnlOrta.Controls.Add(this.label6);
            this.pnlOrta.Controls.Add(this.txtUrunTedarikciId);
            this.pnlOrta.Controls.Add(this.label4);
            this.pnlOrta.Controls.Add(this.txtUrunAciklama);
            this.pnlOrta.Location = new System.Drawing.Point(0, 52);
            this.pnlOrta.Name = "pnlOrta";
            this.pnlOrta.Size = new System.Drawing.Size(887, 393);
            this.pnlOrta.TabIndex = 27;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImage = global::IEA_ErpProject101_Main.Properties.Resources.Sil64;
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.Location = new System.Drawing.Point(144, 9);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(38, 37);
            this.btnTemizle.TabIndex = 0;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = global::IEA_ErpProject101_Main.Properties.Resources.Sil24x24;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Location = new System.Drawing.Point(100, 9);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(38, 37);
            this.btnSil.TabIndex = 0;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = global::IEA_ErpProject101_Main.Properties.Resources.Update32x32;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Location = new System.Drawing.Point(56, 9);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(38, 37);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.BackgroundImage = global::IEA_ErpProject101_Main.Properties.Resources.Save_icon32x32;
            this.btnKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKayit.Location = new System.Drawing.Point(12, 9);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(38, 37);
            this.btnKayit.TabIndex = 0;
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // btnFormCikis
            // 
            this.btnFormCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFormCikis.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFormCikis.BackgroundImage = global::IEA_ErpProject101_Main.Properties.Resources.exit_48;
            this.btnFormCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFormCikis.Location = new System.Drawing.Point(842, 12);
            this.btnFormCikis.Name = "btnFormCikis";
            this.btnFormCikis.Size = new System.Drawing.Size(33, 30);
            this.btnFormCikis.TabIndex = 0;
            this.btnFormCikis.UseVisualStyleBackColor = false;
            this.btnFormCikis.Click += new System.EventHandler(this.btnFormCikis_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 53;
            this.label3.Text = "Ürün Kodu :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Location = new System.Drawing.Point(102, 98);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(211, 20);
            this.txtUrunKodu.TabIndex = 52;
            // 
            // txtKayitBul
            // 
            this.txtKayitBul.Location = new System.Drawing.Point(103, 46);
            this.txtKayitBul.Name = "txtKayitBul";
            this.txtKayitBul.Size = new System.Drawing.Size(211, 20);
            this.txtKayitBul.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(12, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 55;
            this.label5.Text = "Ürün Adı:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(102, 124);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(211, 20);
            this.txtUrunAdi.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(503, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 38);
            this.label7.TabIndex = 56;
            this.label7.Text = "Kutu İçerik :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtKutu
            // 
            this.txtKutu.Location = new System.Drawing.Point(593, 88);
            this.txtKutu.Multiline = true;
            this.txtKutu.Name = "txtKutu";
            this.txtKutu.Size = new System.Drawing.Size(273, 38);
            this.txtKutu.TabIndex = 57;
            // 
            // txtAlis
            // 
            this.txtAlis.Location = new System.Drawing.Point(102, 149);
            this.txtAlis.Name = "txtAlis";
            this.txtAlis.Size = new System.Drawing.Size(154, 20);
            this.txtAlis.TabIndex = 52;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label14.Location = new System.Drawing.Point(12, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 23);
            this.label14.TabIndex = 53;
            this.label14.Text = "Alış Fiyatı :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSatis
            // 
            this.txtSatis.Location = new System.Drawing.Point(102, 175);
            this.txtSatis.Name = "txtSatis";
            this.txtSatis.Size = new System.Drawing.Size(154, 20);
            this.txtSatis.TabIndex = 54;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label18.Location = new System.Drawing.Point(12, 173);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 23);
            this.label18.TabIndex = 55;
            this.label18.Text = "Satış Fiyatı :";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // sira
            // 
            this.sira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sira.HeaderText = "Sıra";
            this.sira.Name = "sira";
            this.sira.Width = 50;
            // 
            // GenelNo
            // 
            this.GenelNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GenelNo.HeaderText = "Genel No";
            this.GenelNo.Name = "GenelNo";
            this.GenelNo.Width = 77;
            // 
            // UrunKodu
            // 
            this.UrunKodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UrunKodu.HeaderText = "Urun Kodu";
            this.UrunKodu.Name = "UrunKodu";
            // 
            // UrunAdı
            // 
            this.UrunAdı.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UrunAdı.HeaderText = "Urun Adi";
            this.UrunAdı.Name = "UrunAdı";
            // 
            // frmUrunGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 445);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlUst);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.pnlOrta);
            this.Controls.Add(this.pnlAlt);
            this.Name = "frmUrunGiris";
            this.Text = "frmUrunGiris";
            this.Load += new System.EventHandler(this.frmUrunGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.pnlUst.ResumeLayout(false);
            this.pnlOrta.ResumeLayout(false);
            this.pnlOrta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUrunKodu;
        private System.Windows.Forms.Button btnFormCikis;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ComboBox txtUrunTedarikciId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUrunAciklama;
        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.Panel pnlOrta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKayitBul;
        private System.Windows.Forms.TextBox txtUrunKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenelNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdı;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKutu;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSatis;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAlis;
    }
}