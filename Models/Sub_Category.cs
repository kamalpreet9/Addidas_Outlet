using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Addidas_Outlet.Models
{
    public class Sub_Category // sub category class
    {
        public int id { get; set; }// id 

    
        [Required]
        public string Sub_Categories{ get; set; } // sub category like shoes , shirts , trackpants
       
    }
}
