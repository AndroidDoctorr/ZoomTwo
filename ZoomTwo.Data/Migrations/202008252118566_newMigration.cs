namespace ZoomTwo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Meeting", "OrganizationId", "dbo.Organization");
            DropIndex("dbo.Meeting", new[] { "OrganizationId" });
            AlterColumn("dbo.Meeting", "OrganizationId", c => c.Int(nullable: false));
            CreateIndex("dbo.Meeting", "OrganizationId");
            AddForeignKey("dbo.Meeting", "OrganizationId", "dbo.Organization", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Meeting", "OrganizationId", "dbo.Organization");
            DropIndex("dbo.Meeting", new[] { "OrganizationId" });
            AlterColumn("dbo.Meeting", "OrganizationId", c => c.Int());
            CreateIndex("dbo.Meeting", "OrganizationId");
            AddForeignKey("dbo.Meeting", "OrganizationId", "dbo.Organization", "Id");
        }
    }
}
