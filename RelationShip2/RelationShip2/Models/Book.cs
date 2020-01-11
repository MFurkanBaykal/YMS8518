using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelationShip2.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Page> Pages { get; set; }
        
        public Vote Vote { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
