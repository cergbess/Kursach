using System.ComponentModel.DataAnnotations;

namespace OrganizingСoncerts_Classes
{
    public class AdvertisingCampaign
    {
        [Key]
        public int AdvertisingCampaignId { get; set; }
        public int ConcertId { get; set; }
        public int PromotionalOfferId { get; set; }
        public DateTime StartDateOfAdvertisingCampaign { get; set; }
    }
}
