using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gp.Domain
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }

        [Required(ErrorMessage = "LastName is required")]
        [StringLength(16, ErrorMessage = "Invalid size "), MaxLength(25, ErrorMessage = "Invalid size for database")]
        public string LastNameM { get; set; }

        [Required(ErrorMessage = "FirstName is required")]
        [StringLength(16, ErrorMessage = "Invalid size "), MaxLength(25, ErrorMessage = "Invalid size for database")]
        public string FirstNameM { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(50)]
        public string EmailM { get; set; }

        [MaxLength(8, ErrorMessage = "Invalid size")]
        public int PhoneNumM { get; set; }

        [Display(Name = "Registration Date")]
        [DataType(DataType.Date, ErrorMessage = "Invalid Date")]
        public DateTime RegistrationDateM { get; set; }

        public virtual ICollection<AbonnementMember> MemAbonnements { get; set; }

        public Member()
        {

        }

        public Member(int id, string lastn, string firstn, int num)
        {
            this.MemberId = id;
            this.LastNameM = lastn;
            this.FirstNameM = firstn;
            this.PhoneNumM = num;

        }

        public override string ToString()
        {
            return "\nMember info: " + $"\nMemberId : {MemberId}" + $"\nName : {LastNameM}";
        }
    }
}
