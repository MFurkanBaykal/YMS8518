using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RelationShip4.Models
{
    public class Region
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string RegionDescription { get; set; }
        public List<Territory> Territories { get; set; }
    }
}
