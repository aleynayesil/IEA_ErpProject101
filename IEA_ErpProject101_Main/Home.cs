﻿using IEA_ErpProject101_Main.BilgiGirisİslemleri;
using IEA_ErpProject101_Main.BilgiGirisİslemleri.Doktorlar;
using IEA_ErpProject101_Main.BilgiGirisİslemleri.Firma;
using IEA_ErpProject101_Main.BilgiGirisİslemleri.Hastaneler;
using IEA_ErpProject101_Main.BilgiGirisİslemleri.Personeller;
using IEA_ErpProject101_Main.Depoİslemleri.Stokİslemleri;
using IEA_ErpProject101_Main.Entity;
using IEA_ErpProject101_Main.Fonksiyonlar;
using IEA_ErpProject101_Main.Urunİslemleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject101_Main
{
    public partial class Home : Form
    {

        public static tblCariler tblCarileId = null;
        public static tblPersonelDetay tblPersonelDetayId = null;
        Formlar f = new Formlar();


        internal static int Aktarma = -1;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            MenuOlustur();
        }

        private void MenuOlustur()
        {
            #region Bilgi Giriş Menusu

            tvBilgiGirisİslemleri.Nodes.Add("Hastaneler");
            tvBilgiGirisİslemleri.Nodes[0].Nodes.Add("Hastane Bilgi Giriş");
            tvBilgiGirisİslemleri.Nodes[0].Nodes.Add("Hastaneler Listesi");

            tvBilgiGirisİslemleri.Nodes.Add("Doktorlar");
            tvBilgiGirisİslemleri.Nodes[1].Nodes.Add("Doktor Bilgi Giriş");
            tvBilgiGirisİslemleri.Nodes[1].Nodes.Add("Doktorlar Listesi");


            tvBilgiGirisİslemleri.Nodes.Add("Personeller");
            tvBilgiGirisİslemleri.Nodes[2].Nodes.Add("Personel Bilgi Giriş");
            tvBilgiGirisİslemleri.Nodes[2].Nodes.Add("Personeller Listesi");

            tvBilgiGirisİslemleri.Nodes.Add("Firmalar");
            tvBilgiGirisİslemleri.Nodes[3].Nodes.Add("Firma Bilgi Giriş");
            tvBilgiGirisİslemleri.Nodes[3].Nodes.Add("Firmalar Listesi");
            #endregion

            #region Depo İşlemleri Menusu
            tvDepoİslemleri.Nodes.Add("Depo İşlemleri");
            tvDepoİslemleri.Nodes[0].Nodes.Add("Depo Stok Durum");
            tvDepoİslemleri.Nodes[0].Nodes.Add("Depo Stok Giriş");
            tvDepoİslemleri.Nodes[0].Nodes[1].Nodes.Add("Stok Giriş");
            tvDepoİslemleri.Nodes[0].Nodes[1].Nodes.Add("Stok Listesi");
            tvDepoİslemleri.Nodes[0].Nodes.Add("Depo Sevkiyat Listesi");
            #endregion

            #region Urun İslemleri
            tvUrunİslemleri.Nodes.Add("Ürün İşlemleri");
            tvUrunİslemleri.Nodes[0].Nodes.Add("Ürün Giriş");
            tvUrunİslemleri.Nodes[0].Nodes.Add("Ürünler Listesi"); 
            #endregion
        }

        private void TvGorunum()
        {
            tvBilgiGirisİslemleri.Visible = false;
            tvDepoİslemleri.Visible = false;
            tvUrunİslemleri.Visible = false;
            tv4.Visible = false;
            tv5.Visible = false;
            tv6.Visible = false;
            tv7.Visible = false;
            tv8.Visible = false;
            tv9.Visible = false;
            tv10.Visible = false;
            tv11.Visible = false;
            tv12.Visible = false;
        }

        private void btnBilgiGiris_Click(object sender, EventArgs e)
        {
            lblBilgiEkrani.Text = btnBilgiGiris.Text;
            TvGorunum();
            tvBilgiGirisİslemleri.Visible = true;

        }
        private void btnDepoİslemleri_Click(object sender, EventArgs e)
        {
            lblBilgiEkrani.Text = btnDepoİslemleri.Text;
            TvGorunum();
            tvDepoİslemleri.Visible = true;
        }
        private void btnUrunİslemleri_Click(object sender, EventArgs e)
        {
            lblBilgiEkrani.Text = btnUrunİslemleri.Text;
            TvGorunum();
            tvUrunİslemleri.Visible = true;
        }
        public static bool kontrol = false;
        private void tvBilgiGirisİslemleri_DoubleClick(object sender, EventArgs e)
        {
            //string isim = "";
            //if (tvBilgiGirisİslemleri.SelectedNode!=null)
            //{
            //    isim = tvBilgiGirisİslemleri.SelectedNode.Text;
            //}
            string isim = tvBilgiGirisİslemleri.SelectedNode != null ? tvBilgiGirisİslemleri.SelectedNode.Text : "";
            //MessageBox.Show(isim);

            if (isim== "Hastaneler Listesi" && Application.OpenForms["frmHastanelerListesi"] as frmHastanelerListesi==null)
            {
                f.HastaneListesi();
                //frmHastanelerListesi frm = new frmHastanelerListesi();
                //frm.MdiParent = Form.ActiveForm;
                //frm.Show();
               // kontrol = true;
            }else if (isim == "Hastane Bilgi Giriş" && Application.OpenForms["frmHastaneGiris"] as frmHastaneGiris == null)
            {
                frmHastaneGiris frm = new frmHastaneGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
                //kontrol = true;

            }else if (isim == "Doktor Bilgi Giriş" && Application.OpenForms["frmDoktorGiris"] == null)
            {
                frmDoktorGiris frm = new frmDoktorGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim == "Doktorlar Listesi" && Application.OpenForms["frmDoktorlarListesi"] == null)
            {
                f.DoktorlarListesi();
                //frmDoktorlarListesi frm = new frmDoktorlarListesi();
                //frm.MdiParent = Form.ActiveForm;
                //frm.Show();
            }
            else if (isim == "Personel Bilgi Giriş" && Application.OpenForms["frmPersonelGiris"] == null)
            {
                frmPersonelGiris frm = new frmPersonelGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim == "Personeller Listesi" && Application.OpenForms["frmPersonellerListesi"] == null)
            {
                frmPersonellerListesi frm = new frmPersonellerListesi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim == "Firma Bilgi Giriş" && Application.OpenForms["frmFirmaGiris"] == null)
            {
                frmFirmaGiris frm = new frmFirmaGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim == "Firmalar Listesi" && Application.OpenForms["frmFirmalarListesi"] == null)
            {
                frmFirmalarListesi frm = new frmFirmalarListesi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
        }

        private void tvUrunİslemleri_DoubleClick(object sender, EventArgs e)
        {
            string isim = tvUrunİslemleri.SelectedNode != null ? tvUrunİslemleri.SelectedNode.Text : "";

             if (isim == "Ürün Giriş" && Application.OpenForms["frmUrunGiris"] == null)
            {
                frmUrunGiris frm = new frmUrunGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim == "Ürünler Listesi" && Application.OpenForms["frmUrunlerListesi"] == null)
            {
                frmUrunlerListesi frm = new frmUrunlerListesi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
                frm.Activate();
            }
        }

        private void tvDepoİslemleri_DoubleClick(object sender, EventArgs e)
        {
            string isim = tvDepoİslemleri.SelectedNode != null ? tvDepoİslemleri.SelectedNode.Text : "";

            if (isim == "Stok Giriş" && Application.OpenForms["frmStokGiris"] == null)
            {
                frmStokGiris frm = new frmStokGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
                frm.Activate();
            }
            else if (isim == "Stok Listesi" && Application.OpenForms["frmStokGirisListe"] == null)
            {
                frmStokGirisListe frm = new frmStokGirisListe();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
               
            }
        }
    }
}
