using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RelationShip4.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required, MaxLength(15)]
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }

        public List<Product> Products { get; set; }

    }
}
