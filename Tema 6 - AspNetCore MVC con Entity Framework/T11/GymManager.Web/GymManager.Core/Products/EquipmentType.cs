using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Products
{
    public class EquipmentType
    {
        [Key]
        public int Id { get; set; }

        [StringLength(45)]
        [Required]
        public string Name { get; set; }

        [StringLength(45)]
        [Required]
        public string Brand { get; set; }

        [Required]
        public decimal Cost { get; set; }

        [Required]
        public int Units { get; set; }
    }
}
