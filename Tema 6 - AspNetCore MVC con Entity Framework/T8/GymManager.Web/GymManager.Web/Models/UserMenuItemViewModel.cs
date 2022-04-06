using GymManager.Core.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymManager.Web.Models
{
    public class UserMenuItemViewModel
    {

        public UserMenuItem MenuItem { get; set; }

        public string CurrentPageName { get; set; }

        public int ItemDepth { get; set; }

        public bool RootLevel { get; set; }

    }
}
