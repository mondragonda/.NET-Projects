namespace IntroductionToASPNETMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedForeignKeyDefinition : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "Album_AlbumId", "dbo.Albums");
            DropIndex("dbo.Reviews", new[] { "Album_AlbumId" });
            RenameColumn(table: "dbo.Reviews", name: "Album_AlbumId", newName: "AlbumId");
            AlterColumn("dbo.Reviews", "AlbumId", c => c.Int(nullable: false));
            CreateIndex("dbo.Reviews", "AlbumId");
            AddForeignKey("dbo.Reviews", "AlbumId", "dbo.Albums", "AlbumId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "AlbumId", "dbo.Albums");
            DropIndex("dbo.Reviews", new[] { "AlbumId" });
            AlterColumn("dbo.Reviews", "AlbumId", c => c.Int());
            RenameColumn(table: "dbo.Reviews", name: "AlbumId", newName: "Album_AlbumId");
            CreateIndex("dbo.Reviews", "Album_AlbumId");
            AddForeignKey("dbo.Reviews", "Album_AlbumId", "dbo.Albums", "AlbumId");
        }
    }
}
