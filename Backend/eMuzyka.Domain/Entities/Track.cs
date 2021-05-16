using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eMuzyka.Domain.Entities
{
    public class Track
    {
        public int Id { get; set; }
        public int TrackNumber { get; set; }
        public string ArtistName { get; set; }
        public string Title { get; set; }
        [Column(TypeName = "Date")]
        public DateTime ReleaseDate { get; set; }
        public int Duration { get; set; }


        public int AlbumId { get; set; }
        public virtual Album Album { get; set; }
    }
}
