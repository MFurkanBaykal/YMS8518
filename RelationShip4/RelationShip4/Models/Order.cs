using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RelationShip4.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int ShipVia { get; set; }
        public decimal Freight { get; set; }

        [Required, MaxLength(40)]
        public string ShipName { get; set; }
        [Required, MaxLength(60)]
        public string ShipAddress { get; set; }
        [Required, MaxLength(15)]
        public string ShipCity { get; set; }
        [Required, MaxLength(15)]
        public string ShipRegion { get; set; }
        [Required, MaxLength(10)]
        public string ShipPostalCode { get; set; }
        [Required, MaxLength(15)]
        public string ShipCountry { get; set; }

       public List<OrderDetail> OrderDetails { get; set; }

        public string CustomerId { get; set; }
        public Customer Customer { get; set; }

        //SHIPPER ID VARMI BİLMİYOZ K0NTROL

        public int ShipperId { get; set; }
        public Shipper Shipper { get; set; }

        [Required, MaxLength(5)]

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
    }
}
