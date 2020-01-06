using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CosmeticsApp.Models
{
    public class Allergie
    {
        public int ID { get; set; }
        public string NameAllergie { get; set; }
        
        public string Warning { get; set; }
    }
}