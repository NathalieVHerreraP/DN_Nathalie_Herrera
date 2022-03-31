using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManager.Core.Products;
using GymManager.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;


namespace GymManager.ApplicationServices.Products
{
    public class EquipmentTypesAppService : iEquipmentTypesAppService
    {
        private readonly IRepository<int, EquipmentType> _repository;
        public EquipmentTypesAppService(IRepository<int, EquipmentType> repository)
        {
            _repository = repository;
        }
        public async Task<int> AddEquipmentAsync(EquipmentType equipment)
        {
            await _repository.AddAsync(equipment);
            return equipment.Id;
        }

        public async Task DeleteEquipmentAsync(int equipmentId)
        {
            await _repository.DeleteAsync(equipmentId);
        }

        public async Task EditEquipmentAsync(EquipmentType equipment)
        {
            await _repository.UpdateAsync(equipment);
        }

        public async Task<EquipmentType> GetEquipmentAsync(int equipmentId)
        {
            return await _repository.GetAsync(equipmentId);
        }

        public async Task<List<EquipmentType>> GetEquipmentsAsync()
        {
            return await _repository.GetAll().ToListAsync();
        }
    }
}
