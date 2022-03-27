using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Products
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }

        public decimal TotalCost { get; set; }

        public DateTime SellDate { get; set; }

        public int ProductQuantity { get; set; }

        public ProductType ProductType { get; set; }
    }
}
