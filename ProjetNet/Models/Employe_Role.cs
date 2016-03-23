using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projet_ASP.Models
{
    public class Employe_Role
    {
        [Key]
        public int Employe_RoleId { get; set; }

        public int EmployeRefId { get; set; }

        [ForeignKey("EmployeRefId")]
        public virtual Employe Employe { get; set; }

        public int RoleRefId { get; set; }

        [ForeignKey("RoleRefId")]
        public virtual Roles Role { get; set; }

    }
}