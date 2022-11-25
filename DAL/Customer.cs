namespace DAL
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string CustomerName { get; set; }

        public int? CustomerAge { get; set; }

        public int? ProductId { get; set; }

        [JsonIgnore]
        public virtual Product Product { get; set; }
    }
}
