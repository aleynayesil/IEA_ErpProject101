
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

namespace IEA_ErpProject101_Main.BilgiGirisİslemleri.Personeller
{

  
    public partial class frmPersonelGiris : Form
    {
        private readonly ErpProjectWMPEntities erp = new ErpProjectWMPEntities();

        private Numaralar n = new Numaralar();

        public int secimId = -1;
        public frmPersonelGiris()
        {
            InitializeComponent();
        }

        private void frmPersonelGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            listele();
        }
        private void listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in erp.tblPersonelDetay
                       where s.tblCariler.isActive == true && s.tblCariler.CariGroupId == 6
                       select s).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.tblCariler.CariNo;
                Liste.Rows[i].Cells[3].Value = k.tblCariler.CariAdi;
                Liste.Rows[i].Cells[4].Value = k.tblCariler.CariTel;
                Liste.Rows[i].Cells[5].Value = k.tblCariler.CariMail;
                Liste.Rows[i].Cells[6].Value = k.tblCariler.YetkiliCep1;
                Liste.Rows[i].Cells[7].Value = k.İsBasiTarih;
                Liste.Rows[i].Cells[8].Value = k.İsSonuTarih;
                i++;
                sira++;
            }
            Liste.AllowUserToAddRows = false;
            lblPersonelKodu.Text = n.CariKoduPersonel();
        }

        private void ComboDoldur()
        {
            txtPUnvan.DataSource = Enum.GetValues(typeof(enumPersonelUnvan));


            var lst = erp.tblDepartmanlar.Where(x => x.GrupId == 6).ToList();
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

        private void btnKayit_Click(object sender, EventArgs e)
        {
            YeniKayıt();
        }
        private void YeniKayıt()
        {

            string pkodu = n.CariKoduPersonel();
            try
            {
                if (secimId == -1)
                {
                    tblCariler dr = new tblCariler();
                    dr.isActive = true;
                    dr.CariAdi = txtPersonelAdi.Text;
                    dr.CariMail = txtPersonelMail.Text;
                    dr.CariTel = txtPersonelTel.Text;
                    dr.YetkiliDepartmani1 = txtDepartman1.Text;
                    dr.YetkiliCep1 = txtPCep1.Text;
                    dr.Adres1 = txtAdres1.Text;
                    dr.Adres2 = txtAdres2.Text;
                    dr.CariGroupId = 6;
                    dr.CariTipId = 1;//formda combobox olacak
                    dr.CariUnvan = txtPUnvan.Text;
                    dr.Tc_Vn = txtVnTc.Text;
                    if (txtSehir.Text!="")
                    {
                        dr.SehirId = (int?)txtSehir.SelectedValue ?? -1;
                    }
                    //txtSehir.SelectedValue != null ? (int)txtSehir.SelectedValue : -1; //erp.tblSehirler.First(x => x.sehir == txtSehir.Text).id;
                    dr.SaveUserId = 1;
                    dr.SaveDate = DateTime.Now;
                    dr.CariNo = pkodu;

                    erp.tblCariler.Add(dr);
                    erp.SaveChanges();

                    tblPersonelDetay pdet = new tblPersonelDetay();
                    pdet.CariId = erp.tblCariler.First(x => x.CariAdi == txtPersonelAdi.Text).Id;
                    pdet.İsBasiTarih = dtİsBası.Value;
                    //pdet.İsSonuTarih = dtİsSonu.Value;
                    erp.tblPersonelDetay.Add(pdet);
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
            if (secimId<0)
            {
                return;
            }
            try
            {
                tblPersonelDetay dr = erp.tblPersonelDetay.First(x => x.Id == secimId);
                dr.tblCariler.CariAdi = txtPersonelAdi.Text;
                dr.tblCariler.CariMail = txtPersonelMail.Text;
                dr.tblCariler.CariTel = txtPersonelTel.Text;
                dr.tblCariler.YetkiliDepartmani1 = txtDepartman1.Text;
                dr.tblCariler.YetkiliCep1 = txtPCep1.Text;
                dr.tblCariler.Adres1 = txtAdres1.Text;
                dr.tblCariler.Adres2 = txtAdres2.Text;
                dr.tblCariler.CariTipId = 1;//formda combobox olacak
                dr.tblCariler.CariUnvan = txtPUnvan.Text;
                dr.tblCariler.Tc_Vn = txtVnTc.Text;
                dr.tblCariler.SehirId = (int?)txtSehir.SelectedValue ?? -1; //txtSehir.SelectedValue != null ? (int)txtSehir.SelectedValue : -1; //erp.tblSehirler.First(x => x.sehir == txtSehir.Text).id;
                dr.tblCariler.UpdateUserId = 1;
                dr.tblCariler.UpdateDate = DateTime.Now;
                dr.tblCariler.CariGroupId = 6;
                dr.İsBasiTarih = dtİsBası.Value;
                if (txtDurum.Checked)
                {
                    dr.İsSonuTarih = dtİsSonu.Value;
                }
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

        private void txtDurum_CheckedChanged(object sender, EventArgs e)
        {
            if (txtDurum.Checked)
            {
                label7.Visible = true;
                dtİsSonu.Visible = true;
            }
            else
            {
                label7.Visible = false;
                dtİsSonu.Visible = false;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secimId > 0)
            {
                tblCariler dr = erp.tblCariler.Find(secimId);
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
            txtDurum.Visible = false;
            label7.Visible = false;
            dtİsSonu.Visible = false;
            dtİsSonu.Text = "";
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
                txtDurum.Visible = true;
                tblPersonelDetay dr = erp.tblPersonelDetay.Find(id);
                txtPersonelAdi.Text = dr.tblCariler.CariAdi;
                txtPersonelMail.Text = dr.tblCariler.CariMail;
                txtPersonelTel.Text = dr.tblCariler.CariTel;
                txtDepartman1.Text = dr.tblCariler.YetkiliDepartmani1;
                txtPCep1.Text = dr.tblCariler.YetkiliCep1;
                txtAdres1.Text = dr.tblCariler.Adres1;
                txtAdres2.Text = dr.tblCariler.Adres2;
                txtPUnvan.Text = dr.tblCariler.CariUnvan;
                txtVnTc.Text = dr.tblCariler.Tc_Vn;
                txtSehir.Text = dr.tblCariler.tblSehirler==null ? "" : dr.tblCariler.tblSehirler.sehir;
                lblPersonelKodu.Text = dr.tblCariler.CariNo;
                txtKayıtBul.Text = dr.tblCariler.CariNo;
                dtİsBası.Text = dr.İsBasiTarih.ToString();
                dtİsSonu.Text = dr.İsSonuTarih.ToString();
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

            if (Application.OpenForms["frmPersonellerListesi"] is null)
            {
                frmPersonellerListesi frm = new frmPersonellerListesi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            SendToBack();

        }

        private void btnFormCikis_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
