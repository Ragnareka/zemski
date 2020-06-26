using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace WpfApplication1
{
    class Model
    {
        public string name { get; set; }
        public int Sposev { get; set; }
        public int Subr { get; set; }
        public int ALLmoney { get; set; }
        public int moneyTR { get; set; }
        public int moneySemena { get; set; }
        public int moneySemenaElit { get; set; }
        public int moneyUdobMin { get; set; }
        public int moneyUdobOrg { get; set; }
        public int moneySave { get; set; }
        public int moneyElecticity { get; set; }
        public int moneyOIL { get; set; }
        public int moneyStrahovka { get; set; }
        public int moneyOsnov { get; set; }
        public int Product { get; set; }
        public int Price { get; set; }
        public int VolumeProd { get; set; }
        public int AllVolumePrice { get; set; }
        public int Realize { get; set; }


        public int SetText(string _text)
        {
            if (Char.IsNumber(_text, 0))
            { return (Convert.ToInt32(_text)); }
            else
            { return 0; }
        }



        public Model(string name, string Sposev, string Subr, string ALLmoney, string moneyTR, string moneySemena, string moneySemenaElit, string moneyUdobMin, string moneyUdobOrg, string moneySave, string moneyElecticity, string moneyOIL, string moneyStrahovka, string moneyOsnov, string Product, string Price, string Realize, string VolumeProd, string AllVolumePrice)
        {
            this.name = name;
            this.Sposev = SetText(Sposev);
            this.Subr = SetText(Subr);
            this.ALLmoney = SetText(ALLmoney);
            this.moneyTR = SetText(moneyTR);
            this.moneySemena = SetText(moneySemena);
            this.moneySemenaElit = SetText(moneySemenaElit);
            this.moneyUdobMin = SetText(moneyUdobMin);
            this.moneyUdobOrg = SetText(moneyUdobOrg);
            this.moneySave = SetText(moneySave);
            this.moneyElecticity = SetText(moneyElecticity);
            this.moneyOIL = SetText(moneyOIL);
            this.moneyStrahovka = SetText(moneyStrahovka);
            this.moneyOsnov = SetText(moneyOsnov);
            this.Product = SetText(Product);
            this.Price = SetText(Price);
            this.VolumeProd = SetText(VolumeProd);
            this.AllVolumePrice = SetText(AllVolumePrice);
            this.Realize = SetText(Realize);
        }
        public Model(string name, int Sposev, int Subr, int ALLmoney, int moneyTR, int moneySemena, int moneySemenaElit, int moneyUdobMin, int moneyUdobOrg, int moneySave, int moneyElecticity, int moneyOIL, int moneyStrahovka, int moneyOsnov, int Product, int Price, int Realize, int VolumeProd, int AllVolumePrice)
        {
            this.name = name;
            this.Sposev = Sposev;
            this.Subr = Subr;
            this.ALLmoney = ALLmoney;
            this.moneyTR = moneyTR;
            this.moneySemena = moneySemena;
            this.moneySemenaElit = moneySemenaElit;
            this.moneyUdobMin = moneyUdobMin;
            this.moneyUdobOrg = moneyUdobOrg;
            this.moneySave = moneySave;
            this.moneyElecticity = moneyElecticity;
            this.moneyOIL = moneyOIL;
            this.moneyStrahovka = moneyStrahovka;
            this.moneyOsnov = moneyOsnov;
            this.Product = Product;
            this.Price = Price;
            this.VolumeProd = VolumeProd;
            this.AllVolumePrice = AllVolumePrice;
            this.Realize = Realize;
        }

        public static BindingList<Model> GetDataTableRow(DataTable result)
        {
            BindingList<Model> lstModel = new BindingList<Model>();
            foreach (DataRow rows in result.Rows)
            {
                string name = Convert.ToString(rows[0]);
                string Sposev = Convert.ToString(rows[1]);
                string Subr = Convert.ToString(rows[2]);
                string ALLmoney = Convert.ToString(rows[3]);
                string moneyTR = Convert.ToString(rows[4]);
                string moneySemena = Convert.ToString(rows[5]);
                string moneySemenaElit = Convert.ToString(rows[6]);
                string moneyUdobMin = Convert.ToString(rows[7]);
                string moneyUdobOrg = Convert.ToString(rows[8]);
                string moneySave = Convert.ToString(rows[9]);
                string moneyElecticity = Convert.ToString(rows[10]);
                string moneyOIL = Convert.ToString(rows[11]);
                string moneyStrahovka = Convert.ToString(rows[12]);
                string moneyOsnov = Convert.ToString(rows[13]);
                string Product = Convert.ToString(rows[14]);
                string Price = Convert.ToString(rows[15]);
                string VolumeProd = Convert.ToString(rows[16]);
                string AllVolumePrice = Convert.ToString(rows[17]);
                string Realize = Convert.ToString(rows[18]);

                lstModel.Add(new Model(name, Sposev, Subr, ALLmoney, moneyTR, moneySemena, moneySemenaElit, moneyUdobMin, moneyUdobOrg, moneySave, moneyElecticity, moneyOIL, moneyStrahovka, moneyOsnov, Product, Price, Realize, VolumeProd, AllVolumePrice));

            }
            ModelALL(lstModel);
            return lstModel;
        }
    
        public static void ModelALL(BindingList<Model> lstModel)
        {
            int volume = lstModel.Count;
            string name = "ВСЕГО";
            int Sposev1 = 0;
            int Subr1 = 0;
            int ALLmoney1 = 0;
            int moneyTR1 = 0;
            int moneySemen1a = 0;
            int moneySemenaEli1t = 0;
            int moneyUdobMi1n = 0;
            int moneyUdobOr1g = 0;
            int moneySav1e = 0;
            int moneyElectici1ty = 0;
            int moneyOIL1 = 0;
            int moneyStrahovka1 = 0;
            int moneyOsnov1 = 0;
            int Product1 = 0;
            int Price1 = 0;
            int VolumeProd1 = 0;
            int AllVolumePrice1 = 0;
            int Realize1 = 0;
            for (int i = 0; i < volume; i++)
            {
                Sposev1 = Sposev1 + lstModel[i].Sposev;
                Subr1 = Subr1 + lstModel[i].Subr;
                ALLmoney1 = ALLmoney1 + lstModel[i].ALLmoney;
                moneyTR1 = moneyTR1 + lstModel[i].moneyTR;
                moneySemen1a = moneySemen1a + lstModel[i].moneySemena;
                moneySemenaEli1t = moneySemenaEli1t + lstModel[i].moneySemenaElit;
                moneyUdobMi1n = moneyUdobMi1n + lstModel[i].moneyUdobMin;
                moneyUdobOr1g = moneyUdobOr1g + +lstModel[i].moneyUdobOrg;
                moneySav1e = moneySav1e + lstModel[i].moneySave;
                moneyElectici1ty = moneyElectici1ty + lstModel[i].moneyElecticity;
                moneyOIL1 = moneyOIL1 + lstModel[i].moneyOIL;
                moneyStrahovka1 = moneyStrahovka1 + lstModel[i].moneyStrahovka;
                moneyOsnov1 = moneyOsnov1 + lstModel[i].moneyOsnov;
                Product1 = Product1 + lstModel[i].Product;
                Price1 = Price1 + lstModel[i].Price;
                VolumeProd1 = VolumeProd1 + lstModel[i].VolumeProd;
                AllVolumePrice1 = AllVolumePrice1 + lstModel[i].AllVolumePrice;
                Realize1 = Realize1 + lstModel[i].Realize;
            }
            lstModel.Add(new Model(name, Sposev1, Subr1, ALLmoney1, moneyTR1, moneySemen1a, moneySemenaEli1t, moneyUdobMi1n, moneyUdobOr1g, moneySav1e, moneyElectici1ty, moneyOIL1, moneyStrahovka1, moneyOsnov1, Product1, Price1, Realize1, VolumeProd1, AllVolumePrice1));




        }
    
    }
}
