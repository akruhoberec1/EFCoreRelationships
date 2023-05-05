using EFCoreRelationships.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreRelationships.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleModelController : ControllerBase
    {
        private readonly DataContext _context;
        public VehicleModelController(DataContext context)  
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
    }
}
