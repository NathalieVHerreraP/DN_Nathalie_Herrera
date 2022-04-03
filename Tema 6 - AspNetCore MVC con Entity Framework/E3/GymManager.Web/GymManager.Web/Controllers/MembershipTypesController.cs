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
 

        public MembershipTypesController(iMembershipTypesAppService membershipAppService)
        {
            _membershipAppService = membershipAppService;
            
        }

        public async Task<IActionResult> Index()
        {

            List<MembershipType> memberships = await _membershipAppService.GetMembershipsAsync();

            MembershipTypesListViewModel viewModel = new MembershipTypesListViewModel();

            viewModel.MembershipTypes = memberships;
            return View(viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(MembershipType viewModel)
        {
                      
            await _membershipAppService.AddMembershipAsync(viewModel);

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
