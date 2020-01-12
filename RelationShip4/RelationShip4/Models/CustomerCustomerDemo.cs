using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RelationShip4.Models
{
    public class CustomerCustomerDemo
    {
        [Key, Column(Order = 1), Required, MaxLength(10)]
        public string CustomerTypeId { get; set; }

        [Key, Column(Order = 2), Required, MaxLength(5)]
        public string CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        public CustomerDemographic CustomerDemographic { get; set; }


    }
}
