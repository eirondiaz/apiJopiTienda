using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiJopiTienda.Models
{
    public class CartModel
    {
        public int Sku { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Currency { get; set; }
        public int Quantity { get; set; }
    }
}
