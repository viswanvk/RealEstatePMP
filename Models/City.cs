using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstatePMP.Models
{
    public class City
    {

        public int CityId { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public List<Dwelling> Dwellings { get; set; }

    }
}
