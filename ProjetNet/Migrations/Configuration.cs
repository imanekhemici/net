namespace Projet_ASP.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Projet_ASP.Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<Projet_ASP.DAO.MainContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Projet_ASP.DAO.MainContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var roles = new List<Roles> {
                new Roles { Titre = "Manager"},
                new Roles { Titre = "Chef d'�quipe"},
                new Roles { Titre = "Responsable fonctionnel"},
                new Roles { Titre = "Responsable technique"},
                new Roles { Titre = "Apprenti"},
                new Roles { Titre = "Organisateur"},
                new Roles { Titre = "Coordinateur"},
                new Roles { Titre = "R�f�rent technique"},
                new Roles { Titre = "R�f�rent fonctionnel"}
            };

            roles.ForEach(s => context.Roles.AddOrUpdate(p => p.Titre, s));
            context.SaveChanges();

            DateTime now = DateTime.Now;


            var finvalidite = now;
            finvalidite = finvalidite.AddYears(3);
            var metiers = new List<Metier>
            {
                new Metier {Categorie = "Achats", Libelle = "Acheteur", debut = now, fin = finvalidite },
                new Metier {Categorie = "Achats", Libelle = "Directeur des achats", debut = now, fin = finvalidite },
                new Metier {Categorie = "Commerce", Libelle = "Assistant(e) commercial", debut = now, fin = finvalidite },
                new Metier {Categorie = "Commerce", Libelle = "Responsable de client�le", debut = now, fin = finvalidite },
                new Metier {Categorie = "Commerce", Libelle = "Assitant(e) charg� de cleint�le", debut = now, fin = finvalidite },
                new Metier {Categorie = "Commerce", Libelle = "Contr�leur de gestion", debut = now, fin = finvalidite },
                new Metier {Categorie = "Ressources Humaines", Libelle = "Responsable RH", debut = now, fin = finvalidite },
                new Metier {Categorie = "Ressources Humaines", Libelle = "Charg�(e) de recrutement", debut = now, fin = finvalidite },
                new Metier {Categorie = "Conseil", Libelle = "Directeur conseil", debut = now, fin = finvalidite },
                new Metier {Categorie = "Conseil", Libelle = "Directeur de d�veloppement", debut = now, fin = finvalidite },
                new Metier {Categorie = "IT", Libelle = "D�veloppeur", debut = now, fin = finvalidite },
                new Metier {Categorie = "IT", Libelle = "Graphiste", debut = now, fin = finvalidite },
                new Metier {Categorie = "IT", Libelle = "Chef de projet Web", debut = now, fin = finvalidite },
                new Metier {Categorie = "Communication/M�dia", Libelle = "Chef de projet digital", debut = now, fin = finvalidite },
                new Metier {Categorie = "Communication/M�dia", Libelle = "Chef de projet event", debut = now, fin = finvalidite },
                new Metier {Categorie = "Communication/M�dia", Libelle = "Chef de projet �ditorial", debut = now, fin = finvalidite }

            };

            metiers.ForEach(s => context.Metier.AddOrUpdate(p => p.Libelle, s));
            context.SaveChanges();
           
        }
    }
}
