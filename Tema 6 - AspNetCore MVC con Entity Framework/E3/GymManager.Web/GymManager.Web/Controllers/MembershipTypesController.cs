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
    public class MembershipTypesController : Controller
    {
        private readonly iMembershipTypesAppService _membershipAppService;
        private readonly iMembersAppService _membersAppService;
 

        public MembershipTypesController(iMembershipTypesAppService membershipAppService, iMembersAppService membersAppService)
        {
            _membershipAppService = membershipAppService;
            _membersAppService = membersAppService;
            
        }

        public async Task<IActionResult> Index()
        {

            List<MembershipType> memberships = await _membershipAppService.GetMembershipsAsync();

            MembershipTypesListViewModel viewModel = new MembershipTypesListViewModel();

            viewModel.MembershipTypes = memberships;
            return View(viewModel);
        }

        public async Task<IActionResult> Create()
        {
            List<Member> members = await _membersAppService.GetMembersAsync();

            MembershipTypesViewModel viewModel = new MembershipTypesViewModel();

            viewModel.Members = members;

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(MembershipTypesViewModel viewModel)
        {
            MembershipType membership = new MembershipType 
            {
                Type = viewModel.Type,
                Cost = viewModel.Cost,
                Member = new Member 
                { 
                    Id = viewModel.MemberId.Id 
                },
                MonthsDuration = viewModel.MonthsDuration,
                StartingDate = viewModel.StartingDate
            };
            
            await _membershipAppService.AddMembershipAsync(membership);

            return RedirectToAction("index");
        }

        public async Task<IActionResult> Delete(int membershipId)
        {

            await _membershipAppService.DeleteMembershipAsync(membershipId);

            return RedirectToAction("index");
        }

        public async Task<IActionResult> Edit(int membershipId)
        {

            MembershipType membership = await _membershipAppService.GetMembershipAsync(membershipId);
            List<Member> members = await _membersAppService.GetMembersAsync();

            MembershipTypesViewModel viewModel = new MembershipTypesViewModel();

            viewModel.Members = members;
            viewModel.Id = membership.Id;
            viewModel.Type = membership.Type;
            viewModel.Cost = membership.Cost;
            viewModel.MemberId = membership.Member;
            viewModel.MonthsDuration = membership.MonthsDuration;
            viewModel.StartingDate = membership.StartingDate;

            return View(membership);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(MembershipType membership)
        {

            await _membershipAppService.EditMembershipAsync(membership);

            return RedirectToAction("index");
        }
    }
}
