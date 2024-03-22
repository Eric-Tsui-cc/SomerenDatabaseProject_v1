using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Order
    {
        private int _Amount;
        public Student Student { get; set; }
        public Drink Drink { get; set; }
        public int Amount { get => _Amount; set => _Amount = (value > 0) ? value : throw new Exception("Select 1 or more"); }
        public DateTime OrderDate { get; set; }

        public Order(Student student, Drink drink, int amount, DateTime orderDate)
        {
            Student = student;
            Drink = drink;
            Amount = amount;
            OrderDate = orderDate;
        }
    }
}
