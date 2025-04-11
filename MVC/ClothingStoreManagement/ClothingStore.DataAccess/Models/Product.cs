using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothingStore.Domain.Enums;

namespace ClothingStore.DataAccess.Models
{
   public class Product : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal? DiscountPrice { get; set; }
        [MaxLength(100)]
        public string BrandName { get; set; } = null!;
        public ProductSize Size { get; set; }
        public ProductColors Colors { get; set; }
        public float Rating { get; set; } = 0;   
        public int StockQuantity { get; set; }
        public bool IsAvailable { get; set; }
        public string ImageUrl { get; set; } = null!;
        public ProductType ProductTypes { get; set; }
        public DiscountStatus  DiscountStatu { get; set; }
        public ProductStatus ProductStatu { get; set; }
        public Gender Genders { get; set; }
    }
}
