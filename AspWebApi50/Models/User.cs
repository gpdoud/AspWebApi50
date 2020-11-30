using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace AspWebApi50.Models {

    [Index(nameof(Username), IsUnique = true)]
    public class User {

        public int Id { get; set; } = 0;
        [StringLength(30)]
        [Required]
        public string Username { get; set; } = string.Empty;
        [StringLength(30)]
        [Required]
        public string Password { get; set; } = "Train@MAX";
        [StringLength(30)]
        [Required]
        public string Firstname { get; set; } = string.Empty;
        [StringLength(30)]
        [Required]
        public string Lastname { get; set; } = string.Empty;
        [StringLength(12)]
        public string Phone { get; set; } = null;
        [StringLength(80)]
        public string Email { get; set; } = null;
        public bool IsReviewer { get; set; } = false;
        public bool IsAdmin { get; set; } = false;

        public User() { }

    }
}
