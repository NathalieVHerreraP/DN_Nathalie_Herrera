using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Products
{
    public class ProductType
    {
        [Key]
        public int Id { get; set; }

        [StringLength(45)]
        [Required]
        public string Name { get; set; }

        [StringLength(45)]
        [Required]
        public string Brand { get; set; }

        public MeasureType MeasureType { get; set; }

        public Inventory Inventory { get; set; }
    }
}
