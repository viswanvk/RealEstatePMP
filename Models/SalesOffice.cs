using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstatePMP.Models
{
    public class SalesOffice
    {

        public int SalesOfficeId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime? EstablishmentDate { get; set; }
        public List<Agent> Agents { get; set; }

    }
}
