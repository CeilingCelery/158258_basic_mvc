namespace IntroMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addstudents : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Campus",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        CampusID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Campus", t => t.CampusID)
                .Index(t => t.CampusID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "CampusID", "dbo.Campus");
            DropIndex("dbo.Students", new[] { "CampusID" });
            DropTable("dbo.Students");
            DropTable("dbo.Campus");
        }
    }
}
