using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RelationShip4.Models
{
    public class Customer
    {
        [Required, MaxLength(5)]
        public string Id { get; set; }
        [Required, MaxLength(40)]
        public string CompanyName { get; set; }
        [Required, MaxLength(30)]
        public string ContactName { get; set; }
        [Required, MaxLength(30)]
        public string ContactTitle { get; set; }
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
        public string Phone { get; set; }
        [Required, MaxLength(24)]
        public string Fax { get; set; }

        public List<Order> Orders { get; set; }

        
    }
}
