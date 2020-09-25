using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class ShoppingPay
    {
        public int Id_Trolley { get; set; }        
        public string Id_User { get; set; }
        public int Id_State { get; set; }
        public int Id_Method_Pay { get; set; }
        public string AddressClient { get; set; }
        public string Telephone { get; set; }
        public string Neighborhood { get; set; }

    }
}
