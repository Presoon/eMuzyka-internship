using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMuzyka.DTO.Track
{
    public class TrackDto
    {
        public int Id { get; set; }
        public int TrackNumber { get; set; }
        public string ArtistName { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Duration { get; set; }
    }
}
