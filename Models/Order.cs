using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Addidas_Outlet.Models
{
    public class Order // place order class 
    { 
        public int id { get; set; } // order id 
        public Categories Categories { get; set; } // categories of product
        public int CategoriesID { get; set; }
        public Sub_Category Sub_Category { get; set; } // subcategory of product
        public int Sub_CategoryID { get; set; }

        public Product Product { get; set; }  // product name 
        public int ProductID { get; set; }
       
        public  int QantityID { get; set; } // quantity 



    }
}
