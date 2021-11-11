using IEA_ErpProject101_Main.BilgiGirisİslemleri.Hastaneler;
using IEA_ErpProject101_Main.Entity;
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
    public partial class frmHastanelerListesi : Form
    {
        private ErpProjectWMPEntities erp = new ErpProjectWMPEntities();

        public int secimId = -1;
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
            var lst = (from s in erp.tblCariler
                       where s.isActive == true
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
            if (secimId > 0 && Application.OpenForms["frmHastaneGiris"] == null)//form açık değilse
            {
                
                frmHastaneGiris frm = new frmHastaneGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
                frm.Ac(secimId);
                this.Close();
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
