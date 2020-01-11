using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelationShip3.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public double UnitPrice { get; set; }

        public short Quentity { get; set; }

        public double Discount { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
