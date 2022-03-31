﻿using GymManager.Core.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.Navegation
{
    public class MenuAppService : iMenuAppService
    {
        public List<UserMenuItem> GetMenu()
        {

            List<UserMenuItem> menu = new List<UserMenuItem>();
            menu.Add(new UserMenuItem 
            {
                Name = "Home",
                DisplayName = "Home",
                Order = 0,
                Url = "/"
            });

            menu.Add(new UserMenuItem 
            {
                Name = "Administration",
                DisplayName = "Administration",
                Order = 1,
                Url = "#",
                Items = new List<UserMenuItem>() 
                {
                    new UserMenuItem
                    {
                        Name = "MembershipTypes",
                        DisplayName = "Membership Types",
                        Order = 0,
                        Url = "/MembershipTypes/"
                    },
                    new UserMenuItem
                    {
                        Name = "InventoryUnits",
                        DisplayName = "Inventory Units",
                        Order = 1,
                        Url = "/InventoryUnits/"
                    },
                    new UserMenuItem
                    {
                        Name = "EquipmentTypes",
                        DisplayName = "Equipment Types",
                        Order = 2,
                        Url = "/EquipmentTypes/"
                    },
                    new UserMenuItem
                    {
                        Name = "EquipmentInventory",
                        DisplayName = "Equipment Inventory",
                        Order = 3,
                        Url = "/EquipmentInventory/"
                    }
                }
            });

            menu.Add(new UserMenuItem
            {
                Name = "Store",
                DisplayName = "Store",
                Order = 2,
                Url = "#",
                Items = new List<UserMenuItem> 
                { 
                    new UserMenuItem
                    {
                        Name = "Shopping",
                        DisplayName = "Shopping",
                        Order = 0,
                        Url = "/Shopping/"
                    },
                    new UserMenuItem
                    {
                        Name = "ProductInventory",
                        DisplayName = "Inventory",
                        Order = 1,
                        Url = "/ProductInventory/"
                    },
                    new UserMenuItem
                    {
                        Name = "ProductTypes",
                        DisplayName = "Product",
                        Order = 2,
                        Url = "/Product/"
                    },
                    new UserMenuItem
                    {
                        Name = "ProductCategories",
                        DisplayName = "Product Categories",
                        Order = 3,
                        Url = "/ProductCategories/"
                    },
                }
            });

            menu.Add(new UserMenuItem
            {
                Name = "Members",
                DisplayName = "Members",
                Order = 3,
                Url = "#",
                Items = new List<UserMenuItem>() 
                { 
                    new UserMenuItem
                     {
                        Name = "MembersManagement",
                        DisplayName = "Management",
                        Order = 0,
                        Url = "/Members/"
                    },
                    new UserMenuItem
                     {
                        Name = "MembersShipRenwal",
                        DisplayName = "MembersShipRenwal",
                        Order = 1,
                        Url = "/MembersShip/Renwal"
                    },               
                    new UserMenuItem
                     {
                        Name = "CheckIn",
                        DisplayName = "CheckIn",
                        Order = 2,
                        Url = "/MembersShip/CheckIn"
                    },
                    new UserMenuItem
                     {
                        Name = "CheckOut",
                        DisplayName = "CheckOut",
                        Order = 3,
                        Url = "/MembersShip/CheckOut"
                    },


                }
            });

            menu.Add(new UserMenuItem
            {
                Name = "Invoicing",
                DisplayName = "Invoicing",
                Order = 4,
                Url = "/Invoicing"
            });

            menu.Add(new UserMenuItem
            {
                Name = "Reports",
                DisplayName = "Reports",
                Order = 5,
                Url = "#",
                Items = new List<UserMenuItem>() 
                {
                     new UserMenuItem
                    {
                        Name = "NewMembersReport",
                        DisplayName = "New Members",
                        Order = 0,
                        Url = "/Reports/NewMembers"
                    },
                      new UserMenuItem
                    {
                        Name = "AttendanceReport",
                        DisplayName = "Attendance",
                        Order = 1,
                        Url = "/Reports/Attendance"
                    },
                       new UserMenuItem
                    {
                        Name = "MembershipRenewalReport",
                        DisplayName = "Attendance",
                        Order = 2,
                        Url = "/Reports/Attendance"
                    },
                }
            });

            return menu;
        }
    }
}
