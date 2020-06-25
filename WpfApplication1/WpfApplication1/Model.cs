using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace WpfApplication1
{
    class Model
    {
        public string name;
        public int Sposev;
        public int Subr;
        public int ALLmoney;
        public int moneyTR;
        public int moneySemena;
        public int moneySemenaElit;
        public int moneyUdobMin;
        public int moneyUdobOrg;
        public int moneySave;
        public int moneyElecticity;
        public int moneyOIL;
        public int moneyStrahovka;
        public int moneyOsnov;
        public int Product;
        public int Price;
        public int VolumeProd;
        public int AllVolumePrice;
        public int Realize;

        public string GetText (int _text)
        { return (Convert.ToString(_text)); }
        public int SetText (string _text)
        {
            if (Char.IsNumber(_text, 0))
            { return (Convert.ToInt32(_text)); }
            else
            { return 0; }
        }

        public Model( string name, string Sposev, string Subr, string ALLmoney,string moneyTR, string moneySemena, string moneySemenaElit, string moneyUdobMin, string moneyUdobOrg, string moneySave,string moneyElecticity, string moneyOIL, string moneyStrahovka, string moneyOsnov,string Product, string Price, string Realize,string VolumeProd, string AllVolumePrice)
        {  this.name = name;
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

        public static List<Model> GetDataTableRow(DataTable result)
        {
            List<Model> lstModel = new List<Model>();
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

                lstModel.Add(new Model(  name,   Sposev,   Subr,   ALLmoney,   moneyTR,   moneySemena,   moneySemenaElit,   moneyUdobMin,   moneyUdobOrg,   moneySave,   moneyElecticity,   moneyOIL,   moneyStrahovka,   moneyOsnov,   Product,   Price,   Realize,   VolumeProd,  AllVolumePrice));
                
            }
            return lstModel;
        }

    }
}
