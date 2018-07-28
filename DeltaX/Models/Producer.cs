namespace DeltaX.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Producer
    {
        public int ProducerId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(1)]
        public string Sex { get; set; }

        [Column(TypeName = "date")]
        public DateTime DOB { get; set; }

        public string Bio { get; set; }

        public bool Active { get; set; }

        public DateTime CreatedDt { get; set; }

        public int CreatedBy { get; set; }

        public DateTime? UpdatedDt { get; set; }

        public int? UpdatedBy { get; set; }
    }
}
