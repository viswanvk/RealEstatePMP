using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RealEstatePMP.Models
{
    public class Agent
    {
        public int AgentId { get; set; }

        [DisplayName("First Name")]
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [DisplayName("Mobile Number")]
        [Phone]
        [Required]
        [RegularExpression("\\(?\\d{3}\\)?-? *\\d{3}-? *-?\\d{4}", ErrorMessage = "Please enter valid phone number")]

        public string PhoneNumber { get; set; }

        [DisplayName("Years of Experience")]
        public int? YearsOfExperience { get; set; }

        [DisplayName("Full Name")]
        public string FullName
        {
            get
            {     // CONCAT FIRST & LAST NAME
                return $"{FirstName} {LastName}";
            }
        }

        

        //RELATIONSHIPS

        public List<Dwelling> Dwellings { get; set; }

        [DisplayName("Sales office")]
        public SalesOffice SalesOffice { get; set; }
        
        [DisplayName("Sales office")]
        public int SalesOfficeId { get; set; }
    }
}
