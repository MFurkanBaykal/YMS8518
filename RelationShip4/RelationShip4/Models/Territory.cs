using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RelationShip4.Models
{
    public class Territory
    {
        [Required, MaxLength(20)]
        public string Id { get; set; }
        [Required, MaxLength(50)]
        public string TerritoryDescription { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; }

        public List<EmployeeTerritory> EmployeeTerritories { get; set; }
    }
}
