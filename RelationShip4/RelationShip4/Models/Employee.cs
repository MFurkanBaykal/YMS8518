using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RelationShip4.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required, MaxLength(20)]
        public string LastName { get; set; }
        [Required, MaxLength(10)]
        public string FirstName { get; set; }
        [Required, MaxLength(30)]
        public string Title { get; set; }
        [Required, MaxLength(25)]
        public string TitleOfCourtesy { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }

        [Required, MaxLength(60)]
        public string Address { get; set; }
        [Required, MaxLength(15)]
        public string City { get; set; }
        [Required, MaxLength(15)]
        public string Region { get; set; }
        [Required, MaxLength(10)]
        public string PostalCode { get; set; }
        [Required, MaxLength(15)]
        public string Country { get; set; }
        [Required, MaxLength(24)]
        public string HomePhone { get; set; }
        [Required, MaxLength(4)]
        public string Extension { get; set; }
        public byte[] Image { get; set; }

        public string Notes { get; set; }

        public int? ReportsTo { get; set; }
        [ForeignKey("ReportsTo")]
        public Employee ReportsToEmployee { get; set; }

        [Required, MaxLength(255)]
        public string PhotoPath { get; set; }



        public List<EmployeeTerritory> EmployeeTerritories { get; set; }

        public List<Order> Orders { get; set; }


        // KENDİNE DÖNÜYO
    }
}
