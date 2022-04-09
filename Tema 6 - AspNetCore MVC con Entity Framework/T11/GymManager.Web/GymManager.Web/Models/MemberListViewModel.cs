using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymManager.Web.Models
{
    public class MemberListViewModel
    {

        public int NewMembersCount { get; set; }

        public List<Member> Members{ get; set; }

    }
}
