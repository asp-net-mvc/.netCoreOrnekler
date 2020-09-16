namespace cms.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelContext : DbContext
    {
        public ModelContext()
            : base("name=eucmsModel")
        {
        }

        public virtual DbSet<Admin> AdminsEntity { get; set; }
        public virtual DbSet<Comments> CommentsEntity { get; set; }
        public virtual DbSet<Links> LinksEntity { get; set; }
        public virtual DbSet<Options> OptionEntitys { get; set; }
        public virtual DbSet<Postmeta> PostmetEntitya { get; set; }
        public virtual DbSet<Posts> PostsEntity { get; set; }
        public virtual DbSet<Users> UsersEntity { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.remember_token)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.created_at)
                .HasPrecision(0);

            modelBuilder.Entity<Admin>()
                .Property(e => e.updated_at)
                .HasPrecision(0);

            modelBuilder.Entity<Admin>()
                .Property(e => e.deleted_at)
                .HasPrecision(0);

            modelBuilder.Entity<Comments>()
                .Property(e => e.comment_author)
                .IsUnicode(false);

            modelBuilder.Entity<Comments>()
                .Property(e => e.comment_author_email)
                .IsUnicode(false);

            modelBuilder.Entity<Comments>()
                .Property(e => e.comment_author_url)
                .IsUnicode(false);

            modelBuilder.Entity<Comments>()
                .Property(e => e.comment_author_IP)
                .IsUnicode(false);

            modelBuilder.Entity<Comments>()
                .Property(e => e.comment_date)
                .HasPrecision(0);

            modelBuilder.Entity<Comments>()
                .Property(e => e.comment_date_gmt)
                .HasPrecision(0);

            modelBuilder.Entity<Comments>()
                .Property(e => e.comment_content)
                .IsUnicode(false);

            modelBuilder.Entity<Comments>()
                .Property(e => e.comment_approved)
                .IsUnicode(false);

            modelBuilder.Entity<Comments>()
                .Property(e => e.comment_agent)
                .IsUnicode(false);

            modelBuilder.Entity<Comments>()
                .Property(e => e.comment_type)
                .IsUnicode(false);

            modelBuilder.Entity<Comments>()
                .Property(e => e.created_at)
                .HasPrecision(0);

            modelBuilder.Entity<Comments>()
                .Property(e => e.updated_at)
                .HasPrecision(0);

            modelBuilder.Entity<Comments>()
                .Property(e => e.deleted_at)
                .HasPrecision(0);

            modelBuilder.Entity<Links>()
                .Property(e => e.link_url)
                .IsUnicode(false);

            modelBuilder.Entity<Links>()
                .Property(e => e.link_name)
                .IsUnicode(false);

            modelBuilder.Entity<Links>()
                .Property(e => e.link_image)
                .IsUnicode(false);

            modelBuilder.Entity<Links>()
                .Property(e => e.link_target)
                .IsUnicode(false);

            modelBuilder.Entity<Links>()
                .Property(e => e.link_description)
                .IsUnicode(false);

            modelBuilder.Entity<Links>()
                .Property(e => e.link_visible)
                .IsUnicode(false);

            modelBuilder.Entity<Links>()
                .Property(e => e.link_updated)
                .HasPrecision(0);

            modelBuilder.Entity<Links>()
                .Property(e => e.link_rel)
                .IsUnicode(false);

            modelBuilder.Entity<Links>()
                .Property(e => e.link_notes)
                .IsUnicode(false);

            modelBuilder.Entity<Links>()
                .Property(e => e.link_rss)
                .IsUnicode(false);

            modelBuilder.Entity<Links>()
                .Property(e => e.created_at)
                .HasPrecision(0);

            modelBuilder.Entity<Links>()
                .Property(e => e.updated_at)
                .HasPrecision(0);

            modelBuilder.Entity<Links>()
                .Property(e => e.deleted_at)
                .HasPrecision(0);

            modelBuilder.Entity<Options>()
                .Property(e => e.option_name)
                .IsUnicode(false);

            modelBuilder.Entity<Options>()
                .Property(e => e.option_value)
                .IsUnicode(false);

            modelBuilder.Entity<Options>()
                .Property(e => e.autoload)
                .IsUnicode(false);

            modelBuilder.Entity<Options>()
                .Property(e => e.created_at)
                .HasPrecision(0);

            modelBuilder.Entity<Options>()
                .Property(e => e.updated_at)
                .HasPrecision(0);

            modelBuilder.Entity<Options>()
                .Property(e => e.deleted_at)
                .HasPrecision(0);

            modelBuilder.Entity<Postmeta>()
                .Property(e => e.meta_key)
                .IsUnicode(false);

            modelBuilder.Entity<Postmeta>()
                .Property(e => e.meta_value)
                .IsUnicode(false);

            modelBuilder.Entity<Postmeta>()
                .Property(e => e.created_at)
                .HasPrecision(0);

            modelBuilder.Entity<Postmeta>()
                .Property(e => e.updated_at)
                .HasPrecision(0);

            modelBuilder.Entity<Postmeta>()
                .Property(e => e.deleted_at)
                .HasPrecision(0);

            modelBuilder.Entity<Posts>()
                .Property(e => e.post_date)
                .HasPrecision(0);

            modelBuilder.Entity<Posts>()
                .Property(e => e.post_date_gmt)
                .HasPrecision(0);

            modelBuilder.Entity<Posts>()
                .Property(e => e.post_content)
                .IsUnicode(false);

            modelBuilder.Entity<Posts>()
                .Property(e => e.post_title)
                .IsUnicode(false);

            modelBuilder.Entity<Posts>()
                .Property(e => e.post_excerpt)
                .IsUnicode(false);

            modelBuilder.Entity<Posts>()
                .Property(e => e.post_status)
                .IsUnicode(false);

            modelBuilder.Entity<Posts>()
                .Property(e => e.comment_status)
                .IsUnicode(false);

            modelBuilder.Entity<Posts>()
                .Property(e => e.post_password)
                .IsUnicode(false);

            modelBuilder.Entity<Posts>()
                .Property(e => e.post_slug)
                .IsUnicode(false);

            modelBuilder.Entity<Posts>()
                .Property(e => e.post_type)
                .IsUnicode(false);

            modelBuilder.Entity<Posts>()
                .Property(e => e.post_mime_type)
                .IsUnicode(false);

            modelBuilder.Entity<Posts>()
                .Property(e => e.created_at)
                .HasPrecision(0);

            modelBuilder.Entity<Posts>()
                .Property(e => e.updated_at)
                .HasPrecision(0);

            modelBuilder.Entity<Posts>()
                .Property(e => e.deleted_at)
                .HasPrecision(0);

            modelBuilder.Entity<Users>()
                .Property(e => e.user_login)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.user_pass)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.user_nicename)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.user_email)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.user_url)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.user_registered)
                .HasPrecision(0);

            modelBuilder.Entity<Users>()
                .Property(e => e.user_activation_key)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.created_at)
                .HasPrecision(0);

            modelBuilder.Entity<Users>()
                .Property(e => e.updated_at)
                .HasPrecision(0);

            modelBuilder.Entity<Users>()
                .Property(e => e.deleted_at)
                .HasPrecision(0);

            modelBuilder.Entity<Users>()
                .Property(e => e.display_name)
                .IsUnicode(false);
        }
    }
}
