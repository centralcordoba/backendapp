using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Products
    {
        public string Id_User { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public int Id_Product { get; set; }
        public int Id_Category_Products { get; set; }
        public int Id_Detail_Product { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }

        public int Count { get; set; }

        public decimal Price_Buy { get; set; }
        public decimal Price_Sale { get; set; }
    }
}
