using EFCoreRelationships.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreRelationships.Services.VehicleService
{
    public class VehicleService : IVehicleService
    {
        public Task<ActionResult<List<VehicleModel>>> Get(int VehicleMakeId)
        {
            throw new NotImplementedException();
        }

        public ActionResult<List<VehicleModel>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
