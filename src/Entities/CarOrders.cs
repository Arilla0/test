using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class CarOrders
    {
        public int ID { get; set; }
        public DateTime created { get; set; }
        public int customerId { get; set; }
        public string modelName { get; set; }
        public string trimNane { get; set; }
        public string engine { get; set; }
        public FuelTypes FuelTypes { get; set; }
        public GearTypes GearTypes { get; set; }
        public int Price { get; set; }
        public int bankLoanDuration { get; set; }
        public double bankLoanDownPayment { get; set; }
        public double bankLoanMonthlyPayment { get; set; }
    }
}
