using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CosmeticsApp.Models
{
    public class RisqueModel
    {
        public int ID { get;set; }
        public string NomR { get; set; }

        public virtual ICollection<IngredientModel> Ingredients { get; set; }

    }
}