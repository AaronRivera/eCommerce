using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Models
{
    public class ProductImage
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductImageId { get; set; }
        public int ProductId { get; set; }
        public string ImageUrl { get; set; }
        public ProductImage()
        {

        }

        public ProductImage(int productImageId, int productId, string imageUrl)
        {
            this.ProductImageId = productImageId;
            this.ProductId = productId;
            this.ImageUrl = imageUrl;
        }
    }
}