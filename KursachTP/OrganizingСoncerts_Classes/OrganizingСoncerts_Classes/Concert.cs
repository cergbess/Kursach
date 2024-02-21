using System.ComponentModel.DataAnnotations;

namespace OrganizingСoncerts_Classes
{
    public class Concert
    {
        [Key]
        public int ConcertId { get; set; }
        public int ArtistId { get; set; }
        public int SceneId { get; set; }
        public string? ConcertTitle { get; set; }
        public DateTime DateOfEvent { get; set; }
        public decimal TicketPrice { get; set; }
        public int NumberOfViewers { get; set; }
    }
}
