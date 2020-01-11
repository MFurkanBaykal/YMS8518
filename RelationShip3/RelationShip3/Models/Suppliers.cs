using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RelationShip3.Models
{
    public class Supplier
    {
        public int Id { get; set; }

        [MaxLength(40)]
        public string CompanyName { get; set; }

        [MaxLength(30)]
        public string ContactName { get; set; }

        [MaxLength(30)]
        public string ContactTitle { get; set; }

        [MaxLength(60)]
        public string Address { get; set; }

        [MaxLength(15)]
        public string City { get; set; }

        [MaxLength(24)]
        public string Phone { get; set; }

        [MaxLength(24)]
        public string Fax { get; set; }

        public string HomePage { get; set; }

        public List<Product> Products { get; set; }
    }
}
