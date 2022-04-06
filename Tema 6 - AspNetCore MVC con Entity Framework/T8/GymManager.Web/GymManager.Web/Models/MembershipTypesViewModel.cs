using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GymManager.Web.Models
{
    public class MembershipTypesViewModel
    {
        public int Id { get; set; }

        public string Type { get; set; }


        public decimal Cost { get; set; }


        public int MonthsDuration { get; set; }
    }
}
