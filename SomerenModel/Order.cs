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
        public TimeSpan OrderTime { get; set; }

        public Order(Drink drink, int amount, DateTime orderDate)
        {
            Drink = drink;
            Amount = amount;
            OrderDate = orderDate;
        }
        public Order(Student student, Drink drink, int amount, DateTime orderDate, TimeSpan orderTime)
        {
            Student = student;
            Drink = drink;
            Amount = amount;
            OrderDate = orderDate;
            OrderTime = orderTime;
        }
    }
}
