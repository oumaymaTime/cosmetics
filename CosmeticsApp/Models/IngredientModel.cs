using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CosmeticsApp.Models
{
    public class IngredientModel
    {
        public int IngID { get; set; }

        public string NameIng { get; set; }

        public string DefIng { get; set; }

        public Boolean paraben { get; set; }

        public string safety_rules { get; set; } 


    }
}