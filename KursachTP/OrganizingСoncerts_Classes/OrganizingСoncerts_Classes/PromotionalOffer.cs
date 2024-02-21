using System.ComponentModel.DataAnnotations;

namespace OrganizingСoncerts_Classes
{
    public class PromotionalOffer
    {
        [Key]
        public int PromotionalOfferId { get; set; }
        public decimal PriceOfPromotionalOffer { get; set; }
        public int AdvertisingDisplayTime { get; set; }
        public string? AdvertisingOnInternet { get; set; }
        public string? AdvertisingOnTv { get; set; }
        public string? AdvertisingOnRadio { get; set; }
        public string? BannersPostersFlyers { get; set; }
    }
}
