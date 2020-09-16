namespace cms.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Postmeta
    {
        [Key]
        public long meta_id { get; set; }

        public long post_id { get; set; }

        [StringLength(255)]
        public string meta_key { get; set; }

        public string meta_value { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? created_at { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? updated_at { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? deleted_at { get; set; }
    }
}
