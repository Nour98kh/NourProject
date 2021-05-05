using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gp.Domain
{
    public class AbonnementMember
    {
        [Key]
        [Column(Order = 1)]
        [ForeignKey("Abonnement")]
        public int AbonnementFk { get; set; }
        [Key]
        [Column(Order = 2)]
        [ForeignKey("Member")]
        public int MemberFk { get; set; }

        public virtual Member Member { get; set; }
        public virtual Abonnement Abonnement { get; set; }


    }
}
