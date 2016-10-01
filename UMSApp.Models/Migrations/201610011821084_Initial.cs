namespace UMSApp.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, name: "Ix_DepartmentName");
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, name: "Ix_StudentName");
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Students", "Ix_StudentName");
            DropIndex("dbo.Departments", "Ix_DepartmentName");
            DropTable("dbo.Students");
            DropTable("dbo.Departments");
        }
    }
}
