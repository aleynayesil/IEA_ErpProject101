﻿using IEA_ErpProject101_Main.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEA_ErpProject101_Main.Fonksiyonlar
{
    class Numaralar
    {
        private readonly ErpProjectWMPEntities erp = new ErpProjectWMPEntities();
        #region Cariİslemler
        public string CariKoduHastane()
        {
            try
            {
                var numara = (from s in erp.tblCariler orderby s.Id descending select s).First().Id;
                numara++;
                string num = "H" + numara.ToString().PadLeft(8, '0');
                return num;
            }
            catch (Exception e)
            {
                return "00000001";
            }
        }
        public string CariKoduDoktor()
        {
            try
            {
                var numara = (from s in erp.tblCariler orderby s.Id descending select s).First().Id;
                numara++;
                string num = "D" + numara.ToString().PadLeft(8, '0');
                return num;
            }
            catch (Exception e)
            {
                return "00000001";
            }
        }
        public string CariKoduPersonel()
        {
            try
            {
                var numara = (from s in erp.tblCariler orderby s.Id descending select s).First().Id;
                numara++;
                string num = "P" + numara.ToString().PadLeft(8, '0');
                return num;
            }
            catch (Exception e)
            {
                return "00000001";
            }
        }

        public string CariKoduFirma()
        {
            try
            {
                var numara = (from s in erp.tblCariler orderby s.Id descending select s).First().Id;
                numara++;
                string num = "F" + numara.ToString().PadLeft(8, '0');
                return num;
            }
            catch (Exception e)
            {
                return "00000001";
            }
        }
        #endregion


        public string UrunGenelKodu()
        {
            try
            {
                var numara = (from s in erp.tblUrunler orderby s.Id descending select s).First().Id;
                numara++;
                string num = "U" + numara.ToString().PadLeft(8, '0');
                return num;
            }
            catch (Exception e)
            {
                return "U00000001";
            }
        }

        public string StokGirisGenelKodu()
        {
            try
            {
                var numara = (from s in erp.tblStokGirisUst orderby s.Id descending select s).First().Id;
                numara++;
                string num = numara.ToString().PadLeft(8, '0');
                return num;
            }
            catch (Exception e)
            {
                return "00000001";
            }
        }
    }
}
