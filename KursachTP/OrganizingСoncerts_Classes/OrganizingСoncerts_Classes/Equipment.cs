using System.ComponentModel.DataAnnotations;

namespace OrganizingСoncerts_Classes
{
    public class Equipment
    {
        [Key]
        public int EquipmentId { get; set; }
        public int SceneId { get; set; }
        public string? NameOfEquipment { get; set; }
        public int AmountOfEquipment { get; set; }
        public string? TypeOfEquipment { get; set; }
        public decimal EquipmentPrice { get; set; }
    }
}
