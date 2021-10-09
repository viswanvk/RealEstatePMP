using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RealEstatePMP.Models
{
    public class SalesOffice
    {
        
        public int SalesOfficeId { get; set; }

        [DisplayName("Office Name")]
        [Required]
        [StringLength(200)]

        public string Name { get; set; }

        [DisplayName("Office Address")]
        [Required]
        [StringLength(200)]
        public string Address { get; set; }


        [DisplayName("Establishment Date")]
        [DataType(DataType.Date)]
        public DateTime? EstablishmentDate { get; set; }

        [DisplayName("Office Details")]
        public string OfficeDetail
        {
            get
            {     // CONCAT FIRST & LAST NAME
                return $"{Name} - {Address}";
            }
        }

        //RELATIONSHIPS
        public List<Agent> Agents { get; set; }

    }
}
