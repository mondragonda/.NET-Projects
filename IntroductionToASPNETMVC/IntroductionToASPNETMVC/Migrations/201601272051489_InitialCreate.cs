namespace IntroductionToASPNETMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewId = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        ReviewerEmail = c.String(),
                        Album_AlbumId = c.Int(),
                    })
                .PrimaryKey(t => t.ReviewId)
                .ForeignKey("dbo.Albums", t => t.Album_AlbumId)
                .Index(t => t.Album_AlbumId);
            
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        AlbumId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Artist_ArtistId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AlbumId)
                .ForeignKey("dbo.Artists", t => t.Artist_ArtistId, cascadeDelete: true)
                .Index(t => t.Artist_ArtistId);
            
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        ArtistId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ArtistId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "Album_AlbumId", "dbo.Albums");
            DropForeignKey("dbo.Albums", "Artist_ArtistId", "dbo.Artists");
            DropIndex("dbo.Albums", new[] { "Artist_ArtistId" });
            DropIndex("dbo.Reviews", new[] { "Album_AlbumId" });
            DropTable("dbo.Artists");
            DropTable("dbo.Albums");
            DropTable("dbo.Reviews");
        }
    }
}
