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

namespace IEA_ErpProject101_Main.Urunİslemleri
{
    public partial class frmUrunGiris : Form
    {
        private ErpProjectWMPEntities erp = new ErpProjectWMPEntities();
        Numaralar n = new Numaralar();

        private int secimId = -1;
        public frmUrunGiris()
        {
            InitializeComponent();
        }

        private void frmUrunGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in erp.tblUrunler
                       where s.isActive == true
                       select s).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.UrunGenelNo;
                Liste.Rows[i].Cells[3].Value = k.UrunKodu;
                Liste.Rows[i].Cells[4].Value = k.UrunAdı;
                i++;
                sira++;
            }
            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lblUrunKodu.Text = n.UrunGenelKodu();
            txtKayitBul.Text = n.UrunGenelKodu();
        }

        private void ComboDoldur()
        {
            txtUrunTedarikciId.DataSource = (from s in erp.tblCariler
                                             where s.CariGroupId==3
                                             where s.CariUnvan == "Distribütör"
                                             select s).ToList();
            txtUrunTedarikciId.ValueMember = "Id";
            txtUrunTedarikciId.DisplayMember = "CariAdi";

        }

        private void YeniKayıt()
        {
            if (secimId!=-1 || txtUrunKodu.Text=="")
            {
                return;
            }
            try
            {
                tblUrunler urn = new tblUrunler();
                urn.UrunAdı = txtUrunAdi.Text;
                urn.TedarikciFirmaId = (int)txtUrunTedarikciId.SelectedValue;
                urn.UrunKodu = txtUrunKodu.Text;
                urn.AlısFiyat = decimal.Parse(txtAlis.Text);
                urn.SatisFiyat = decimal.Parse(txtSatis.Text);
                urn.Kutuİcerik = txtKutu.Text;
                urn.UrunGenelNo =n.UrunGenelKodu();
                urn.UrunAciklama = txtUrunAciklama.Text;
                urn.SaveDate = DateTime.Now;
                urn.SaveUserId = 1;
                urn.isActive = true;

                erp.tblUrunler.Add(urn);
                erp.SaveChanges();
                MessageBox.Show("Kayıt Başarılı");

                Temizle();
                Listele();

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
        private tblUrunler urunler;

        public void Ac(int id)
        {
            secimId = id;
            urunler = erp.tblUrunler.Find(secimId);
           
            try
            {
                tblUrunler urn = urunler;
                txtUrunTedarikciId.Text = urn.tblCariler.CariAdi;
                txtKayitBul.Text = urn.UrunGenelNo;
                txtUrunKodu.Text = urn.UrunKodu;
                txtUrunAciklama.Text = urn.UrunAciklama;
                txtUrunAdi.Text = urn.UrunAdı;
                txtAlis.Text = urn.AlısFiyat.ToString();
                txtSatis.Text = urn.SatisFiyat.ToString();
                txtKutu.Text = urn.Kutuİcerik;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Guncelle()
        {
            if (secimId == -1)
            {
                return;
            }
            try
            {

                tblUrunler urn = urunler;
                urn.UrunAdı = txtUrunAdi.Text;
                urn.TedarikciFirmaId = (int)txtUrunTedarikciId.SelectedValue;
                urn.UrunKodu = txtUrunKodu.Text;
                urn.AlısFiyat = decimal.Parse(txtAlis.Text);
                urn.SatisFiyat = decimal.Parse(txtSatis.Text);
                urn.Kutuİcerik = txtKutu.Text;
                urn.UrunGenelNo = txtKayitBul.Text;
                urn.UrunAciklama = txtUrunAciklama.Text;
                urn.UpdateDate = DateTime.Now;
                urn.UpdateUserId = 1;



                erp.SaveChanges();
                MessageBox.Show("Güncelleme Başarılı");

                Temizle();
                Listele();

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            Ac(secimId);
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            YeniKayıt();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secimId > 0)
            {
                tblUrunler urn = urunler;
                urn.isActive = false;
                erp.SaveChanges();
                MessageBox.Show("Silme Başarılı");
                Temizle();
                Listele();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();
            btn.Size = new Size(25, txtKayitBul.ClientSize.Height + 0);
            btn.Location = new Point(txtKayitBul.ClientSize.Width - btn.Width + 1);
            btn.Cursor = Cursors.Default;
            btn.Image = Resources.arrow_1176;
            txtKayitBul.Controls.Add(btn);
            base.OnLoad(e);
            btn.Click += btn_Click;
        }

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        private void btn_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["frmUrunlerListesi"] is null)
            {
                frmUrunlerListesi frm = new frmUrunlerListesi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            SendToBack();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnFormCikis_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
