using GymManager.ApplicationServices.Members;
using GymManager.Core.Members;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serilog;

namespace GymManager.Web.Controllers
{
    [Authorize]
    public class MembersController : Controller
    {
        private readonly iMembersAppService _memberAppService;
        private readonly ILogger _logger;

        public MembersController(iMembersAppService memberAppService, ILogger logger)
        {
            _memberAppService = memberAppService;
            _logger = logger;

            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public IActionResult Index()
        {

            List<Member> members = _memberAppService.GetMembers();

            MemberListViewModel viewModel = new MemberListViewModel();

            viewModel.NewMembersCount = 2;
            viewModel.Members = members;
            _logger.Information("Member index was acceded");
            return View(viewModel);
        }

        public IActionResult Create() {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Member member)
        {

            _memberAppService.AddMember(member);

            return RedirectToAction("index");
        }

        public IActionResult Delete(int  memberId)
        {

            _memberAppService.DeleteMember(memberId);

            return RedirectToAction("index");
        }

        public IActionResult Edit(int memberId)
        {

            Member member = _memberAppService.GetMember(memberId);

           
            return View(member);
        }

        [HttpPost]
        public IActionResult Edit(Member member)
        {

            _memberAppService.EditMember(member);

            return RedirectToAction("index");
        }


        public IActionResult Test()
        {
            return View();
        }
    }
}
