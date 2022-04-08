using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymManager.Web.Models
{
    public class MemberViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

   
        public string LastName { get; set; }

     
        public DateTime Membersince { get; set; }

        
        public DateTime Birthday { get; set; }

        
        public int CityId { get; set; }

       
        public string Email { get; set; }

        public bool AllowNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

    }
}
