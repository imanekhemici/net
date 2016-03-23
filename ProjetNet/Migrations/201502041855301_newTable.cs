namespace Projet_ASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MetierEmployes", "Metier_MetierId", "dbo.Metiers");
            DropForeignKey("dbo.MetierEmployes", "Employe_EmployeID", "dbo.Employes");
            DropIndex("dbo.MetierEmployes", new[] { "Metier_MetierId" });
            DropIndex("dbo.MetierEmployes", new[] { "Employe_EmployeID" });
            CreateTable(
                "dbo.EmployeMetier",
                c => new
                    {
                        MetierRefId = c.Int(nullable: false),
                        EmployeRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MetierRefId, t.EmployeRefId })
                .ForeignKey("dbo.Employes", t => t.MetierRefId, cascadeDelete: true)
                .ForeignKey("dbo.Metiers", t => t.EmployeRefId, cascadeDelete: true)
                .Index(t => t.MetierRefId)
                .Index(t => t.EmployeRefId);
            
            DropTable("dbo.MetierEmployes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.MetierEmployes",
                c => new
                    {
                        Metier_MetierId = c.Int(nullable: false),
                        Employe_EmployeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Metier_MetierId, t.Employe_EmployeID });
            
            DropIndex("dbo.EmployeMetier", new[] { "EmployeRefId" });
            DropIndex("dbo.EmployeMetier", new[] { "MetierRefId" });
            DropForeignKey("dbo.EmployeMetier", "EmployeRefId", "dbo.Metiers");
            DropForeignKey("dbo.EmployeMetier", "MetierRefId", "dbo.Employes");
            DropTable("dbo.EmployeMetier");
            CreateIndex("dbo.MetierEmployes", "Employe_EmployeID");
            CreateIndex("dbo.MetierEmployes", "Metier_MetierId");
            AddForeignKey("dbo.MetierEmployes", "Employe_EmployeID", "dbo.Employes", "EmployeID", cascadeDelete: true);
            AddForeignKey("dbo.MetierEmployes", "Metier_MetierId", "dbo.Metiers", "MetierId", cascadeDelete: true);
        }
    }
}
