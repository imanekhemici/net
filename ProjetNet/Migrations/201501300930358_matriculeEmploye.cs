namespace Projet_ASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class matriculeEmploye : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employes", "Matricule", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employes", "Matricule");
        }
    }
}
