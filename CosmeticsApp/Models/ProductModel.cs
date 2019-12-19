using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CosmeticsApp.Models
{
    public class ProductModel
    {
        public int ID { get; set; }

        [Required (ErrorMessage="name of product is required")]
        public string Product_name { get; set; }


        public string Certification { get; set; }

        public Boolean Stock { get; set; }

        public int Quantité { get; set; }

        public virtual ICollection<IngredientModel> Ingredients { get; set; }
        public virtual ICollection<CategoryModel> Categories { get; set; }
    }
}