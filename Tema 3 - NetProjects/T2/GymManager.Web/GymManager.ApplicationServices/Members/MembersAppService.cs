using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.Members
{
    public class MembersAppService : iMembersAppService
    {
        public List<Member> GetMembers()
        {

            List<Member> members = new List<Member>();

            members.Add(new Member 
            { 
                Name = "Nath",
                LastName = "Herrera",
                Birthday = new DateTime(2001,8,11),
                AllowNewsletter = true,
                CityId = 4,
                Email = "nath@test.com"
            });
            members.Add(new Member
            {
                Name = "Ness",
                LastName = "Padilla",
                Birthday = new DateTime(2001, 8, 11),
                AllowNewsletter = true,
                CityId = 4,
                Email = "ness@test.com"
            });
            members.Add(new Member
            {
                Name = "Jorge",
                LastName = "Perez",
                Birthday = new DateTime(1997, 12, 24),
                AllowNewsletter = true,
                CityId = 1,
                Email = "jorge@test.com"
            });
            members.Add(new Member
            {
                Name = "Mimi",
                LastName = "Rodriguez",
                Birthday = new DateTime(1983, 2, 9),
                AllowNewsletter = false,
                CityId = 3,
                Email = "mimi@test.com"
            });
            members.Add(new Member
            {
                Name = "Pepe",
                LastName = "Serna",
                Birthday = new DateTime(2000, 12, 6),
                AllowNewsletter = true,
                CityId = 1,
                Email = "pepe@test.com"
            });
            members.Add(new Member
            {
                Name = "Rene",
                LastName = "Gomez",
                Birthday = new DateTime(1977, 6, 30),
                AllowNewsletter = true,
                CityId = 6,
                Email = "rene@test.com"
            });
            members.Add(new Member
            {
                Name = "Liz",
                LastName = "Montoya",
                Birthday = new DateTime(2001, 3, 16),
                AllowNewsletter = true,
                CityId = 5,
                Email = "liz@test.com"
            });

            return members;

        }
    }
}
