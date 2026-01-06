using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class User
    {
        public int ID { get; set; }

        [Display(Name = "Nume utilizator")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Telefon")]
        public string Phone { get; set; }

        [Display(Name = "Oraș")]
        public string City { get; set; }

        public ICollection<Adoptionrequest>? Adoptionrequests { get; set; }

    }
}
