namespace Projet_ASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectFK : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MetierEmployes",
                c => new
                    {
                        Metier_MetierId = c.Int(nullable: false),
                        Employe_EmployeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Metier_MetierId, t.Employe_EmployeID })
                .ForeignKey("dbo.Metiers", t => t.Metier_MetierId, cascadeDelete: true)
                .ForeignKey("dbo.Employes", t => t.Employe_EmployeID, cascadeDelete: true)
                .Index(t => t.Metier_MetierId)
                .Index(t => t.Employe_EmployeID);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.MetierEmployes", new[] { "Employe_EmployeID" });
            DropIndex("dbo.MetierEmployes", new[] { "Metier_MetierId" });
            DropForeignKey("dbo.MetierEmployes", "Employe_EmployeID", "dbo.Employes");
            DropForeignKey("dbo.MetierEmployes", "Metier_MetierId", "dbo.Metiers");
            DropTable("dbo.MetierEmployes");
        }
    }
}
