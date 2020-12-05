using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AspWebApi50.Models {

    [Index(nameof(PartNbr), IsUnique = true)]
    public class Product {

        public int Id { get; set; } = 0;
        [StringLength(30), Required]
        public string PartNbr { get; set; } = string.Empty;
        [StringLength(30), Required]
        public string Name { get; set; } = string.Empty;
        [Column(TypeName = "decimal(12,2)")]
        public decimal Price { get; set; } = 0;
        [StringLength(30), Required]
        public string Unit { get; set; } = "Each";
        public string PhotoPath { get; set; }

        public int VendorId { get; set; } = 0;
        public virtual Vendor Vendor { get; set; } = null;

        public Product() {
        }
    }
}
