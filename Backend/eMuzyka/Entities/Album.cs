using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace eMuzyka.Entities
{
    public class Album
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public string Version { get; set; }
        public DateTime ReleaseDate { get; set; }


        public int ProviderId { get; set; }
        public virtual Provider Provider { get; set; }
        

        public virtual List<Track> Tracks { get; set; }
        
    }
}
