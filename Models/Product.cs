using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Addidas_Outlet.Models
{
    public class Product // product class 
    { 
        public int id { get; set; } // id 
        [Required]
        public string Product_Name { get; set; } // product name 
        public decimal Price { get; set; } // price
    }
}
