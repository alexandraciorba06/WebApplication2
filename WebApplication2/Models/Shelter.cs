using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Shelter
    {
        public int ID { get; set; }

        [Display(Name = "Nume Adăpost")]
        public string Name { get; set; }

        [Display(Name = "Adresă")]
        public string Address { get; set; }

        [Display(Name = "Oraș")]
        public string City { get; set; }

        [Display(Name = "Telefon")]
        public string Phone { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        public ICollection<Animal>? Animals { get; set; }


        ///dbhdb
    }
}
