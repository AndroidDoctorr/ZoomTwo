namespace ZoomTwo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedAttendeesProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attendee", "Meeting_Id", c => c.Int());
            CreateIndex("dbo.Attendee", "Meeting_Id");
            AddForeignKey("dbo.Attendee", "Meeting_Id", "dbo.Meeting", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendee", "Meeting_Id", "dbo.Meeting");
            DropIndex("dbo.Attendee", new[] { "Meeting_Id" });
            DropColumn("dbo.Attendee", "Meeting_Id");
        }
    }
}
