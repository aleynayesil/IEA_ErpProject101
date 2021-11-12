
namespace IEA_ErpProject101_Main.BilgiGirisİslemleri.Personeller
{
    partial class frmPersonelGiris
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPCep1 = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtVnTc = new System.Windows.Forms.MaskedTextBox();
            this.txtPersonelTel = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtKayıtBul = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPUnvan = new System.Windows.Forms.ComboBox();
            this.txtCariTip = new System.Windows.Forms.ComboBox();
            this.txtSehir = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.lblPersonelKodu = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnFormCikis = new System.Windows.Forms.Button();
            this.txtDepartman1 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPersonelAdi = new System.Windows.Forms.TextBox();
            this.txtAdres1 = new System.Windows.Forms.TextBox();
            this.txtAdres2 = new System.Windows.Forms.TextBox();
            this.txtPersonelMail = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baslangic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bitis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlOrta = new System.Windows.Forms.Panel();
            this.txtDurum = new System.Windows.Forms.CheckBox();
            this.dtİsSonu = new System.Windows.Forms.DateTimePicker();
            this.dtİsBası = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.pnlOrta.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(13, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Personel Adı :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(793, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Personel Tipi :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPCep1
            // 
            this.txtPCep1.Location = new System.Drawing.Point(106, 129);
            this.txtPCep1.Mask = "(999) 000-0000";
            this.txtPCep1.Name = "txtPCep1";
            this.txtPCep1.Size = new System.Drawing.Size(100, 20);
            this.txtPCep1.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Location = new System.Drawing.Point(9, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 23);
            this.label12.TabIndex = 3;
            this.label12.Text = "Tc No :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVnTc
            // 
            this.txtVnTc.Location = new System.Drawing.Point(106, 184);
            this.txtVnTc.Mask = "00000000000";
            this.txtVnTc.Name = "txtVnTc";
            this.txtVnTc.Size = new System.Drawing.Size(101, 20);
            this.txtVnTc.TabIndex = 24;
            // 
            // txtPersonelTel
            // 
            this.txtPersonelTel.Location = new System.Drawing.Point(107, 103);
            this.txtPersonelTel.Mask = "(999) 000-0000";
            this.txtPersonelTel.Name = "txtPersonelTel";
            this.txtPersonelTel.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelTel.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(9, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "Departman";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label13.Location = new System.Drawing.Point(326, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 23);
            this.label13.TabIndex = 3;
            this.label13.Text = "Sehir";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtKayıtBul
            // 
            this.txtKayıtBul.Location = new System.Drawing.Point(12, 21);
            this.txtKayıtBul.Name = "txtKayıtBul";
            this.txtKayıtBul.Size = new System.Drawing.Size(261, 20);
            this.txtKayıtBul.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(14, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Personel :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPUnvan
            // 
            this.txtPUnvan.FormattingEnabled = true;
            this.txtPUnvan.Location = new System.Drawing.Point(106, 53);
            this.txtPUnvan.Name = "txtPUnvan";
            this.txtPUnvan.Size = new System.Drawing.Size(100, 21);
            this.txtPUnvan.TabIndex = 22;
            // 
            // txtCariTip
            // 
            this.txtCariTip.FormattingEnabled = true;
            this.txtCariTip.Location = new System.Drawing.Point(902, 18);
            this.txtCariTip.Name = "txtCariTip";
            this.txtCariTip.Size = new System.Drawing.Size(100, 21);
            this.txtCariTip.TabIndex = 22;
            // 
            // txtSehir
            // 
            this.txtSehir.FormattingEnabled = true;
            this.txtSehir.Location = new System.Drawing.Point(425, 111);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(100, 21);
            this.txtSehir.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(326, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "Personel Adres 1 :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label15.Location = new System.Drawing.Point(13, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 23);
            this.label15.TabIndex = 3;
            this.label15.Text = "Personel Tel :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlAlt
            // 
            this.pnlAlt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.Location = new System.Drawing.Point(0, 307);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(1014, 10);
            this.pnlAlt.TabIndex = 15;
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlUst.Controls.Add(this.lblPersonelKodu);
            this.pnlUst.Controls.Add(this.btnTemizle);
            this.pnlUst.Controls.Add(this.btnSil);
            this.pnlUst.Controls.Add(this.btnGuncelle);
            this.pnlUst.Controls.Add(this.btnKayit);
            this.pnlUst.Controls.Add(this.btnFormCikis);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1014, 56);
            this.pnlUst.TabIndex = 13;
            // 
            // lblPersonelKodu
            // 
            this.lblPersonelKodu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPersonelKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelKodu.Location = new System.Drawing.Point(427, 14);
            this.lblPersonelKodu.Name = "lblPersonelKodu";
            this.lblPersonelKodu.Size = new System.Drawing.Size(223, 28);
            this.lblPersonelKodu.TabIndex = 1;
            this.lblPersonelKodu.Text = "***";
            this.lblPersonelKodu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // txtDepartman1
            // 
            this.txtDepartman1.FormattingEnabled = true;
            this.txtDepartman1.Location = new System.Drawing.Point(107, 216);
            this.txtDepartman1.Name = "txtDepartman1";
            this.txtDepartman1.Size = new System.Drawing.Size(100, 21);
            this.txtDepartman1.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label14.Location = new System.Drawing.Point(13, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 23);
            this.label14.TabIndex = 3;
            this.label14.Text = "Personel Cep :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(326, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 38);
            this.label5.TabIndex = 3;
            this.label5.Text = "Personel Adres  2 :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label16.Location = new System.Drawing.Point(13, 156);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 23);
            this.label16.TabIndex = 3;
            this.label16.Text = "Personel Mail :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPersonelAdi
            // 
            this.txtPersonelAdi.Location = new System.Drawing.Point(107, 77);
            this.txtPersonelAdi.Name = "txtPersonelAdi";
            this.txtPersonelAdi.Size = new System.Drawing.Size(154, 20);
            this.txtPersonelAdi.TabIndex = 0;
            // 
            // txtAdres1
            // 
            this.txtAdres1.Location = new System.Drawing.Point(425, 146);
            this.txtAdres1.Multiline = true;
            this.txtAdres1.Name = "txtAdres1";
            this.txtAdres1.Size = new System.Drawing.Size(193, 42);
            this.txtAdres1.TabIndex = 4;
            // 
            // txtAdres2
            // 
            this.txtAdres2.Location = new System.Drawing.Point(425, 201);
            this.txtAdres2.Multiline = true;
            this.txtAdres2.Name = "txtAdres2";
            this.txtAdres2.Size = new System.Drawing.Size(193, 42);
            this.txtAdres2.TabIndex = 5;
            // 
            // txtPersonelMail
            // 
            this.txtPersonelMail.Location = new System.Drawing.Point(106, 156);
            this.txtPersonelMail.Name = "txtPersonelMail";
            this.txtPersonelMail.Size = new System.Drawing.Size(155, 20);
            this.txtPersonelMail.TabIndex = 3;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Maroon;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 317);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1014, 10);
            this.splitter1.TabIndex = 16;
            this.splitter1.TabStop = false;
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
            this.Cep,
            this.Baslangic,
            this.Bitis});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Liste.Location = new System.Drawing.Point(0, 327);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(1014, 118);
            this.Liste.TabIndex = 14;
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
            this.CariKodu.HeaderText = "Personel Kodu";
            this.CariKodu.Name = "CariKodu";
            this.CariKodu.Width = 101;
            // 
            // CariAdi
            // 
            this.CariAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CariAdi.HeaderText = "Personel Adı";
            this.CariAdi.Name = "CariAdi";
            // 
            // CariTel
            // 
            this.CariTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariTel.HeaderText = "Personel Tel";
            this.CariTel.Name = "CariTel";
            this.CariTel.Width = 91;
            // 
            // CariMail
            // 
            this.CariMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariMail.HeaderText = "Personel Mail";
            this.CariMail.Name = "CariMail";
            this.CariMail.Width = 95;
            // 
            // Cep
            // 
            this.Cep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cep.HeaderText = "Personel Gsm";
            this.Cep.Name = "Cep";
            this.Cep.Width = 97;
            // 
            // Baslangic
            // 
            this.Baslangic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = "-";
            this.Baslangic.DefaultCellStyle = dataGridViewCellStyle3;
            this.Baslangic.HeaderText = "Bas.Tarih";
            this.Baslangic.Name = "Baslangic";
            this.Baslangic.Width = 77;
            // 
            // Bitis
            // 
            this.Bitis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = "-";
            this.Bitis.DefaultCellStyle = dataGridViewCellStyle4;
            this.Bitis.HeaderText = "Bit.Tarih";
            this.Bitis.Name = "Bitis";
            this.Bitis.Width = 71;
            // 
            // pnlOrta
            // 
            this.pnlOrta.AutoScroll = true;
            this.pnlOrta.Controls.Add(this.txtDurum);
            this.pnlOrta.Controls.Add(this.dtİsSonu);
            this.pnlOrta.Controls.Add(this.dtİsBası);
            this.pnlOrta.Controls.Add(this.txtKayıtBul);
            this.pnlOrta.Controls.Add(this.label1);
            this.pnlOrta.Controls.Add(this.label2);
            this.pnlOrta.Controls.Add(this.label7);
            this.pnlOrta.Controls.Add(this.label3);
            this.pnlOrta.Controls.Add(this.label6);
            this.pnlOrta.Controls.Add(this.txtPCep1);
            this.pnlOrta.Controls.Add(this.label12);
            this.pnlOrta.Controls.Add(this.txtVnTc);
            this.pnlOrta.Controls.Add(this.txtPersonelTel);
            this.pnlOrta.Controls.Add(this.label8);
            this.pnlOrta.Controls.Add(this.txtPUnvan);
            this.pnlOrta.Controls.Add(this.label13);
            this.pnlOrta.Controls.Add(this.txtCariTip);
            this.pnlOrta.Controls.Add(this.txtSehir);
            this.pnlOrta.Controls.Add(this.label4);
            this.pnlOrta.Controls.Add(this.label15);
            this.pnlOrta.Controls.Add(this.txtDepartman1);
            this.pnlOrta.Controls.Add(this.label14);
            this.pnlOrta.Controls.Add(this.label5);
            this.pnlOrta.Controls.Add(this.label16);
            this.pnlOrta.Controls.Add(this.txtPersonelAdi);
            this.pnlOrta.Controls.Add(this.txtAdres1);
            this.pnlOrta.Controls.Add(this.txtAdres2);
            this.pnlOrta.Controls.Add(this.txtPersonelMail);
            this.pnlOrta.Location = new System.Drawing.Point(0, 52);
            this.pnlOrta.Name = "pnlOrta";
            this.pnlOrta.Size = new System.Drawing.Size(1014, 393);
            this.pnlOrta.TabIndex = 17;
            // 
            // txtDurum
            // 
            this.txtDurum.AutoSize = true;
            this.txtDurum.Location = new System.Drawing.Point(632, 136);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(121, 17);
            this.txtDurum.TabIndex = 29;
            this.txtDurum.Text = "İş Bitiş Tarihi Girilsin:";
            this.txtDurum.UseVisualStyleBackColor = true;
            this.txtDurum.Visible = false;
            this.txtDurum.CheckedChanged += new System.EventHandler(this.txtDurum_CheckedChanged);
            // 
            // dtİsSonu
            // 
            this.dtİsSonu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtİsSonu.Location = new System.Drawing.Point(735, 173);
            this.dtİsSonu.Name = "dtİsSonu";
            this.dtİsSonu.Size = new System.Drawing.Size(200, 20);
            this.dtİsSonu.TabIndex = 28;
            this.dtİsSonu.Visible = false;
            // 
            // dtİsBası
            // 
            this.dtİsBası.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtİsBası.Location = new System.Drawing.Point(735, 110);
            this.dtİsBası.Name = "dtİsBası";
            this.dtİsBası.Size = new System.Drawing.Size(200, 20);
            this.dtİsBası.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(629, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "İş Bitişi :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(629, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "İş Başlangıcı :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmPersonelGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 445);
            this.Controls.Add(this.pnlAlt);
            this.Controls.Add(this.pnlUst);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.pnlOrta);
            this.Name = "frmPersonelGiris";
            this.Text = "frmPersonelGiris";
            this.Load += new System.EventHandler(this.frmPersonelGiris_Load);
            this.pnlUst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.pnlOrta.ResumeLayout(false);
            this.pnlOrta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtPCep1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txtVnTc;
        private System.Windows.Forms.MaskedTextBox txtPersonelTel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox txtKayıtBul;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtPUnvan;
        private System.Windows.Forms.ComboBox txtCariTip;
        private System.Windows.Forms.ComboBox txtSehir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Label lblPersonelKodu;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnFormCikis;
        private System.Windows.Forms.ComboBox txtDepartman1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPersonelAdi;
        private System.Windows.Forms.TextBox txtAdres1;
        private System.Windows.Forms.TextBox txtAdres2;
        private System.Windows.Forms.TextBox txtPersonelMail;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Panel pnlOrta;
        private System.Windows.Forms.DateTimePicker dtİsSonu;
        private System.Windows.Forms.DateTimePicker dtİsBası;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Baslangic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bitis;
        private System.Windows.Forms.CheckBox txtDurum;
    }
}