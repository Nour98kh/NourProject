using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gp.Domain
{
    public class Abonnement
    {
        [Key]
        public int CodeAbo { get; set; }

        [Required(ErrorMessage = "Abonnement Description is required")]
        [StringLength(50, ErrorMessage = "Invalid size "), MaxLength(25, ErrorMessage = "Invalid size for database")]
        public string DescriptionAbo { get; set; }

        public double TarifAbo { get; set; }

        [Column(TypeName="nvarchar(5)")]
        public string DureeAbo { get; set; }

        public virtual ICollection<Member> Members { get; set; }


        public Abonnement()
        {

        }

        public Abonnement(int id, string descrip, string dur)
        {
            this.CodeAbo = id;
            this.DescriptionAbo = descrip;
            this.DureeAbo = dur;

        }

        public override string ToString()
        {
            return "\nAbonnement info: " + $"\nAbonnementId : {CodeAbo}" + $"\nAbonnement_Name : {DescriptionAbo}";
        }
    }
}
