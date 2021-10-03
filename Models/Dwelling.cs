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

        [DisplayName("Appartment Name")]
        [Required]
        [StringLength(50)]
        public int ApartmentNumber { get; set; }

        [DisplayName("Street Name")]
        [Required]
        [StringLength(50)]
        public string Street { get; set; }

        [DisplayName("City Name")]
        [Required]
        [StringLength(50)]
        public string CityName { get; set; }

       
        [Required]
        [StringLength(20)]
        public string State { get; set; }

        [DisplayName("Zip Code")]
        [Required]
        [StringLength(11)]
        public int ZipCode { get; set; }


        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [DisplayName("Number of Bedrooms")]
        [StringLength(10)]

        public int NoOfBed { get; set; }

        [DisplayName("Number of Bathrooms")]
        [Required]
        [StringLength(10)]
        public int NoOfBath { get; set; }

        [DisplayName("Dishwasher Availble?")]
        [Required]
       
        public bool? Dishwasher { get; set; }

        [DisplayName("Laundry Availble?")]
        [Required]
        public bool? Laundry { get; set; }

        [DisplayName("Parking Availble?")]
        [Required]
        public bool? Parking { get; set; }


        [DisplayName("Parking Availble?")]
        [Required]
        public bool? Availability { get; set; }


        [DisplayName("Available From")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime? AvailableDate { get; set; }

        [DisplayName("Utilities Included ")]
        [Required]
        public bool? UtilitiesIncluded { get; set; }

        
        public decimal? Price { get; set; }

        [DisplayName("Rent Per Month ")]
        [Required]
        public decimal? RentPerMonth { get; set; }

              public Agent Agent { get; set; }
        
        public int AgentId { get; set; }
        
       public City City { get; set; }

        public int CityId { get; set; }

        [DisplayName("Building Name")]

        public string? BuildingName { get; set; }
    }
}
