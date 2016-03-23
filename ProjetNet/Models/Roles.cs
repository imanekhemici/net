using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projet_ASP.Models
{
    public class Roles
    {
        [Key]
        public int RoleId { get; set; }

        public String Titre { get; set; }

        public virtual ICollection<Employe_Role> Employes { get; set; }
    }
}