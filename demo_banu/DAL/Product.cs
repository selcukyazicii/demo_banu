using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo_banu.DAL
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int PorductPrice { get; set; }
        public int ProductStock { get; set; }
        public bool ProductStatus { get; set; }
    }
}
