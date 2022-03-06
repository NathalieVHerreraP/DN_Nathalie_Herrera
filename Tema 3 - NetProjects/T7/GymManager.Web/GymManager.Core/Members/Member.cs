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

        public int Id { get; set; }

        [StringLength(15)]
        [Required(ErrorMessage = "(Test) Must type the member name")]
        public String Name { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "(Test) Must type the member last name")]
        public String LastName { get; set; }

        [BindProperty, DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]

        public DateTime Birthday { get; set; }

        [Range(1 , 100)]
        public int CityId { get; set; }

        [EmailAddress]
        [Required]
        public String Email { get; set; }

        public bool AllowNewsletter { get; set; }


    }
}
