using GymManager.ApplicationServices.Members;
using GymManager.Core.Members;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymManager.Web.Controllers
{
    public class MembersShipController : Controller
    {
        private readonly iMembersAppService _memberAppService;
        private readonly iMembershipTypesAppService _membershipAppService;


        public MembersShipController(iMembersAppService memberAppService, iMembershipTypesAppService membershipAppService)
        {
            _memberAppService = memberAppService;
            _membershipAppService = membershipAppService;

        }
        public async Task<IActionResult> Renwal()
        {
            List<Member> members = await _memberAppService.GetMemberMembership();

            MemberListViewModel viewModel = new MemberListViewModel();

            viewModel.Members = members;

            return View(viewModel);
        }

        public async Task<IActionResult> Membership(int memberId)
        {
            List<MembershipType> memberships = await _membershipAppService.GetMembershipsAsync();

            MembershipRenwalListViewModel viewModel = new MembershipRenwalListViewModel();

            viewModel.membershipTypes = memberships;
            viewModel.Ids = new MembershipRenwalViewModel { MemberId = memberId };

            return View(viewModel);

        }

        [HttpPost]
        public async Task<IActionResult> Membership(MembershipRenwalListViewModel viewModel)
        {
            Member member = await _memberAppService.GetMemberAsync(viewModel.Ids.MemberId);

            Member membermembership = new Member
            {
                Id = member.Id,
                Name = member.Name,
                LastName = member.LastName,
                Email = member.Email,
                Birthday = member.Birthday,
                City = member.City,
                AllowNewsletter = member.AllowNewsletter,
                Membersince = member.Membersince,
                MembershipType = new MembershipType
                {
                    Id = viewModel.Ids.MembershipId
                }

            };

            await _memberAppService.UpdateMembership(membermembership);

            return RedirectToAction("renwal");
        }


    }
}
