namespace Projet_ASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class resolveDBProblems : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employe_Metier", "Employe_EmployeID", "dbo.Employes");
            DropForeignKey("dbo.Employe_Metier", "Metier_MetierId", "dbo.Metiers");
            DropIndex("dbo.Employe_Metier", new[] { "Employe_EmployeID" });
            DropIndex("dbo.Employe_Metier", new[] { "Metier_MetierId" });
            RenameColumn(table: "dbo.Employe_Metier", name: "Metier_MetierId", newName: "MetierRefId");
            AddColumn("dbo.Employe_Metier", "EmployeRefId", c => c.Int(nullable: false));
            AddForeignKey("dbo.Employe_Metier", "MetierRefId", "dbo.Metiers", "MetierId", cascadeDelete: true);
            AddForeignKey("dbo.Employe_Metier", "EmployeRefId", "dbo.Employes", "EmployeID", cascadeDelete: true);
            CreateIndex("dbo.Employe_Metier", "MetierRefId");
            CreateIndex("dbo.Employe_Metier", "EmployeRefId");
            DropColumn("dbo.Employe_Metier", "Employe_EmployeID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employe_Metier", "Employe_EmployeID", c => c.Int());
            DropIndex("dbo.Employe_Metier", new[] { "EmployeRefId" });
            DropIndex("dbo.Employe_Metier", new[] { "MetierRefId" });
            DropForeignKey("dbo.Employe_Metier", "EmployeRefId", "dbo.Employes");
            DropForeignKey("dbo.Employe_Metier", "MetierRefId", "dbo.Metiers");
            DropColumn("dbo.Employe_Metier", "EmployeRefId");
            RenameColumn(table: "dbo.Employe_Metier", name: "MetierRefId", newName: "Metier_MetierId");
            CreateIndex("dbo.Employe_Metier", "Metier_MetierId");
            CreateIndex("dbo.Employe_Metier", "Employe_EmployeID");
            AddForeignKey("dbo.Employe_Metier", "Metier_MetierId", "dbo.Metiers", "MetierId");
            AddForeignKey("dbo.Employe_Metier", "Employe_EmployeID", "dbo.Employes", "EmployeID");
        }
    }
}
