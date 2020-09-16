namespace cms.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Comments
    {
        [Key]
        public long comment_ID { get; set; }

        public long comment_post_ID { get; set; }

        [Required]
        [StringLength(255)]
        public string comment_author { get; set; }

        [Required]
        [StringLength(100)]
        public string comment_author_email { get; set; }

        [Required]
        [StringLength(200)]
        public string comment_author_url { get; set; }

        [Required]
        [StringLength(100)]
        public string comment_author_IP { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime comment_date { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime comment_date_gmt { get; set; }

        [Required]
        public string comment_content { get; set; }


        [Required]
        [StringLength(20)]
        public string comment_approved { get; set; }

        [Required]
        [StringLength(255)]
        public string comment_agent { get; set; }

        [Required]
        [StringLength(20)]
        public string comment_type { get; set; }

        public long comment_parent { get; set; }

        public long user_id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? created_at { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? updated_at { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? deleted_at { get; set; }
    }
}
