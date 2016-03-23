namespace Projet_ASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RolesMetiers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Metiers",
                c => new
                    {
                        MetierId = c.Int(nullable: false, identity: true),
                        Categorie = c.String(),
                        Libelle = c.String(),
                    })
                .PrimaryKey(t => t.MetierId);
            
            DropColumn("dbo.Roles", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Roles", "Description", c => c.String());
            DropTable("dbo.Metiers");
        }
    }
}
