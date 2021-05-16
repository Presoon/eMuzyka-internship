using System;


namespace eMuzyka.DTO.Track
{
    public class TrackDto
    {
        public int TrackNumber { get; set; }
        public string ArtistName { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Duration { get; set; }
    }
}
