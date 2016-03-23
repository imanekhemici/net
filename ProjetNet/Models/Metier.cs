using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projet_ASP.Models
{
    public class Metier
    {
        [Key]
        public int MetierId { get; set; }

        public String Categorie { get; set; }

        public String Libelle { get; set; }

        public DateTime debut { get; set; }

        public DateTime fin { get; set; }

        public virtual ICollection<Employe_Metier> Employes { get; set; }

    }
}