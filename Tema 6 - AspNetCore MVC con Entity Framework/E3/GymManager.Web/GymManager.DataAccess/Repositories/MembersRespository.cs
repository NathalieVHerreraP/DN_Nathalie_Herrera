using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GymManager.DataAccess.Repositories
{
    public class MembersRespository : Repository<int, Member>
    {
        public MembersRespository(GymManagerContext context) : base(context)
        {
            
        }

        public override async Task<Member> AddAsync(Member entity)
        {
            var city = await Context.Cities.FindAsync(entity.City.Id);
            entity.City = null;
            await Context.Members.AddAsync(entity);
            city.Members.Add(entity);

            await Context.SaveChangesAsync();

            return entity;
        }

        public async override Task<Member> GetAsync(int id)
        {
            var member = await Context.Members.Include(x => x.City).FirstOrDefaultAsync(x => x.Id == id);

            return member;
        }

        public override IQueryable<Member> GetAllMembership() 
        {
            var members = Context.Members.Include(x => x.MembershipType);

            return members;
        }

        public override async Task<Member> UpdateMemberMembership(Member entity)
        {
            var membership = await Context.MembershipTypes.FindAsync(entity.MembershipType.Id);
            var member = await Context.Members.FindAsync(entity.Id);
            Context.Remove(member);
            entity.MembershipType = null;
            await Context.Members.AddAsync(entity);
            membership.Members.Add(entity);

            await Context.SaveChangesAsync();

            return entity;

        }

    }
}
