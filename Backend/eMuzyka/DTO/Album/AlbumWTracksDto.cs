using System;
using System.Collections.Generic;
using eMuzyka.DTO.Track;

namespace eMuzyka.DTO.Album
{
    public class AlbumWTracksDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public string Version { get; set; }
        public DateTime ReleaseDate { get; set; }

        public List<TrackDto> Tracks { get; set; }
    }
}