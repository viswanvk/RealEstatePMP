using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RealEstatePMP.Models
{
    public class City
    {

        public int CityId { get; set; }

        [DisplayName("City")]
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [DisplayName("State")]
        [Required]
        [StringLength(50)]
        public string State { get; set; }
        public List<Dwelling> Dwellings { get; set; }

    }
}
