using System;
using System.Collections.Generic;
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

        public string GetText (int _text)
        { return (Convert.ToString(_text)); }
        public int SetText (string _text)
        {
            if (Char.IsNumber(_text, 0))
            { return (Convert.ToInt32(_text)); }
            else
            { return 0; }
        }

        public Model( string name, string Sposev, string Subr, string ALLmoney,string moneyTR, string moneySemena, string moneySemenaElit, string moneyUdobMin, string moneyUdobOrg, string moneySave,string moneyElecticity, string moneyOIL, string moneyStrahovka, string moneyOsnov,string Product, string Price, string VolumeProd, string AllVolumePrice)
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
        }
    }
}
