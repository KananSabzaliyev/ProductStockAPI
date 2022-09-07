using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductStockFinder.Entities
{
    public class ProductStock
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductStockId { get; set; }
        [Required]
        public int ProductStockCount { get; set; }
    }
}
