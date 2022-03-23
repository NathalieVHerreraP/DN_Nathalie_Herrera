using GymManager.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.DataAccess
{
    public interface iProceduresCall
    {
        public List<ProductTypes> GetInventory(int productId);

        public List<Members> GetNewMembers();

        public void NewSale(NewSaleIds newSaleIds);
    }
}
