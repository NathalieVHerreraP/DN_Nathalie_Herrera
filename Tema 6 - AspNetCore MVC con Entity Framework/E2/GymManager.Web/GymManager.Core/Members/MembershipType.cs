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
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(45)]
        public string Type { get; set; }

        [Required]
        public decimal Cost { get; set; }

    }
}
