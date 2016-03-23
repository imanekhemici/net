namespace Projet_ASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class complteEmploye : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employes", "Prenom", c => c.String());
            AddColumn("dbo.Employes", "dateNaissance", c => c.DateTime(nullable: false));
            AddColumn("dbo.Employes", "dateEntree", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employes", "dateEntree");
            DropColumn("dbo.Employes", "dateNaissance");
            DropColumn("dbo.Employes", "Prenom");
        }
    }
}
