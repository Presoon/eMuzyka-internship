using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMuzyka.Entities;

namespace eMuzyka.DTO.Provider
{
    public class ProviderDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }

        public List<AlbumDto> Albums { get; set; }
    }
}
