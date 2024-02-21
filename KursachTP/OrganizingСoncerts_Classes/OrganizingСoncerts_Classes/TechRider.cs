using System.ComponentModel.DataAnnotations;

namespace OrganizingСoncerts_Classes
{
    public class TechRider
    {
        [Key]
        public int TechRiderId { get; set; }
        public int ArtistId { get; set; }
        public string? ConcertTitle { get; set; }
        public double StageArea { get; set; }
        public string? AvailabilityOfSpecialEfectsAndDecorations { get; set; }
        public int NumberOfSoundSystems { get; set; }
        public int NumberOfLuminaires { get; set; }
        public int NumberOfEmployees { get; set; }
        public decimal MaximumAmountOfCosts { get; set; }

    }
}
