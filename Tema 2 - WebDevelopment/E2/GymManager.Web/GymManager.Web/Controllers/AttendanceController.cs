using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymManager.Web.Controllers
{
    public class AttendanceController : Controller
    {
        public IActionResult MemberIn()
        {
            return View();
        }

        public IActionResult MemberOut() 
        {
            return View();
        }
    }
}
