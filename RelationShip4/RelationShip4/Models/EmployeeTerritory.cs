using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RelationShip4.Models
{
    public class EmployeeTerritory
    {
        [Key]
        [Required, MaxLength(20)]
        public string TerritoryId { get; set; }
      
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        public Territory Territory { get; set; }
    }
}
