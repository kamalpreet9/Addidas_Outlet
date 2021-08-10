using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Addidas_Outlet.Models
{
    public class Categories
    {
        public int id { get; set; } // category Id
        [Required]
        public string Category_Name { get; set; } // categpry name like Mens , womens . kids 

    }
}
