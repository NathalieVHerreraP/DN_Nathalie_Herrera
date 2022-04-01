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

        public async Task<IActionResult> Index()
        {

            List<Member> members = await _memberAppService.GetMembersAsync();

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
        public async Task<IActionResult> Create(MemberViewModel viewModel)
        {

            Member member = new Member
            {
                Name = viewModel.Name,
                LastName = viewModel.LastName,
                Email = viewModel.Email,
                City = new City
                { 
                    Id = viewModel.CityId
                },
                Birthday = viewModel.Birthday,
                AllowNewsletter = viewModel.AllowNewsletter,
                Membersince = DateTime.Now

            };

            await _memberAppService.AddMemberAsync(member);

            return RedirectToAction("index");
        }

        public async Task<IActionResult> Delete(int  memberId)
        {

            await _memberAppService.DeleteMemberAsync(memberId);

            return RedirectToAction("index");
        }

        public async Task<IActionResult> Edit(int memberId)
        {

            Member member = await _memberAppService.GetMemberAsync(memberId);

            MemberViewModel viewModel = new MemberViewModel
            {
                AllowNewsletter = member.AllowNewsletter,
                Birthday = member.Birthday,
                CityId = member.City.Id,
                Email = member.Email,
                Id = member.Id,
                LastName = member.LastName,
                Name = member.Name
            };


            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Member member)
        {

            await _memberAppService.EditMemberAsync(member);

            return RedirectToAction("index");
        }


        public IActionResult Test()
        {
            return View();
        }
    }
}
