
namespace IEA_ErpProject101_Main.BilgiGirisİslemleri.Hastaneler
{
    partial class frmHastaneGiris
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
            this.pnlUst = new System.Windows.Forms.Panel();
            this.lblHastaneKodu = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnFormCikis = new System.Windows.Forms.Button();
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YetkiliAdi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtHastaneAdi = new System.Windows.Forms.TextBox();
            this.txtHastaneCari = new System.Windows.Forms.TextBox();
            this.txtAdres1 = new System.Windows.Forms.TextBox();
            this.txtAdres2 = new System.Windows.Forms.TextBox();
            this.txtYet1 = new System.Windows.Forms.TextBox();
            this.txtYet2 = new System.Windows.Forms.TextBox();
            this.txtYet3 = new System.Windows.Forms.TextBox();
            this.txtMail1 = new System.Windows.Forms.TextBox();
            this.txtMail2 = new System.Windows.Forms.TextBox();
            this.txtMail3 = new System.Windows.Forms.TextBox();
            this.txtVergiDairesi = new System.Windows.Forms.TextBox();
            this.txtDepartman1 = new System.Windows.Forms.ComboBox();
            this.txtDepartman2 = new System.Windows.Forms.ComboBox();
            this.txtDepartman3 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtHastaneMail = new System.Windows.Forms.TextBox();
            this.txtSehir = new System.Windows.Forms.ComboBox();
            this.txtYtel1 = new System.Windows.Forms.MaskedTextBox();
            this.txtYtel2 = new System.Windows.Forms.MaskedTextBox();
            this.txtYtel3 = new System.Windows.Forms.MaskedTextBox();
            this.txtYCep1 = new System.Windows.Forms.MaskedTextBox();
            this.txtYCep2 = new System.Windows.Forms.MaskedTextBox();
            this.txtYCep3 = new System.Windows.Forms.MaskedTextBox();
            this.txtVnTc = new System.Windows.Forms.MaskedTextBox();
            this.txtHastaneTel = new System.Windows.Forms.MaskedTextBox();
            this.pnlOrta = new System.Windows.Forms.Panel();
            this.txtCariTip = new System.Windows.Forms.ComboBox();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.pnlOrta.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlUst.Controls.Add(this.lblHastaneKodu);
            this.pnlUst.Controls.Add(this.btnTemizle);
            this.pnlUst.Controls.Add(this.btnSil);
            this.pnlUst.Controls.Add(this.btnGuncelle);
            this.pnlUst.Controls.Add(this.btnKayit);
            this.pnlUst.Controls.Add(this.btnFormCikis);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1014, 56);
            this.pnlUst.TabIndex = 0;
            // 
            // lblHastaneKodu
            // 
            this.lblHastaneKodu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHastaneKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaneKodu.Location = new System.Drawing.Point(427, 14);
            this.lblHastaneKodu.Name = "lblHastaneKodu";
            this.lblHastaneKodu.Size = new System.Drawing.Size(223, 28);
            this.lblHastaneKodu.TabIndex = 1;
            this.lblHastaneKodu.Text = "***";
            this.lblHastaneKodu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnFormCikis.Location = new System.Drawing.Point(969, 12);
            this.btnFormCikis.Name = "btnFormCikis";
            this.btnFormCikis.Size = new System.Drawing.Size(33, 30);
            this.btnFormCikis.TabIndex = 0;
            this.btnFormCikis.UseVisualStyleBackColor = false;
            this.btnFormCikis.Click += new System.EventHandler(this.btnFormCikis_Click);
            // 
            // pnlAlt
            // 
            this.pnlAlt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.Location = new System.Drawing.Point(0, 435);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(1014, 10);
            this.pnlAlt.TabIndex = 1;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.sira,
            this.CariKodu,
            this.CariAdi,
            this.CariTel,
            this.CariMail,
            this.YetkiliAdi1});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Liste.Location = new System.Drawing.Point(0, 302);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(1014, 133);
            this.Liste.TabIndex = 1;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
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
            // CariKodu
            // 
            this.CariKodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariKodu.HeaderText = "Hastane Kodu";
            this.CariKodu.Name = "CariKodu";
            // 
            // CariAdi
            // 
            this.CariAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CariAdi.HeaderText = "Hastane Adı";
            this.CariAdi.Name = "CariAdi";
            // 
            // CariTel
            // 
            this.CariTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariTel.HeaderText = "Hastane Tel";
            this.CariTel.Name = "CariTel";
            this.CariTel.Width = 90;
            // 
            // CariMail
            // 
            this.CariMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariMail.HeaderText = "Hastane Mail";
            this.CariMail.Name = "CariMail";
            this.CariMail.Width = 94;
            // 
            // YetkiliAdi1
            // 
            this.YetkiliAdi1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.YetkiliAdi1.HeaderText = "Yetkili Kişi";
            this.YetkiliAdi1.Name = "YetkiliAdi1";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Maroon;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 292);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1014, 10);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hastane Adı :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hastane Cari :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(9, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adres 1 :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(9, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Adres 2 :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(577, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cari Tipi :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(349, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Yetkili";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(455, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "Departman";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(794, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "E-Mail";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(577, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 3;
            this.label10.Text = "Telefon";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Location = new System.Drawing.Point(346, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 3;
            this.label11.Text = "Vergi Dairesi :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Location = new System.Drawing.Point(577, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 3;
            this.label12.Text = "Vergi No";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label13.Location = new System.Drawing.Point(346, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 3;
            this.label13.Text = "Sehir";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label14.Location = new System.Drawing.Point(688, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 3;
            this.label14.Text = "Cep";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHastaneAdi
            // 
            this.txtHastaneAdi.Location = new System.Drawing.Point(103, 18);
            this.txtHastaneAdi.Name = "txtHastaneAdi";
            this.txtHastaneAdi.Size = new System.Drawing.Size(100, 20);
            this.txtHastaneAdi.TabIndex = 0;
            // 
            // txtHastaneCari
            // 
            this.txtHastaneCari.Location = new System.Drawing.Point(103, 46);
            this.txtHastaneCari.Name = "txtHastaneCari";
            this.txtHastaneCari.Size = new System.Drawing.Size(100, 20);
            this.txtHastaneCari.TabIndex = 1;
            // 
            // txtAdres1
            // 
            this.txtAdres1.Location = new System.Drawing.Point(100, 123);
            this.txtAdres1.Multiline = true;
            this.txtAdres1.Name = "txtAdres1";
            this.txtAdres1.Size = new System.Drawing.Size(193, 42);
            this.txtAdres1.TabIndex = 4;
            // 
            // txtAdres2
            // 
            this.txtAdres2.Location = new System.Drawing.Point(100, 172);
            this.txtAdres2.Multiline = true;
            this.txtAdres2.Name = "txtAdres2";
            this.txtAdres2.Size = new System.Drawing.Size(193, 33);
            this.txtAdres2.TabIndex = 5;
            // 
            // txtYet1
            // 
            this.txtYet1.Location = new System.Drawing.Point(349, 42);
            this.txtYet1.Name = "txtYet1";
            this.txtYet1.Size = new System.Drawing.Size(100, 20);
            this.txtYet1.TabIndex = 6;
            // 
            // txtYet2
            // 
            this.txtYet2.Location = new System.Drawing.Point(349, 68);
            this.txtYet2.Name = "txtYet2";
            this.txtYet2.Size = new System.Drawing.Size(100, 20);
            this.txtYet2.TabIndex = 11;
            // 
            // txtYet3
            // 
            this.txtYet3.Location = new System.Drawing.Point(349, 94);
            this.txtYet3.Name = "txtYet3";
            this.txtYet3.Size = new System.Drawing.Size(100, 20);
            this.txtYet3.TabIndex = 16;
            // 
            // txtMail1
            // 
            this.txtMail1.Location = new System.Drawing.Point(794, 41);
            this.txtMail1.Name = "txtMail1";
            this.txtMail1.Size = new System.Drawing.Size(123, 20);
            this.txtMail1.TabIndex = 10;
            // 
            // txtMail2
            // 
            this.txtMail2.Location = new System.Drawing.Point(794, 67);
            this.txtMail2.Name = "txtMail2";
            this.txtMail2.Size = new System.Drawing.Size(123, 20);
            this.txtMail2.TabIndex = 15;
            // 
            // txtMail3
            // 
            this.txtMail3.Location = new System.Drawing.Point(794, 93);
            this.txtMail3.Name = "txtMail3";
            this.txtMail3.Size = new System.Drawing.Size(123, 20);
            this.txtMail3.TabIndex = 20;
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(452, 163);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(100, 20);
            this.txtVergiDairesi.TabIndex = 23;
            // 
            // txtDepartman1
            // 
            this.txtDepartman1.FormattingEnabled = true;
            this.txtDepartman1.Location = new System.Drawing.Point(454, 42);
            this.txtDepartman1.Name = "txtDepartman1";
            this.txtDepartman1.Size = new System.Drawing.Size(117, 21);
            this.txtDepartman1.TabIndex = 7;
            // 
            // txtDepartman2
            // 
            this.txtDepartman2.FormattingEnabled = true;
            this.txtDepartman2.Location = new System.Drawing.Point(455, 67);
            this.txtDepartman2.Name = "txtDepartman2";
            this.txtDepartman2.Size = new System.Drawing.Size(116, 21);
            this.txtDepartman2.TabIndex = 12;
            // 
            // txtDepartman3
            // 
            this.txtDepartman3.FormattingEnabled = true;
            this.txtDepartman3.Location = new System.Drawing.Point(455, 93);
            this.txtDepartman3.Name = "txtDepartman3";
            this.txtDepartman3.Size = new System.Drawing.Size(116, 21);
            this.txtDepartman3.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label15.Location = new System.Drawing.Point(12, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 23);
            this.label15.TabIndex = 3;
            this.label15.Text = "Hastane Tel :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label16.Location = new System.Drawing.Point(12, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 23);
            this.label16.TabIndex = 3;
            this.label16.Text = "Hastane Mail :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHastaneMail
            // 
            this.txtHastaneMail.Location = new System.Drawing.Point(100, 94);
            this.txtHastaneMail.Name = "txtHastaneMail";
            this.txtHastaneMail.Size = new System.Drawing.Size(155, 20);
            this.txtHastaneMail.TabIndex = 3;
            // 
            // txtSehir
            // 
            this.txtSehir.FormattingEnabled = true;
            this.txtSehir.Location = new System.Drawing.Point(452, 133);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(100, 21);
            this.txtSehir.TabIndex = 21;
            // 
            // txtYtel1
            // 
            this.txtYtel1.Location = new System.Drawing.Point(577, 41);
            this.txtYtel1.Mask = "(999) 000-0000";
            this.txtYtel1.Name = "txtYtel1";
            this.txtYtel1.Size = new System.Drawing.Size(100, 20);
            this.txtYtel1.TabIndex = 8;
            // 
            // txtYtel2
            // 
            this.txtYtel2.Location = new System.Drawing.Point(577, 67);
            this.txtYtel2.Mask = "(999) 000-0000";
            this.txtYtel2.Name = "txtYtel2";
            this.txtYtel2.Size = new System.Drawing.Size(100, 20);
            this.txtYtel2.TabIndex = 13;
            // 
            // txtYtel3
            // 
            this.txtYtel3.Location = new System.Drawing.Point(577, 93);
            this.txtYtel3.Mask = "(999) 000-0000";
            this.txtYtel3.Name = "txtYtel3";
            this.txtYtel3.Size = new System.Drawing.Size(100, 20);
            this.txtYtel3.TabIndex = 18;
            // 
            // txtYCep1
            // 
            this.txtYCep1.Location = new System.Drawing.Point(688, 41);
            this.txtYCep1.Mask = "(999) 000-0000";
            this.txtYCep1.Name = "txtYCep1";
            this.txtYCep1.Size = new System.Drawing.Size(100, 20);
            this.txtYCep1.TabIndex = 9;
            // 
            // txtYCep2
            // 
            this.txtYCep2.Location = new System.Drawing.Point(688, 67);
            this.txtYCep2.Mask = "(999) 000-0000";
            this.txtYCep2.Name = "txtYCep2";
            this.txtYCep2.Size = new System.Drawing.Size(100, 20);
            this.txtYCep2.TabIndex = 14;
            // 
            // txtYCep3
            // 
            this.txtYCep3.Location = new System.Drawing.Point(688, 93);
            this.txtYCep3.Mask = "(999) 000-0000";
            this.txtYCep3.Name = "txtYCep3";
            this.txtYCep3.Size = new System.Drawing.Size(100, 20);
            this.txtYCep3.TabIndex = 19;
            // 
            // txtVnTc
            // 
            this.txtVnTc.Location = new System.Drawing.Point(683, 163);
            this.txtVnTc.Mask = "00000000000";
            this.txtVnTc.Name = "txtVnTc";
            this.txtVnTc.Size = new System.Drawing.Size(100, 20);
            this.txtVnTc.TabIndex = 24;
            // 
            // txtHastaneTel
            // 
            this.txtHastaneTel.Location = new System.Drawing.Point(103, 68);
            this.txtHastaneTel.Mask = "(999) 000-0000";
            this.txtHastaneTel.Name = "txtHastaneTel";
            this.txtHastaneTel.Size = new System.Drawing.Size(100, 20);
            this.txtHastaneTel.TabIndex = 2;
            // 
            // pnlOrta
            // 
            this.pnlOrta.AutoScroll = true;
            this.pnlOrta.Controls.Add(this.label1);
            this.pnlOrta.Controls.Add(this.txtYCep3);
            this.pnlOrta.Controls.Add(this.txtYtel3);
            this.pnlOrta.Controls.Add(this.label6);
            this.pnlOrta.Controls.Add(this.txtYCep2);
            this.pnlOrta.Controls.Add(this.label11);
            this.pnlOrta.Controls.Add(this.txtYtel2);
            this.pnlOrta.Controls.Add(this.label7);
            this.pnlOrta.Controls.Add(this.txtYCep1);
            this.pnlOrta.Controls.Add(this.label12);
            this.pnlOrta.Controls.Add(this.txtVnTc);
            this.pnlOrta.Controls.Add(this.label3);
            this.pnlOrta.Controls.Add(this.txtHastaneTel);
            this.pnlOrta.Controls.Add(this.label8);
            this.pnlOrta.Controls.Add(this.txtYtel1);
            this.pnlOrta.Controls.Add(this.label13);
            this.pnlOrta.Controls.Add(this.txtCariTip);
            this.pnlOrta.Controls.Add(this.txtSehir);
            this.pnlOrta.Controls.Add(this.label4);
            this.pnlOrta.Controls.Add(this.txtDepartman3);
            this.pnlOrta.Controls.Add(this.label15);
            this.pnlOrta.Controls.Add(this.txtDepartman2);
            this.pnlOrta.Controls.Add(this.label9);
            this.pnlOrta.Controls.Add(this.txtDepartman1);
            this.pnlOrta.Controls.Add(this.label14);
            this.pnlOrta.Controls.Add(this.txtMail3);
            this.pnlOrta.Controls.Add(this.label5);
            this.pnlOrta.Controls.Add(this.txtYet3);
            this.pnlOrta.Controls.Add(this.label16);
            this.pnlOrta.Controls.Add(this.label10);
            this.pnlOrta.Controls.Add(this.txtVergiDairesi);
            this.pnlOrta.Controls.Add(this.txtHastaneAdi);
            this.pnlOrta.Controls.Add(this.txtMail2);
            this.pnlOrta.Controls.Add(this.txtMail1);
            this.pnlOrta.Controls.Add(this.txtHastaneCari);
            this.pnlOrta.Controls.Add(this.txtYet2);
            this.pnlOrta.Controls.Add(this.txtAdres1);
            this.pnlOrta.Controls.Add(this.txtYet1);
            this.pnlOrta.Controls.Add(this.txtAdres2);
            this.pnlOrta.Controls.Add(this.txtHastaneMail);
            this.pnlOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrta.Location = new System.Drawing.Point(0, 56);
            this.pnlOrta.Name = "pnlOrta";
            this.pnlOrta.Size = new System.Drawing.Size(1014, 236);
            this.pnlOrta.TabIndex = 7;
            // 
            // txtCariTip
            // 
            this.txtCariTip.FormattingEnabled = true;
            this.txtCariTip.Location = new System.Drawing.Point(683, 133);
            this.txtCariTip.Name = "txtCariTip";
            this.txtCariTip.Size = new System.Drawing.Size(100, 21);
            this.txtCariTip.TabIndex = 22;
            // 
            // frmHastaneGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 445);
            this.Controls.Add(this.pnlOrta);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.pnlAlt);
            this.Controls.Add(this.pnlUst);
            this.Name = "frmHastaneGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHastaneGiris";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHastaneGiris_FormClosing);
            this.Load += new System.EventHandler(this.frmHastaneGiris_Load);
            this.pnlUst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.pnlOrta.ResumeLayout(false);
            this.pnlOrta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Button btnFormCikis;
        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtHastaneAdi;
        private System.Windows.Forms.TextBox txtHastaneCari;
        private System.Windows.Forms.TextBox txtAdres1;
        private System.Windows.Forms.TextBox txtAdres2;
        private System.Windows.Forms.TextBox txtYet1;
        private System.Windows.Forms.TextBox txtYet2;
        private System.Windows.Forms.TextBox txtYet3;
        private System.Windows.Forms.TextBox txtMail1;
        private System.Windows.Forms.TextBox txtMail2;
        private System.Windows.Forms.TextBox txtMail3;
        private System.Windows.Forms.TextBox txtVergiDairesi;
        private System.Windows.Forms.ComboBox txtDepartman1;
        private System.Windows.Forms.ComboBox txtDepartman2;
        private System.Windows.Forms.ComboBox txtDepartman3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtHastaneMail;
        private System.Windows.Forms.ComboBox txtSehir;
        private System.Windows.Forms.MaskedTextBox txtYtel1;
        private System.Windows.Forms.MaskedTextBox txtYtel2;
        private System.Windows.Forms.MaskedTextBox txtYtel3;
        private System.Windows.Forms.MaskedTextBox txtYCep1;
        private System.Windows.Forms.MaskedTextBox txtYCep2;
        private System.Windows.Forms.MaskedTextBox txtYCep3;
        private System.Windows.Forms.MaskedTextBox txtVnTc;
        private System.Windows.Forms.MaskedTextBox txtHastaneTel;
        private System.Windows.Forms.Panel pnlOrta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn YetkiliAdi1;
        private System.Windows.Forms.Label lblHastaneKodu;
        private System.Windows.Forms.ComboBox txtCariTip;
    }
}