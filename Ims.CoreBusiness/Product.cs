using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ims.CoreBusiness
{
    public class Product
    {
        public int  Id { get; set; }
        
        [Required]
        [StringLength(150)]
        public string Name { get; set; } = string.Empty;

        [Range(0, int.MaxValue, ErrorMessage="Quantity cannot be negative")]
        public int Quantity { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Price cannot be negative")]
        public double Price { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Quantity: {Quantity}, Price: {Price}";
        }
    }
}
