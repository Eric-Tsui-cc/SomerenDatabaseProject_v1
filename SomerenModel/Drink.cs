using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Drink
    {
        public string name {  get; set; }
        public decimal price {  get; set; }
        public string type { get; set; }
        public int stock { get; set; }
        public int id { get; set; }
        public Drink(int id,string name,string type,int stock)
        {   
            this.id = id;
            this.name = name;
            this.type = type;
            this.stock = stock;
        }
        public Drink(int id, string name,decimal price, string type, int stock)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.type = type;
            this.stock = stock;
        }
        public Drink() { }

    }
}
