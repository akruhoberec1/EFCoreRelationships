﻿using System.Text.Json.Serialization;

namespace EFCoreRelationships.Models
{
    public class VehicleModel
    {
        public int Id { get; set; }
        [JsonIgnore]
        public VehicleMake VehicleMake { get; set; }    
        public int VehicleMakeId { get; set; } 
        public string Name { get; set; } = string.Empty;
        public string Abrv { get; set; } = string.Empty;
    }
}
