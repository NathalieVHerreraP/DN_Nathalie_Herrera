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
    public class MembersController : Controller
    {
        private readonly iMembersAppService _memberAppService;

        public MembersController(iMembersAppService memberAppService) 
        {
            _memberAppService = memberAppService;
        }

        public IActionResult Index()
        {

            List<Member> members = _memberAppService.GetMembers();

            MemberListViewModel viewModel = new MemberListViewModel();

            viewModel.NewMembersCount = 2;
            viewModel.Members = members;

            return View(viewModel);
        }
        public IActionResult Test()
        {
            return View();
        }
    }
}
