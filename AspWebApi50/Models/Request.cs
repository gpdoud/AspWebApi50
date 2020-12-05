using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspWebApi50.Models {

    public class Request {

        public int Id { get; set; } = 0;
        [StringLength(80), Required]
        public string Description { get; set; } = string.Empty;
        [StringLength(80), Required]
        public string Justification { get; set; } = string.Empty;
        [StringLength(80)]
        public string RejectionReason { get; set; } = null;
        [StringLength(30), Required]
        public string DeliveryMode { get; set; } = "Pickup";
        [StringLength(30), Required]
        public string Status { get; set; } = StatusValues.New;
        [Column(TypeName = "decimal(12,2)")]
        public decimal Total { get; set; } = 0;

        public int UserId { get; set; } = 0;
        public virtual User User { get; set; } = null;

        public Request() {
        }
    }

    public static class StatusValues {
        public static string New = "NEW";
        public static string Edit = "EDIT";
        public static string Review = "REVIEW";
        public static string Approved = "APPROVED";
        public static string Rejected = "REJECTED";
    }
}
