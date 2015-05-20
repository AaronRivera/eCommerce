using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace eCommerce.Models
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal MSRP { get; set; }

        public virtual HashSet<ProductImage> ProductImages { get; set; }

        public Product()
        {
            this.ProductImages = new HashSet<ProductImage>();
        }

        public Product(int productId, string name, string desc, decimal price)
            : base()
        {
            this.ProductId = productId;
            this.Name = name;
            this.Description = desc;
            this.Price = price;
        }
    }
}