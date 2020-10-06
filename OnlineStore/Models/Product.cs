using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace OnlineStore.Models
{
    public class Product
    {
        public long ProductID { get; set; }

        [Required(ErrorMessage = "Please enter a product name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a description")]
        public string Description { get; set; }

        [Required]
        [Range(0.01, double.MaxValue,
            ErrorMessage = "Please enter a positive price")]
        [Column(TypeName = "decimal(8, 2)")]
        [DisplayFormat(DataFormatString="{0:C}")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "PLease specify a category")]
        public string Category { get; set; }
    }
}
