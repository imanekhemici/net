namespace Projet_ASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRoles1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employe_Role",
                c => new
                    {
                        Employe_RoleId = c.Int(nullable: false, identity: true),
                        EmployeRefId = c.Int(nullable: false),
                        RoleRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Employe_RoleId)
                .ForeignKey("dbo.Roles", t => t.RoleRefId, cascadeDelete: true)
                .ForeignKey("dbo.Employes", t => t.EmployeRefId, cascadeDelete: true)
                .Index(t => t.RoleRefId)
                .Index(t => t.EmployeRefId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Employe_Role", new[] { "EmployeRefId" });
            DropIndex("dbo.Employe_Role", new[] { "RoleRefId" });
            DropForeignKey("dbo.Employe_Role", "EmployeRefId", "dbo.Employes");
            DropForeignKey("dbo.Employe_Role", "RoleRefId", "dbo.Roles");
            DropTable("dbo.Employe_Role");
        }
    }
}
