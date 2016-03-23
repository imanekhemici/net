namespace Projet_ASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reTableEmployeMetier : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EmployeMetier", "MetierRefId", "dbo.Employes");
            DropForeignKey("dbo.EmployeMetier", "EmployeRefId", "dbo.Metiers");
            DropIndex("dbo.EmployeMetier", new[] { "MetierRefId" });
            DropIndex("dbo.EmployeMetier", new[] { "EmployeRefId" });
            DropTable("dbo.EmployeMetier");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.EmployeMetier",
                c => new
                    {
                        MetierRefId = c.Int(nullable: false),
                        EmployeRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MetierRefId, t.EmployeRefId });
            
            CreateIndex("dbo.EmployeMetier", "EmployeRefId");
            CreateIndex("dbo.EmployeMetier", "MetierRefId");
            AddForeignKey("dbo.EmployeMetier", "EmployeRefId", "dbo.Metiers", "MetierId", cascadeDelete: true);
            AddForeignKey("dbo.EmployeMetier", "MetierRefId", "dbo.Employes", "EmployeID", cascadeDelete: true);
        }
    }
}
