using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Animal
    {
        public int ID { get; set; }
        [Display(Name = "Nume")]
        public string Name { get; set; }
        [Display(Name = "Specie")]
        
        public string Breed { get; set; }
        [Display(Name = "Vârsta")]
        public int Age { get; set; }
        [Display(Name = "Oraș")]
        public string City { get; set; }

        [Display(Name = "Status")]
        public string Status { get; set; }
        public int? ShelterID { get; set; }
        [Display(Name = "Adapost")]
        public Shelter? Shelter { get; set; }

        // 🔗 RELAȚIE SIMPLĂ
        [Display(Name = "Categorie")]
        public int? CategoryID { get; set; }

        public Category? Category { get; set; }

    }
}
