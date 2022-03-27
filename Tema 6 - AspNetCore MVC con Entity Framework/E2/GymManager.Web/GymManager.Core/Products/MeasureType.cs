using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Products
{
    public class MeasureType
    {
        [Key]
        public int Id { get; set; }

        [StringLength(1)]
        [Required]
        public string Size { get; set; }

        [Required]
        public decimal Weight { get; set; }

        [Required]
        public decimal Cost { get; set; }

    }
}
