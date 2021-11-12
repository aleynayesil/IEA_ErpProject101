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

namespace IEA_ErpProject101_Main.BilgiGirisİslemleri.Personeller
{
    public partial class frmPersonellerListesi : Form
    {
        private ErpProjectWMPEntities erp = new ErpProjectWMPEntities();

        public int secimId = -1;
        public frmPersonellerListesi()
        {
            InitializeComponent();
        }

        private void frmPersonellerListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
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
           // Liste.ReadOnly = true;
            //Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            if (secimId > 0 && Application.OpenForms["frmPersonelGiris"] == null)//form açık değilse
            {

                frmPersonelGiris frm = new frmPersonelGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
                frm.Ac(secimId);
                this.Close();
            }
            else if (Application.OpenForms["frmPersonelGiris"] != null)
            {
                frmPersonelGiris frm = Application.OpenForms["frmPersonelGiris"] as frmPersonelGiris;
                frm.Ac(secimId);
                Close();

            }
        }
    }
}
