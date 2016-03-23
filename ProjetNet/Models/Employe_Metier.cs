using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projet_ASP.Models
{
    public class Employe_Metier
    {

        [Key]
        public int Employe_MetierId { get; set; }

        public int EmployeRefId { get; set; }

        [ForeignKey("EmployeRefId")]
        public virtual Employe Employe { get; set; }

        public int MetierRefId { get; set; }

        [ForeignKey("MetierRefId")]
        public virtual Metier Metier { get; set; }

        public DateTime DebutMetier { get; set; }

        public DateTime FinMetier { get; set; }

    }
}