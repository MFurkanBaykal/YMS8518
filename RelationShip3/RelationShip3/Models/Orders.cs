using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RelationShip3.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime RequiredDate { get; set; }

        public DateTime ShippedDate { get; set; }

        public int ShipVia { get; set; }

        public double Freight { get; set; }

        [MaxLength(40)]
        public string ShipName { get; set; }

        [MaxLength(40)]
        public string ShipAddress { get; set; }

        [MaxLength(40)]
        public string ShipCiy { get; set; }

        [MaxLength(40)]
        public string ShipRegion { get; set; }

        [MaxLength(40)]
        public string ShipPostalCode { get; set; }

        [MaxLength(40)]
        public string ShipCountry { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
