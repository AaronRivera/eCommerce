using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; 

namespace eCommerce.Models
{
    public class ProductDataContext: DbContext
    {
        //Add the "tables"
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }

        //Create a constructor.  The name=ProductDatabase bit points to the ProductDatabase connection string in the Web.Config
        public ProductDataContext()
            : base("name=DefaultConnection")
        {

        }
    }
}