using IEA_ErpProject101_Main.BilgiGirisİslemleri.Hastaneler;
using IEA_ErpProject101_Main.Entity;
using IEA_ErpProject101_Main.Fonksiyonlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject101_Main.BilgiGirisİslemleri
{
    public partial class frmHastanelerListesi : Ortaklar
    {
        //private ErpProjectWMPEntities db = new ErpProjectWMPEntities();

        public int secimId = -1;

        public bool Secim = false;
        public frmHastanelerListesi()
        {
            InitializeComponent();
        }

        private void frmHastanelerListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in db.tblCariler
                       where s.isActive == true && s.CariGroupId==1
                       select s).ToList();
            foreach (tblCariler k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.CariNo;
                Liste.Rows[i].Cells[3].Value = k.CariAdi;
                Liste.Rows[i].Cells[4].Value = k.CariTel;
                Liste.Rows[i].Cells[5].Value = k.CariMail;
                Liste.Rows[i].Cells[6].Value = k.YetkiliAdi1;
                i++;
                sira++;
            }
            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void frmHastanelerListesi_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Home.kontrol = false;
            //this.dispose();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            if (secimId > 0 && Secim && Application.OpenForms["frmHastaneGiris"] == null)//form açık değilse
            {
                Home.Aktarma = secimId;
                //frmHastaneGiris frm = new frmHastaneGiris();
                //frm.MdiParent = Form.ActiveForm;
                //frm.Show();
                //frm.Ac(secimId);
                Close();
            }
            else if (Application.OpenForms["frmHastaneGiris"] != null)
            {
                frmHastaneGiris frm = Application.OpenForms["frmHastaneGiris"] as frmHastaneGiris;
                frm.Ac(secimId);
                Close();

            }

        }

    }
}
