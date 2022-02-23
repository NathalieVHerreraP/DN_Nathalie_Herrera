﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymManager.Web.Models
{
    public class Member
    {
        
        public String Name { get; set; }

        public String LastName { get; set; }

        public DateTime Birthday { get; set; }

        public int CityId{ get; set; }

        public String Email{ get; set; }

        public bool AllowNewsletter{ get; set; }


    }
}