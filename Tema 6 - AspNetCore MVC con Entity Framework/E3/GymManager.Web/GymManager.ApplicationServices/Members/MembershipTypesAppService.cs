using GymManager.Core.Members;
using GymManager.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.Members
{
    public class MembershipTypesAppService : iMembershipTypesAppService
    {
        private readonly IRepository<int, MembershipType> _repository;
        public MembershipTypesAppService(IRepository<int, MembershipType> repository)
        {
            _repository = repository;
        }

        public async Task<int> AddMembershipAsync(MembershipType membership)
        {
            await _repository.AddAsync(membership);
            return membership.Id;
        }

        public async Task DeleteMembershipAsync(int membershipId)
        {
            await _repository.DeleteAsync(membershipId);
        }

        public async Task EditMembershipAsync(MembershipType membership)
        {
            await _repository.UpdateAsync(membership);
        }

        public async Task<MembershipType> GetMembershipAsync(int membershipId)
        {
            return await _repository.GetAsync(membershipId);
        }

        public async Task<List<MembershipType>> GetMembershipsAsync()
        {
            return await _repository.GetAll().ToListAsync();
        }
    }
}
