using System.ComponentModel.DataAnnotations;

namespace OrganizingСoncerts_Classes
{
    public class Scene
    {
        [Key]
        public int SceneId { get; set; }
        public string? SceneName { get; set; }
        public decimal PricePerPerformance { get; set; }
        public double StageArea { get; set; }
        public int NumberOfSeats { get; set; }
        public string? AvailabilityOfSpecialEfectsAndDecorations { get; set; }
        public int NumberOfSoundSystems { get; set; }
        public int NumberOfLuminaires { get; set; }
    }
}
