namespace cms.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Links
    {
        [Key]
        public long link_id { get; set; }

        [Required]
        [StringLength(255)]
        public string link_url { get; set; }

        [Required]
        [StringLength(255)]
        public string link_name { get; set; }

        [Required]
        [StringLength(255)]
        public string link_image { get; set; }

        [Required]
        [StringLength(25)]
        public string link_target { get; set; }

        [Required]
        [StringLength(255)]
        public string link_description { get; set; }

        [Required]
        [StringLength(20)]
        public string link_visible { get; set; }

        public long link_owner { get; set; }

        public int link_rating { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime link_updated { get; set; }

        [Required]
        [StringLength(255)]
        public string link_rel { get; set; }

        [Required]
        public string link_notes { get; set; }

        [Required]
        [StringLength(255)]
        public string link_rss { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? created_at { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? updated_at { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? deleted_at { get; set; }
    }
}
