using GymManager.Core.Members;
using GymManager.Core.Products;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.DataAccess
{
    public class GymManagerContext : DbContext
    {
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<MembershipType> MembershipTypes { get; set; }

        public virtual DbSet<EquipmentType> EquipmentTypes { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<MeasureType> MeasureTypes { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }


        public GymManagerContext(DbContextOptions<GymManagerContext> options) : base(options) 
        {
        }
    }
}
