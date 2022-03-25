using DataAccess.Example.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Example.EntityFrmwork
{
    public interface IVehiclesDataManager
    {
        public void Insert(Vehicle vehicle);

        public void Update(Vehicle vehicle);

        public Vehicle Get(int id);

        public List<Vehicle> GetAll();

        public void Delete(int id);
    }
}
