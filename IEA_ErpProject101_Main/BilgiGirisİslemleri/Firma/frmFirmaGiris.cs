using IEA_ErpProject101_Main.Entity;
using IEA_ErpProject101_Main.Fonksiyonlar;
using IEA_ErpProject101_Main.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject101_Main.BilgiGirisİslemleri.Firma
{
    public partial class frmFirmaGiris : Form
    {
        private readonly ErpProjectWMPEntities erp = new ErpProjectWMPEntities();

        private Numaralar n = new Numaralar();

        public int secimId = -1;
        public frmFirmaGiris()
        {
            InitializeComponent();
        }

        private void frmFirmaGiris_Load(object sender, EventArgs e)
        {
          
            comboDoldur();
            listele();
        }
        public void listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in erp.tblCariler
                       where s.isActive == true && s.CariGroupId == 3
                       select new
                       {
                           id = s.Id,
                           hcode = s.CariNo,
                           hadi = s.CariAdi,
                           htel = s.CariTel,
                           hmail = s.CariMail,
                           hyet = s.YetkiliAdi1,
                           hyetcep=s.YetkiliCep1,
                       }).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.hcode;
                Liste.Rows[i].Cells[3].Value = k.hadi;
                Liste.Rows[i].Cells[4].Value = k.htel;
                Liste.Rows[i].Cells[5].Value = k.hmail;
                Liste.Rows[i].Cells[6].Value = k.hyet;
                Liste.Rows[i].Cells[7].Value = k.hyetcep;
                i++;
                sira++;
            }
            Liste.AllowUserToAddRows = false;
            lblFirmaKodu.Text = n.CariKoduFirma();
        }

        private void comboDoldur()
        {
            txtFTip.DataSource = Enum.GetValues(typeof(enumFirmaTipi));
            var lst = erp.tblDepartmanlar.Where(x => x.GrupId ==3).ToList();
            var lst1 = erp.tblDepartmanlar.Where(x => x.GrupId == 3).ToList();
            var lst2 = erp.tblDepartmanlar.Where(x => x.GrupId == 3).ToList();
            var lst3 = erp.tblSehirler.ToList();


            txtFdept1.DataSource = lst;
            txtFdept1.ValueMember = "Id";
            txtFdept1.DisplayMember = "DepartmanAdi";
            txtFdept1.SelectedIndex = -1;

            txtFdept2.DataSource = lst1;
            txtFdept2.ValueMember = "Id";
            txtFdept2.DisplayMember = "DepartmanAdi";
            txtFdept2.SelectedIndex = -1;

            txtFdept3.DataSource = lst2;
            txtFdept3.ValueMember = "Id";
            txtFdept3.DisplayMember = "DepartmanAdi";
            txtFdept3.SelectedIndex = -1;


            txtSehir.DataSource = lst3;
            txtSehir.ValueMember = "id";
            txtSehir.DisplayMember = "Sehir";
            txtSehir.SelectedIndex = -1;
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            YeniKayıt();
        }
        private void YeniKayıt()
        {
            string hkodu = n.CariKoduFirma();
            try
            {
                if (secimId == -1)
                {
                    tblCariler hst = new tblCariler();
                    hst.isActive = true;
                    hst.CariAdi = txtFAdi.Text;
                    hst.CariMail = txtFMail.Text;
                    hst.CariTel = txtFTel.Text;
                    hst.YetkiliAdi1 = txtFYet1.Text;
                    hst.YetkiliAdi2 = txtFYet2.Text;
                    hst.YetkiliAdi3 = txtFYet3.Text;
                    hst.YetkiliDepartmani1 = txtFdept1.Text;
                    hst.YetkiliDepartmani2 = txtFdept2.Text;
                    hst.YetkiliDepartmani3 = txtFdept3.Text;
                    hst.YetkiliTel1 = txtFYtel1.Text;
                    hst.YetkiliTel2 = txtFYtel2.Text;
                    hst.YetkiliTel3 = txtFYtel3.Text;
                    hst.YetkiliCep1 = txtFYCep1.Text;
                    hst.YetkiliCep2 = txtFYCep2.Text;
                    hst.YetkiliCep3 = txtFYCep3.Text;
                    hst.YetkiliMail1 = txtFYMail1.Text;
                    hst.YetkiliMail2 = txtFYMail2.Text;
                    hst.YetkiliMail3 = txtFYMail3.Text;
                    hst.Adres1 = txtAdres1.Text;
                    hst.Adres2 = txtAdres2.Text;
                    hst.CariGroupId = 3;

                   // hst.CariUnvan = txtHastaneCari.Text;
                    hst.CariTipId =txtFTip.SelectedIndex +1;
                    hst.CariUnvan = txtFTip.Text;
                    hst.Vdairesi = txtVergiDairesi.Text;
                    hst.Tc_Vn = txtVnTc.Text;
                    if (txtSehir.Text!="")
                    {
                        hst.SehirId = (int?)txtSehir.SelectedValue ?? -1; 
                    } //txtSehir.SelectedValue != null ? (int)txtSehir.SelectedValue : -1; //erp.tblSehirler.First(x => x.sehir == txtSehir.Text).id;
                    hst.SaveUserId = 1;
                    hst.SaveDate = DateTime.Now;
                    hst.CariNo = hkodu;

                    erp.tblCariler.Add(hst);
                    erp.SaveChanges();

                    MessageBox.Show("Kayıt Başarılı.");
                    Temizle();
                    listele();
                }
                else
                {
                    MessageBox.Show("Bu Kayıt Daha Önce Yapılmıştır. Başka Kayıt Giriniz.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show(e.Message);
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }
        private void Guncelle()
        {

            if (secimId < 0)
            {
                return;
            }
            try
            {
                tblCariler hst = erp.tblCariler.Find(secimId);
                hst.CariAdi = txtFAdi.Text;
                hst.CariMail = txtFMail.Text;
                hst.CariTel = txtFTel.Text;
                hst.YetkiliAdi1 = txtFYet1.Text;
                hst.YetkiliAdi2 = txtFYet2.Text;
                hst.YetkiliAdi3 = txtFYet3.Text;
                hst.YetkiliDepartmani1 = txtFdept1.Text;
                hst.YetkiliDepartmani2 = txtFdept2.Text;
                hst.YetkiliDepartmani3 = txtFdept3.Text;
                hst.YetkiliTel1 = txtFYtel1.Text;
                hst.YetkiliTel2 = txtFYtel2.Text;
                hst.YetkiliTel3 = txtFYtel3.Text;
                hst.YetkiliCep1 = txtFYCep1.Text;
                hst.YetkiliCep2 = txtFYCep2.Text;
                hst.YetkiliCep3 = txtFYCep3.Text;
                hst.YetkiliMail1 = txtFYMail1.Text;
                hst.YetkiliMail2 = txtFYMail2.Text;
                hst.YetkiliMail3 = txtFYMail3.Text;
                hst.Adres1 = txtAdres1.Text;
                hst.Adres2 = txtAdres2.Text;
                if (txtFTip.Text != "")
                {
                    hst.CariTipId = (int)txtFTip.SelectedIndex;

                }
                hst.Vdairesi = txtVergiDairesi.Text;
                hst.Tc_Vn = txtVnTc.Text;
                hst.SehirId = (int?)txtSehir.SelectedValue ?? -1; //txtSehir.SelectedValue != null ? (int)txtSehir.SelectedValue : -1; //erp.tblSehirler.First(x => x.sehir == txtSehir.Text).id;
                hst.UpdateUserId = 1;
                hst.UpdateDate = DateTime.Now;
                hst.CariUnvan = txtFTip.Text;
                erp.SaveChanges();

                MessageBox.Show("Güncelleme Başarılı.");
                Temizle();
                listele();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void Temizle()
        {
            foreach (Control k in pnlOrta.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox)
                {
                    k.Text = "";
                }
            }
            secimId = -1;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control k in pnlOrta.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox)
                {
                    k.Text = "";
                }
            }
            secimId = -1;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secimId > 0)
            {
                tblCariler hst = erp.tblCariler.Find(secimId);
                hst.isActive = false;
                erp.SaveChanges();
                MessageBox.Show("Silme Başarılı");
                Temizle();
                listele();
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();
            btn.Size = new Size(25, txtKayıtBul.ClientSize.Height + 0);
            btn.Location = new Point(txtKayıtBul.ClientSize.Width - btn.Width + 1);
            btn.Cursor = Cursors.Default;
            btn.Image = Resources.arrow_1176;
            txtKayıtBul.Controls.Add(btn);
            base.OnLoad(e);
            btn.Click += btn_Click;
        }

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        private void btn_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["frmFirmalarListesi"] is null)
            {
                frmFirmalarListesi frm = new frmFirmalarListesi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            SendToBack();

        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            Ac(secimId);
        }
        public void Ac(int id)
        {
            secimId = id;//dış formdan veri gelirse secimId hatası almamak için bu işlem yapılır.
            try
            {
                tblCariler hst = erp.tblCariler.Find(id);
                txtFAdi.Text = hst.CariAdi;
                txtFMail.Text = hst.CariMail;
                txtFTel.Text = hst.CariTel;
                txtFYet1.Text = hst.YetkiliAdi1;
                txtFYet2.Text = hst.YetkiliAdi2;
                txtFYet3.Text = hst.YetkiliAdi3;
                txtFdept1.Text = hst.YetkiliDepartmani1;
                txtFdept2.Text = hst.YetkiliDepartmani2;
                txtFdept3.Text = hst.YetkiliDepartmani3;
                txtFYtel1.Text = hst.YetkiliTel1;
                txtFYtel2.Text = hst.YetkiliTel2;
                txtFYtel3.Text = hst.YetkiliTel3;
                txtFYCep1.Text = hst.YetkiliCep1;
                txtFYCep2.Text = hst.YetkiliCep2;
                txtFYCep3.Text = hst.YetkiliCep3;
                txtFYMail1.Text = hst.YetkiliMail1;
                txtFYMail2.Text = hst.YetkiliMail2;
                txtFYMail3.Text = hst.YetkiliMail3;
                txtAdres1.Text = hst.Adres1;
                txtAdres2.Text = hst.Adres2;
                txtVergiDairesi.Text = hst.Vdairesi;
                txtVnTc.Text = hst.Tc_Vn;

               
                if (hst.tblSehirler!=null)
                {
                    txtSehir.Text = hst.tblSehirler.sehir;
                }
                else
                {
                    txtSehir.Text = "";
                }
                lblFirmaKodu.Text = hst.CariNo;
                txtKayıtBul.Text = hst.CariNo;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        private void btnFormCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
