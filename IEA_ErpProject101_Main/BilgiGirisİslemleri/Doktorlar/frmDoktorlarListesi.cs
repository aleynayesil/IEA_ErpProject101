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

namespace IEA_ErpProject101_Main.BilgiGirisİslemleri.Doktorlar
{
    public partial class frmDoktorlarListesi : Form
    {
        private ErpProjectWMPEntities erp = new ErpProjectWMPEntities();

        public int secimId = -1;

        public bool Secim = false;
        public frmDoktorlarListesi()
        {
            InitializeComponent();
        }

        private void frmDoktorlarListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in erp.tblCariler
                       where s.isActive == true && s.CariGroupId==2
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
                Liste.Rows[i].Cells[6].Value = k.YetkiliCep1;
                i++;
                sira++;
            }
            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

   
        private void Liste_DoubleClick_1(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            if (secimId > 0 &&Secim&& Application.OpenForms["frmDoktorGiris"] == null)//form açık değilse
            {
                Home.Aktarma=secimId;
                //frmDoktorGiris frm = new frmDoktorGiris();
                //frm.MdiParent = Form.ActiveForm;
                //frm.Show();
                //frm.Ac(secimId);
                Close();
            }
            else if (Application.OpenForms["frmDoktorGiris"] != null)
            {
                frmDoktorGiris frm = Application.OpenForms["frmDoktorGiris"] as frmDoktorGiris;
                frm.Ac(secimId);
                Close();

            }
        }
    }
}
