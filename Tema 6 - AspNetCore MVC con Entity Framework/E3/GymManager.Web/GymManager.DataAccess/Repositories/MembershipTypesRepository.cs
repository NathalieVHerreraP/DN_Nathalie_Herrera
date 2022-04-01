using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GymManager.DataAccess.Repositories
{
    public class MembershipTypesRepository : Repository<int, MembershipType>
    {
        public MembershipTypesRepository(GymManagerContext context) : base(context)
        {

        }

        public override  IQueryable<MembershipType> GetAll()
        {
            IQueryable<MembershipType> membership = Context.MembershipTypes.Include(x => x.Member).AsQueryable();

            return membership;
        }

        public override async Task<MembershipType> AddAsync(MembershipType entity)
        {
            var member = await Context.Members.FindAsync(entity.Member.Id);
            entity.Member = null;
            await Context.MembershipTypes.AddAsync(entity);
            member.MembershipTypes.Add(entity);

            await Context.SaveChangesAsync();

            return entity;
        }

    }
}
