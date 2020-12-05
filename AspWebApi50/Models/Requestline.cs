using System;
using System.Text.Json.Serialization;

namespace AspWebApi50.Models {

    public class Requestline {

        public int Id { get; set; } = 0;
        public int Quantity { get; set; } = 0;

        public int ProductId { get; set; } = 0;
        public virtual Product Product { get; set; } = null;

        public int RequestId { get; set; } = 0;
        [JsonIgnore]
        public virtual Request Request { get; set; } = null;

        public Requestline() {}
    }
}
