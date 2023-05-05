using EFCoreRelationships.Models;
using EFCoreRelationships.Services.VehicleService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreRelationships.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleModelController : ControllerBase
    {
        private readonly DataContext _context;
        public VehicleModelController(DataContext context, IVehicleService vehicleService)  
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<VehicleModel>>> Get(int VehicleMakeId)
        {
            var models = await _context.VehicleModels
                .Where(mo => mo.VehicleMakeId == VehicleMakeId)
                .ToListAsync();

            return models;
        }

        [HttpPost]
        public async Task<ActionResult<List<VehicleModel>>> Create(CreateVehicleModelsDTO request)
        {
            var makes = await _context.VehicleMakes.FindAsync(request.VehicleMakeId);
            if(makes == null) { return NotFound(); }

            var newVehicleModel = new VehicleModel
            {
                Name = request.Name,
                Abrv = request.Abrv,
                VehicleMake = makes
            };

            _context.VehicleModels.Add(newVehicleModel);   
            await _context.SaveChangesAsync();  
            return await Get(newVehicleModel.VehicleMakeId);
        }
    }
}
