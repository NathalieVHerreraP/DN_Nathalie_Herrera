using GymManager.ApplicationServices.Products;
using GymManager.Core.Products;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymManager.Web.Controllers
{
    public class EquipmentTypesController : Controller
    {
        private readonly iEquipmentTypesAppService _equipmentAppService;

        public EquipmentTypesController(iEquipmentTypesAppService equipmentAppService)
        {
            _equipmentAppService = equipmentAppService;

        }

        public async Task<IActionResult> Index()
        {

            List<EquipmentType> equipment = await _equipmentAppService.GetEquipmentsAsync();

            EquipmentTypeListViewModel equipmentType = new EquipmentTypeListViewModel();

            equipmentType.EquipmentTypes = equipment;

            return View(equipmentType);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(EquipmentType equipment)
        {



            await _equipmentAppService.AddEquipmentAsync(equipment);

            return RedirectToAction("index");
        }

        public async Task<IActionResult> Delete(int equipmentId)
        {

            await _equipmentAppService.DeleteEquipmentAsync(equipmentId);

            return RedirectToAction("index");
        }

        public async Task<IActionResult> Edit(int equipmentId)
        {

            EquipmentType equipment = await _equipmentAppService.GetEquipmentAsync(equipmentId);

            EquipmentTypeViewModel equipmentType = new EquipmentTypeViewModel 
            { 
                Id = equipment.Id,
                Name = equipment.Name,
                Brand = equipment.Brand,
                Cost = equipment.Cost,
                Units = equipment.Units
            };



            return View(equipmentType);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EquipmentType equipment)
        {

            await _equipmentAppService.EditEquipmentAsync(equipment);

            return RedirectToAction("index");
        }
    }
}
