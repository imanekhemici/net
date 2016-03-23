using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projet_ASP.Models
{
    public class Employe
    {
        [Key]
        public int EmployeID { get; set; }

        public String Nom { get; set; }

        public String Prenom { get; set; }

        public String Matricule { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime dateNaissance { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime dateEntree { get; set; }

        public virtual ICollection<Employe_Metier> Metiers { get; set; }

        public virtual ICollection<Employe_Role> Roles { get; set; }
    }
}