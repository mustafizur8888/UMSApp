namespace UMSApp.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterStudent : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Students");
            AlterColumn("dbo.Students", "Id", c => c.String(nullable: false, maxLength: 11));
            AddPrimaryKey("dbo.Students", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Students");
            AlterColumn("dbo.Students", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Students", "Id");
        }
    }
}
