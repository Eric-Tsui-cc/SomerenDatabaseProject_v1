using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class RevenueReport 
    {
        public int Sales { get; set; }
        public decimal Turnover { get; set; }
        public int CustomerCount { get; set; }
        public string DrinkName {  get; set; }

        public RevenueReport(int sales, decimal turnover, int customerCount)
        {
            Sales = sales;
            Turnover = turnover;
            CustomerCount = customerCount;
        }
    }
}
