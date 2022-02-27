using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.MembershipTypes
{
    public class MembershipTypeAppService : iMembershipTypeAppService
    {
        private static List<MembershipType> MembershipType = new List<MembershipType>();
        public List<MembershipType> GetMemberships()
        {
            return MembershipType;
        }

        public int AddMembership(MembershipType membership) 
        {
            membership.Id = new Random().Next();

            membership.CreatedOn = DateTime.Now;

            MembershipType.Add(membership);

            return membership.Id;
        }

        public void DeleteMembership(int membershipId)
        {
            var mst = MembershipType.Where(x => x.Id == membershipId).FirstOrDefault();

            MembershipType.Remove(mst);
        }

        public MembershipType GetMembership(int membershipId)
        {
            var mst = MembershipType.Where(x => x.Id == membershipId).FirstOrDefault();

            return mst;
        }

        public void EditMembership(MembershipType membershipType)
        {
            var mst = MembershipType.Where(x => x.Id == membershipType.Id).FirstOrDefault();

            mst.Name = membershipType.Name;
            mst.Cost = membershipType.Cost;
            mst.Duration = membershipType.Duration;
        }
    }
}
