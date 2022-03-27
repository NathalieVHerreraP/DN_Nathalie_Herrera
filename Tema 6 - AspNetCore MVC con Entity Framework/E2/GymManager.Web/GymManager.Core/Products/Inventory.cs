using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Products
{
    public class Inventory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
