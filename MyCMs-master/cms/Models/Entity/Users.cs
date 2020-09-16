namespace cms.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        public long ID { get; set; }

        [Required]
        [StringLength(60)]
        public string user_login { get; set; }

        [Required]
        [StringLength(255)]
        public string user_pass { get; set; }

        [Required]
        [StringLength(50)]
        public string user_nicename { get; set; }

        [Required]
        [StringLength(100)]
        public string user_email { get; set; }

        [Required]
        [StringLength(100)]
        public string user_url { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime user_registered { get; set; }

        [Required]
        [StringLength(255)]
        public string user_activation_key { get; set; }

        public int user_status { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? created_at { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? updated_at { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? deleted_at { get; set; }

        [Required]
        [StringLength(250)]
        public string display_name { get; set; }
    }
}
