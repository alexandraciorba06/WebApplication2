using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Adoptionrequest
    {
        public int ID { get; set; }

        [Display(Name = "Animal ID")]
        public int AnimalID { get; set; }

        [Display(Name = "User ID")]
        public int UserID { get; set; }

        [Display(Name = "Data cererii")]
        [DataType(DataType.Date)]
        public DateTime RequestDate { get; set; }
    }
}
