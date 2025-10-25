using System;
using System.Collections.Generic;
using System.Text;

namespace Ims.CoreBusiness
{
    public class Inventory
    {
        public int  Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
