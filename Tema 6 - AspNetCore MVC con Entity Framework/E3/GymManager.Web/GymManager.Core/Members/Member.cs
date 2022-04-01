using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GymManager.Core.Members
{
    public class Member
    {
        [Key]
        public int Id { get; set; }

        [StringLength(15)]
        [Required(ErrorMessage = "(Test) Must type the member name")]
        public string Name { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "(Test) Must type the member last name")]
        public string LastName { get; set; }

        [BindProperty, DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime Membersince { get; set; }

        [BindProperty, DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime Birthday { get; set; }

        [Range(1 , 100)]
        public City City { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        public bool AllowNewsletter { get; set; }

        public List<MembershipType> MembershipTypes { get; set; }

        public Member()
        {
            MembershipTypes = new List<MembershipType>();
        }


    }
}
