using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstatePMP.Models
{
    public class Dwelling
    {

        public int DwellingId { get; set; }
        public int ApartmentNumber { get; set; }
        public string Street { get; set; }
        public string CityName { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string Description { get; set; }
        public int NoOfBed { get; set; }
        public int NoOfBath { get; set; }
        public bool? Dishwasher { get; set; }
        public bool? Laundry { get; set; }
        public bool? Parking { get; set; }
        public bool? Availability { get; set; }
        public DateTime? AvailableDate { get; set; }
        public bool? UtilitiesIncluded { get; set; }
        public decimal? Price { get; set; }
        public decimal? RentPerMonth { get; set; }
        public Agent Agent { get; set; }
        public int AgentId { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public string? BuildingName { get; set; }
    }
}
