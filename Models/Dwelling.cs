using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;



namespace RealEstatePMP.Models
{
    public class Dwelling
    {
        public int DwellingId { get; set; }
        [DisplayName("Appartment Number")]
        [Required]
        [Range(0,50000)]
        public int ApartmentNumber { get; set; }
        [DisplayName("Building Name")]
        public string? BuildingName { get; set; }
        [DisplayName("Street Name")]
        [Required]
        [StringLength(100)]
        public string Street { get; set; }
        [DisplayName("City Name")]
        [Required]
        [StringLength(50)]
        public string CityName { get; set; }
        [DisplayName("State")]
        [Required]
        [StringLength(20)]
        public string State { get; set; }
        [DisplayName("Zip Code")]
        [Required]
        public int ZipCode { get; set; }
        [DisplayName("Description")]
        [Required]
        [StringLength(500)]
        public string Description { get; set; }
        [DisplayName("Number of Bedrooms")]
        [Range(1,20)]
        [Required]
        public int NoOfBed { get; set; }
        [DisplayName("Number of Bathrooms")]
        [Required]
        [Range(1,20)]
        public int NoOfBath { get; set; }
        [DisplayName("Dishwasher Availbility")]
        public bool Dishwasher { get; set; }
        [DisplayName("Laundry Availbility")]
        public bool Laundry { get; set; }
        [DisplayName("Parking Availbility")]
        public bool Parking { get; set; }
        [DisplayName("Utilities Included")]
        public bool UtilitiesIncluded { get; set; }
        [DisplayName("Dwelling Availbility")]
        public bool Availability { get; set; }
        [DisplayName("Available From")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime? AvailableDate { get; set; }
        [DisplayName("Price")]
        public decimal? Price { get; set; }
        [DisplayName("Rent Per Month ")]
        public decimal? RentPerMonth { get; set; }
        



        //RELATIONSHIPS
        public Agent Agent { get; set; }
        [DisplayName("Agent")]
        public int AgentId { get; set; }
        public City City { get; set; }
        [DisplayName("City")]
        public int CityId { get; set; }

    }
}
