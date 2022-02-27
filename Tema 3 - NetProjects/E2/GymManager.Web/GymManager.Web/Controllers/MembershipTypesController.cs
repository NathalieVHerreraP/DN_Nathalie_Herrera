using GymManager.ApplicationServices.MembershipTypes;
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

        private readonly iMembershipTypeAppService _membershipTypeAppService;

        public MembershipTypesController(iMembershipTypeAppService membershipTypeAppService) 
        {
            _membershipTypeAppService = membershipTypeAppService;
        }
        public IActionResult Index()
        {
            List<MembershipType> memberships = _membershipTypeAppService.GetMemberships();

            MembershipTypeListViewModel viewModel = new MembershipTypeListViewModel();

            viewModel.Membership = memberships;

            return View(viewModel);
        }

        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(MembershipType membership)
        {
            _membershipTypeAppService.AddMembership(membership);

            return RedirectToAction("index");
        }

        public IActionResult Delete(int membershipId) 
        {
            _membershipTypeAppService.DeleteMembership(membershipId);

            return RedirectToAction("index");
        }

        public IActionResult Edit(int membershipId)
        {

            MembershipType membership = _membershipTypeAppService.GetMembership(membershipId);

            return View(membership);
        }

        [HttpPost]
        public IActionResult Edit(MembershipType membership)
        {

            _membershipTypeAppService.EditMembership(membership);

            return RedirectToAction("index");
        }

    }
}
