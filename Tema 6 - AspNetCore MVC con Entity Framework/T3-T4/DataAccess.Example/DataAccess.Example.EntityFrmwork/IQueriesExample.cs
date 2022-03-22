using DataAccess.Example.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Example.EntityFrmwork
{
    public interface IQueriesExample
    {
        public List<Make> GetMakes();
        public List<Vehicle> GetVehiclesPrice(decimal from, decimal to);
    }
}
