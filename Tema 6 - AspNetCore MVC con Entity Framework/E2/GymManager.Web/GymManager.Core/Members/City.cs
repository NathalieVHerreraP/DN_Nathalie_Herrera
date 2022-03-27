using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Members
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(45)]
        public string Name { get; set; }

    }
}
