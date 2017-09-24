using System;
using System.Web.Configuration;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WingtipToys.Models
{
    public class Product
    {
        /* This  is the data type of the product in model */

        [ScaffoldColumn(false)]
        public int ProductID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string ProductName { get; set; }

        [Required, StringLength(10000), Display(Name = "Product Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string ImagePath { get; set; }

        [Display(Name = "Price")] public double? UnitPrice { get; set; }

        public int? CategoryID { get; set; }

        //taking the next Category.cs file of the class
        public virtual Category Category { get; set; }
    }
}