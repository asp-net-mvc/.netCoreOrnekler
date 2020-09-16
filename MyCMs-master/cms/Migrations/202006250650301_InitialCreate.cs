namespace cms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        role_id = c.Int(nullable: false),
                        username = c.String(nullable: false, maxLength: 255, unicode: false),
                        name = c.String(nullable: false, maxLength: 255, unicode: false),
                        email = c.String(nullable: false, maxLength: 255, unicode: false),
                        password = c.String(nullable: false, maxLength: 255, unicode: false),
                        remember_token = c.String(maxLength: 100, unicode: false),
                        created_at = c.DateTime(precision: 0, storeType: "datetime2"),
                        updated_at = c.DateTime(precision: 0, storeType: "datetime2"),
                        deleted_at = c.DateTime(precision: 0, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        comment_ID = c.Long(nullable: false, identity: true),
                        comment_post_ID = c.Long(nullable: false),
                        comment_author = c.String(nullable: false, maxLength: 255, unicode: false),
                        comment_author_email = c.String(nullable: false, maxLength: 100, unicode: false),
                        comment_author_url = c.String(nullable: false, maxLength: 200, unicode: false),
                        comment_author_IP = c.String(nullable: false, maxLength: 100, unicode: false),
                        comment_date = c.DateTime(nullable: false, precision: 0, storeType: "datetime2"),
                        comment_date_gmt = c.DateTime(nullable: false, precision: 0, storeType: "datetime2"),
                        comment_content = c.String(nullable: false, unicode: false),
                        comment_approved = c.String(nullable: false, maxLength: 20, unicode: false),
                        comment_agent = c.String(nullable: false, maxLength: 255, unicode: false),
                        comment_type = c.String(nullable: false, maxLength: 20, unicode: false),
                        comment_parent = c.Long(nullable: false),
                        user_id = c.Long(nullable: false),
                        created_at = c.DateTime(precision: 0, storeType: "datetime2"),
                        updated_at = c.DateTime(precision: 0, storeType: "datetime2"),
                        deleted_at = c.DateTime(precision: 0, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.comment_ID);
            
            CreateTable(
                "dbo.Links",
                c => new
                    {
                        link_id = c.Long(nullable: false, identity: true),
                        link_url = c.String(nullable: false, maxLength: 255, unicode: false),
                        link_name = c.String(nullable: false, maxLength: 255, unicode: false),
                        link_image = c.String(nullable: false, maxLength: 255, unicode: false),
                        link_target = c.String(nullable: false, maxLength: 25, unicode: false),
                        link_description = c.String(nullable: false, maxLength: 255, unicode: false),
                        link_visible = c.String(nullable: false, maxLength: 20, unicode: false),
                        link_owner = c.Long(nullable: false),
                        link_rating = c.Int(nullable: false),
                        link_updated = c.DateTime(nullable: false, precision: 0, storeType: "datetime2"),
                        link_rel = c.String(nullable: false, maxLength: 255, unicode: false),
                        link_notes = c.String(nullable: false, unicode: false),
                        link_rss = c.String(nullable: false, maxLength: 255, unicode: false),
                        created_at = c.DateTime(precision: 0, storeType: "datetime2"),
                        updated_at = c.DateTime(precision: 0, storeType: "datetime2"),
                        deleted_at = c.DateTime(precision: 0, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.link_id);
            
            CreateTable(
                "dbo.Options",
                c => new
                    {
                        option_id = c.Long(nullable: false, identity: true),
                        option_name = c.String(nullable: false, maxLength: 191, unicode: false),
                        option_value = c.String(nullable: false, unicode: false),
                        autoload = c.String(nullable: false, maxLength: 20, unicode: false),
                        created_at = c.DateTime(precision: 0, storeType: "datetime2"),
                        updated_at = c.DateTime(precision: 0, storeType: "datetime2"),
                        deleted_at = c.DateTime(precision: 0, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.option_id);
            
            CreateTable(
                "dbo.Postmetas",
                c => new
                    {
                        meta_id = c.Long(nullable: false, identity: true),
                        post_id = c.Long(nullable: false),
                        meta_key = c.String(maxLength: 255, unicode: false),
                        meta_value = c.String(unicode: false),
                        created_at = c.DateTime(precision: 0, storeType: "datetime2"),
                        updated_at = c.DateTime(precision: 0, storeType: "datetime2"),
                        deleted_at = c.DateTime(precision: 0, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.meta_id);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        post_author = c.Long(nullable: false),
                        post_date = c.DateTime(nullable: false, precision: 0, storeType: "datetime2"),
                        post_date_gmt = c.DateTime(nullable: false, precision: 0, storeType: "datetime2"),
                        post_content = c.String(nullable: false, unicode: false),
                        post_title = c.String(nullable: false, unicode: false),
                        post_excerpt = c.String(nullable: false, unicode: false),
                        post_status = c.String(nullable: false, maxLength: 20, unicode: false),
                        comment_status = c.String(nullable: false, maxLength: 20, unicode: false),
                        post_password = c.String(maxLength: 255, unicode: false),
                        post_slug = c.String(nullable: false, maxLength: 200, unicode: false),
                        post_parent = c.Long(nullable: false),
                        menu_order = c.Int(nullable: false),
                        post_type = c.String(maxLength: 20, unicode: false),
                        post_mime_type = c.String(nullable: false, maxLength: 100, unicode: false),
                        comment_count = c.Long(nullable: false),
                        created_at = c.DateTime(precision: 0, storeType: "datetime2"),
                        updated_at = c.DateTime(precision: 0, storeType: "datetime2"),
                        deleted_at = c.DateTime(precision: 0, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        user_login = c.String(nullable: false, maxLength: 60, unicode: false),
                        user_pass = c.String(nullable: false, maxLength: 255, unicode: false),
                        user_nicename = c.String(nullable: false, maxLength: 50, unicode: false),
                        user_email = c.String(nullable: false, maxLength: 100, unicode: false),
                        user_url = c.String(nullable: false, maxLength: 100, unicode: false),
                        user_registered = c.DateTime(nullable: false, precision: 0, storeType: "datetime2"),
                        user_activation_key = c.String(nullable: false, maxLength: 255, unicode: false),
                        user_status = c.Int(nullable: false),
                        created_at = c.DateTime(precision: 0, storeType: "datetime2"),
                        updated_at = c.DateTime(precision: 0, storeType: "datetime2"),
                        deleted_at = c.DateTime(precision: 0, storeType: "datetime2"),
                        display_name = c.String(nullable: false, maxLength: 250, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Posts");
            DropTable("dbo.Postmetas");
            DropTable("dbo.Options");
            DropTable("dbo.Links");
            DropTable("dbo.Comments");
            DropTable("dbo.Admins");
        }
    }
}
