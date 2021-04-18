using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMuzyka.Entities
{
    public class Track
    {
        public int Id { get; set; }
        public string ArtistName { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Duration { get; set; }


        public int AlbumId { get; set; }
        public virtual Album Album { get; set; }
    }
}
