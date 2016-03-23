namespace Projet_ASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignKeys : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employe_Metier",
                c => new
                    {
                        Employe_MetierId = c.Int(nullable: false, identity: true),
                        DebutMetier = c.DateTime(nullable: false),
                        FinMetier = c.DateTime(nullable: false),
                        Employe_EmployeID = c.Int(),
                        Metier_MetierId = c.Int(),
                    })
                .PrimaryKey(t => t.Employe_MetierId)
                .ForeignKey("dbo.Employes", t => t.Employe_EmployeID)
                .ForeignKey("dbo.Metiers", t => t.Metier_MetierId)
                .Index(t => t.Employe_EmployeID)
                .Index(t => t.Metier_MetierId);
            
            AddColumn("dbo.Metiers", "debut", c => c.DateTime(nullable: false));
            AddColumn("dbo.Metiers", "fin", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropIndex("dbo.Employe_Metier", new[] { "Metier_MetierId" });
            DropIndex("dbo.Employe_Metier", new[] { "Employe_EmployeID" });
            DropForeignKey("dbo.Employe_Metier", "Metier_MetierId", "dbo.Metiers");
            DropForeignKey("dbo.Employe_Metier", "Employe_EmployeID", "dbo.Employes");
            DropColumn("dbo.Metiers", "fin");
            DropColumn("dbo.Metiers", "debut");
            DropTable("dbo.Employe_Metier");
        }
    }
}
