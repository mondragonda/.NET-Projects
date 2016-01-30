namespace IntroductionToASPNETMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotationChanged : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Albums", "Artist_ArtistId", "dbo.Artists");
            DropIndex("dbo.Albums", new[] { "Artist_ArtistId" });
            AlterColumn("dbo.Albums", "Artist_ArtistId", c => c.Int());
            CreateIndex("dbo.Albums", "Artist_ArtistId");
            AddForeignKey("dbo.Albums", "Artist_ArtistId", "dbo.Artists", "ArtistId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Albums", "Artist_ArtistId", "dbo.Artists");
            DropIndex("dbo.Albums", new[] { "Artist_ArtistId" });
            AlterColumn("dbo.Albums", "Artist_ArtistId", c => c.Int(nullable: false));
            CreateIndex("dbo.Albums", "Artist_ArtistId");
            AddForeignKey("dbo.Albums", "Artist_ArtistId", "dbo.Artists", "ArtistId", cascadeDelete: true);
        }
    }
}
