namespace cms.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Options
    {
        [Key]
        public long option_id { get; set; }

        [Required]
        [StringLength(191)]
        public string option_name { get; set; }

        [Required]
        public string option_value { get; set; }

        [Required]
        [StringLength(20)]
        public string autoload { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? created_at { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? updated_at { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? deleted_at { get; set; }
    }
}
