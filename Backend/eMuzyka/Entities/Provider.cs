using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMuzyka.Entities
{
    public class Provider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual List<Album> Albums { get; set; }
    }
}
