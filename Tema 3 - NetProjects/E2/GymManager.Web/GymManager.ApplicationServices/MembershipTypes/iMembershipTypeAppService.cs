using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.MembershipTypes
{
    public interface iMembershipTypeAppService
    {
        List<MembershipType> GetMemberships();

        int AddMembership(MembershipType membershipType);

        void DeleteMembership(int membershipId);

        MembershipType GetMembership(int membershipId);

        void EditMembership(MembershipType membershipType);

    }
}
