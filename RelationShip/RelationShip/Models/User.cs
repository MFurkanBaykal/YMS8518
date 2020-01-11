using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelationShip.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Personal Personal { get; set; }
        public List<Address> Addresses { get; set; }

    }
}
