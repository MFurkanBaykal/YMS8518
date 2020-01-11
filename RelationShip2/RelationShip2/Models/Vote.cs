using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelationShip2.Models
{
    public class Vote
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
