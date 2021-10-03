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
        [StringLength(50)]

        public string Name { get; set; }

        [DisplayName("Office Address")]
        [Required]
        [StringLength(50)]
        public string Address { get; set; }


        [DisplayName("Establishment Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime? EstablishmentDate { get; set; }
        public List<Agent> Agents { get; set; }

    }
}
