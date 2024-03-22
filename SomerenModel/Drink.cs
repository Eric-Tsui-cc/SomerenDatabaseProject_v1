using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SomerenModel
{
    public class Drink
    {
        
        public int DrinkId { get; set; }
        public string name {  get; set; }
        public decimal price {  get; set; }
        public string type { get; set; }
        public int Stock { get; set; }
        public int Vat { get; set; }

        public string StockToText { get => Stock == 0 ? "stock empty" : Stock < 50 ? "stock nearly depleted" : "stock sufficient"; }
        public string Alcohol { get => (Vat == 21) ? "alcoholic" : "non-alcoholic"; }

        public override string ToString()
        {
            return $"{name}/    {price}/    {Stock}/    {Alcohol}";
        }

    }

}
