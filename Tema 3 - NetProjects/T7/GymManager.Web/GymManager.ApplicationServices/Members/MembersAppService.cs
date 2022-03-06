﻿using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.Members
{
    public class MembersAppService : iMembersAppService
    {

        private static List<Member> Members = new List<Member>();

        public int AddMember(Member member)
        {
            member.Id = new Random().Next();

            Members.Add(member);

            return member.Id;
        }

        public void DeleteMember(int memberId)
        {
            var m = Members.Where(x => x.Id == memberId).FirstOrDefault();

            Members.Remove(m);

        }

        public void EditMember(Member member)
        {
            var m = Members.Where(x => x.Id == member.Id).FirstOrDefault();

            m.Name = member.Name;
            m.LastName = member.LastName;
            m.Birthday = member.Birthday;
            m.Email = member.Email;
            m.CityId = member.CityId;
            m.AllowNewsletter = member.AllowNewsletter;
         }

        public Member GetMember(int memberId)
        {
            var m = Members.Where(x => x.Id == memberId).FirstOrDefault();

            return m;
        }

        public List<Member> GetMembers()
        {
                        
            return Members;

        }
    }
}
