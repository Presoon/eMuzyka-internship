using System;

namespace eMuzyka.DTO.Album
{
    public class AlbumDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public string Version { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}