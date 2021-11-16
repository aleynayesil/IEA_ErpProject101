
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

namespace IEA_ErpProject101_Main.BilgiGirisİslemleri.Doktorlar
{
    public partial class frmDoktorGiris : Form

    {
        private readonly ErpProjectWMPEntities erp = new ErpProjectWMPEntities();

        private Numaralar n = new Numaralar();

        public int secimId = -1;

        public frmDoktorGiris()
        {
            InitializeComponent();
        }

        private void frmDoktorGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            listele();
        }

        private void listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in erp.tblCariler
                       where s.isActive == true && s.CariGroupId==2
                       select new
                       {
                           id = s.Id,
                           dcode = s.CariNo,
                           dadi = s.CariAdi,
                           dtel = s.CariTel,
                           dmail = s.CariMail,
                           dcep = s.YetkiliCep1,
                       }).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.dcode;
                Liste.Rows[i].Cells[3].Value = k.dadi;
                Liste.Rows[i].Cells[4].Value = k.dtel;
                Liste.Rows[i].Cells[5].Value = k.dmail;
                Liste.Rows[i].Cells[6].Value = k.dcep;
                i++;
                sira++;
            }
            Liste.AllowUserToAddRows = false;
            lblDoktorKodu.Text = n.CariKoduDoktor();
        }

        private void ComboDoldur()
        {
            txtDUnvan.DataSource = Enum.GetValues(typeof(DoktorUnvan));


                var lst = erp.tblDepartmanlar.Where(x => x.GrupId == 2).ToList();
                var lst1 = erp.tblSehirler.ToList();


                txtDepartman1.DataSource = lst;
                txtDepartman1.ValueMember = "Id";
                txtDepartman1.DisplayMember = "DepartmanAdi";
                txtDepartman1.SelectedIndex = -1;


                txtSehir.DataSource = lst1;
                txtSehir.ValueMember = "id";
                txtSehir.DisplayMember = "Sehir";
                txtSehir.SelectedIndex = -1;

        }
        private void frmDoktorGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Home.kontrol = true;
        }
        private void btnFormCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
           YeniKayıt();
        }

        private void YeniKayıt()
        {

            string dkodu = n.CariKoduDoktor();
            try
            {
                if (secimId == -1)
                {
                    tblCariler dr = new tblCariler();
                    dr.isActive = true;
                    dr.CariAdi = txtDoktorAdi.Text;
                    dr.CariMail = txtDoktorMail.Text;
                    dr.CariTel = txtDoktorTel.Text;
                    dr.YetkiliDepartmani1 = txtDepartman1.Text;
                    dr.YetkiliCep1 = txtYCep1.Text;
                    dr.Adres1 = txtAdres1.Text;
                    dr.Adres2 = txtAdres2.Text;
                    dr.CariGroupId = 1;
                    dr.CariTipId = 1;//formda combobox olacak
                    dr.CariUnvan = txtDUnvan.Text;
                    dr.Vdairesi = txtVergiDairesi.Text;
                    dr.Tc_Vn = txtVnTc.Text;
                    if (txtSehir.Text != "")
                    {
                        dr.SehirId = (int?)txtSehir.SelectedValue ?? -1;
                    } //txtSehir.SelectedValue != null ? (int)txtSehir.SelectedValue : -1; //erp.tblSehirler.First(x => x.sehir == txtSehir.Text).id;
                    dr.SaveUserId = 1;
                    dr.SaveDate = DateTime.Now;
                    dr.CariNo = dkodu;
                    dr.CariGroupId = 2;

                    erp.tblCariler.Add(dr);
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
                tblCariler dr = Home.tblCarileId;
                dr.CariAdi = txtDoktorAdi.Text;
                dr.CariMail = txtDoktorMail.Text;
                dr.CariTel = txtDoktorTel.Text;
                dr.YetkiliDepartmani1 = txtDepartman1.Text;
                dr.YetkiliCep1 = txtYCep1.Text;
                dr.Adres1 = txtAdres1.Text;
                dr.Adres2 = txtAdres2.Text;
                dr.CariTipId = 1;//formda combobox olacak
                dr.CariUnvan = txtDUnvan.Text;
                dr.Vdairesi = txtVergiDairesi.Text;
                dr.Tc_Vn = txtVnTc.Text;
                dr.SehirId = (int?)txtSehir.SelectedValue ?? -1; //txtSehir.SelectedValue != null ? (int)txtSehir.SelectedValue : -1; //erp.tblSehirler.First(x => x.sehir == txtSehir.Text).id;
                dr.UpdateUserId = 1;
                dr.UpdateDate = DateTime.Now;
                dr.CariGroupId = 2;
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secimId > 0)
            {
                tblCariler dr =Home.tblCarileId;
                dr.isActive = false;
                erp.SaveChanges();
                MessageBox.Show("Silme Başarılı");
                Temizle();
                listele();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
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

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            Ac(secimId);
        }
        public void Ac(int id)
        {
            secimId = id;//dış formdan veri gelirse secimId hatası almamak için bu işlem yapılır.
            Home.tblCarileId = erp.tblCariler.Find(id);
            try
            {
                tblCariler dr = Home.tblCarileId;
                dr.isActive = true;
                txtDoktorAdi.Text = dr.CariAdi;
                txtDoktorMail.Text =dr.CariMail;
                txtDoktorTel.Text = dr.CariTel;
                txtDepartman1.Text =dr.YetkiliDepartmani1;
                txtYCep1.Text =  dr.YetkiliCep1;
                txtAdres1.Text = dr.Adres1;
                txtAdres2.Text = dr.Adres2;
                txtDUnvan.Text = dr.CariUnvan;
                txtVergiDairesi.Text = dr.Vdairesi;
                txtVnTc.Text = dr.Tc_Vn;
                txtSehir.Text = dr.tblSehirler == null ? "" : dr.tblSehirler.sehir;
                lblDoktorKodu.Text = dr.CariNo;
                txtKayıtBul.Text =dr.CariNo;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
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

            if (Application.OpenForms["frmHastanelerListesi"] is null)
            {
                frmHastanelerListesi frm = new frmHastanelerListesi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            SendToBack();

        }
    }
}
