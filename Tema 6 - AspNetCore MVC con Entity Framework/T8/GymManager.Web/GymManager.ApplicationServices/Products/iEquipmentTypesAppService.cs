using GymManager.Core.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.Products
{
    public interface iEquipmentTypesAppService
    {
        Task<List<EquipmentType>> GetEquipmentsAsync();

        Task<int> AddEquipmentAsync(EquipmentType equipment);

        Task DeleteEquipmentAsync(int memberId);

        Task<EquipmentType> GetEquipmentAsync(int equipmentId);

        Task EditEquipmentAsync(EquipmentType equipmentId);
    }
}
