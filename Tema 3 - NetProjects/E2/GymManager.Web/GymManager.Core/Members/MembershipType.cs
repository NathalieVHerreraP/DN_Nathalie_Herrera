using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Members
{
    public class MembershipType
    {
        public int Id { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Must type the member name")]
        public String Name { get; set; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Must type the Cost")]
        public double Cost { get; set; }

        public DateTime CreatedOn { get; set; }

        [Required(ErrorMessage = "Must type the Duration")]
        public int Duration { get; set; }
    }
}
