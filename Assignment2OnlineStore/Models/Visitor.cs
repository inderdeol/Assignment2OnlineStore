namespace Assignment2OnlineStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Visitor
    {
        public int VisitorId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string Purpose { get; set; }

        public string Interest { get; set; }

        public int RateWeb { get; set; }
    }
}
