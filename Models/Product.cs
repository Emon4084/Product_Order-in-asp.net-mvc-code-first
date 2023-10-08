using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace My_Products.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [StringLength(50, MinimumLength = 1)]
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
    }
}