using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Member 
    {

        public int ID { get; set; }

        [RegularExpression(@"^[A-Z]+[a-z\s]*$")]
        [StringLength(30, MinimumLength = 3)]
        [Display(Name = "Nume utilizator")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Telefon")]

        [RegularExpression(@"^\(?([0-9]{4})\)?[-. ]?([0-9]{3})[-. ]?([09]{3})$", ErrorMessage = "Telefonul trebuie sa fie de forma '0722-123-123' sa'0722.123.123' sau '0722 123 123'")] 
        public string Phone { get; set; }

        [Display(Name = "Oraș")]
        public string City { get; set; }

        public ICollection<Adoptionrequest>? Adoptionrequests { get; set; }

    }
}
