using System.ComponentModel.DataAnnotations;

namespace OrganizingСoncerts_Classes
{
    public class Artist
    {
        [Key]
        public int ArtistId { get; set; }
        public string? FullNameOfArtist { get; set; }
        public string? FullNameOfManager { get; set; }
        public string? ContactForCommunication { get; set; }
        public int PopularityIndex { get; set; }
        public decimal FeeAmount { get; set; }

    }
}
