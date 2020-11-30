using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace AspWebApi50.Models {

    [Index(nameof(Code), IsUnique = true)]
    public class Vendor {

        public int Id { get; set; } = default;
        [StringLength(30)]
        [Required]
        public string Code { get; set; } = default;
        [StringLength(30)]
        [Required]
        public string Name { get; set; } = default;
        [StringLength(30)]
        [Required]
        public string Address { get; set; } = default;
        [StringLength(30)]
        [Required]
        public string City { get; set; } = default;
        [StringLength(2)]
        [Required]
        public string State { get; set; } = default;
        [StringLength(5)]
        [Required]
        public string Zip { get; set; } = default;
        [StringLength(12)]
        public string Phone { get; set; } = default;
        [StringLength(80)]
        public string Email { get; set; } = default;

        public Vendor() {
        }
    }
}
