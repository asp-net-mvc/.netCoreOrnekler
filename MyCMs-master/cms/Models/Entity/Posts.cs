namespace cms.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Posts
    {
        public long ID { get; set; }

    
        [Display(Name = "Post Yazarý ")]
        public long post_author { get; set; }

        [Column(TypeName = "datetime2")]
        [Display(Name = "Post Tarihi ")]
        public DateTime post_date { get; set; }

    
        [Display(Name = "Post Tarihi gmt")]
        [Column(TypeName = "datetime2")]
        public DateTime post_date_gmt { get; set; }

        [Required(ErrorMessage = "Gerekli...")]
        [Display(Name = "Içerik")]
        public string post_content { get; set; }

        [Required(ErrorMessage = "Gerekli...")]
        [Display(Name = "Baþlýk")]
        public string post_title { get; set; }

        [Required(ErrorMessage = "Gerekli...")]
        [Display(Name = "Kýsa Özet")]
        public string post_excerpt { get; set; }

        [Required(ErrorMessage = "Gerekli...")]
        [Display(Name = "Durumu")]
        [StringLength(20)]
        public string post_status { get; set; }

        [Required(ErrorMessage = "Gerekli...")]
        [Display(Name = "Yoruma açýk kapalý")]
        [StringLength(20)]
        public string comment_status { get; set; }


        [StringLength(255)]
        [Required(ErrorMessage = "Gerekli...")]
        [Display(Name = "Ýçerik Þifresi")]
        public string post_password { get; set; }


        [StringLength(200)]
        [Required(ErrorMessage = "Gerekli...")]
        [Display(Name = "Linki")]
        public string post_slug { get; set; }



     
        [Required(ErrorMessage = "Gerekli...")]
        [Display(Name = "Menu Sýrasý")]
        public int menu_order { get; set; }


        [StringLength(20)]
        [Required(ErrorMessage = "Gerekli...")]
        [Display(Name = "Postun Türü")]
        public string post_type { get; set; }


        [StringLength(100)]
        [Required(ErrorMessage = "Gerekli...")]
        [Display(Name = "Mime Türü")]
        public string post_mime_type { get; set; }

        [Required(ErrorMessage = "Gerekli...")]
        [Display(Name = "Yorum sayýsý")]
        public long comment_count { get; set; }

        [Required(ErrorMessage = "Gerekli...")]
        [Display(Name = "OLuþturulma tarihi")]
        [Column(TypeName = "datetime2")]
        public DateTime? created_at { get; set; }

        [Column(TypeName = "datetime2")]
        [Required(ErrorMessage = "Gerekli...")]
        [Display(Name = "Güncellenme tarihi")]
        public DateTime? updated_at { get; set; }

        [Required(ErrorMessage = "Gerekli...")]
        [Display(Name = "Soft delete")]
        [Column(TypeName = "datetime2")]
        public DateTime? deleted_at { get; set; }
    }
}
