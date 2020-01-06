using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CosmeticsApp.Models
{

    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class CosmeticsAppContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
         
        public CosmeticsAppContext() : base("name=CosmeticsAppContext")
        {
        }

        public System.Data.Entity.DbSet<CosmeticsApp.Models.ProductModel> ProductModels { get; set; }

        public System.Data.Entity.DbSet<CosmeticsApp.Models.CategoryModel> CategoryModels { get; set; }

        public System.Data.Entity.DbSet<CosmeticsApp.Models.Allergie> Allergies { get; set; }

        public System.Data.Entity.DbSet<CosmeticsApp.Models.IngredientModel> IngredientModels { get; set; }

        public System.Data.Entity.DbSet<CosmeticsApp.Models.RisqueModel> RisqueModels { get; set; }
    }
}
