using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymManager.Web.Models
{
    public class MembershipRenwalListViewModel
    {
        public MembershipRenwalViewModel Ids { get; set; }

        public List<MembershipType> membershipTypes { get; set; }


    }
}
