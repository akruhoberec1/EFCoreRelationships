namespace EFCoreRelationships.Models
{
    public class VehicleMake
    {
        public int Id { get; set; }
        public List<VehicleModel>? VehicleModels { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Abrv { get; set; }= string.Empty;

    }
}
