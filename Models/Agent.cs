using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstatePMP.Models
{
    public class Agent
    {

        public int AgentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int? YearsOfExperience { get; set; }
        public List<Dwelling> Dwellings { get; set; }
        public SalesOffice SalesOffice { get; set; }
        public int SalesOfficeId { get; set; }

    }
}
