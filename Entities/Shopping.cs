using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Shopping
    {
        public int Id_Trolley { get; set; }
        public string CategoryPets { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ProductDetail { get; set; }
        public decimal Amount { get; set; }
        public string Id_User{ get; set; }
        public string Picture { get; set; }

        public decimal TotalBuys { get; set; }

        public int Id_Method_Pay { get; set; }

    }
}
