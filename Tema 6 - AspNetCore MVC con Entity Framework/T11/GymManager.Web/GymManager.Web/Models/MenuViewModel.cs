using GymManager.Core.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymManager.Web.Models
{
    public class MenuViewModel
    {
        public string CurrentPageName { get; set; }

        public List<UserMenuItem> Menu { get; set; }
    }
}
