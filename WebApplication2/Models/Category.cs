using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Category
    {
        public int ID { get; set; }

        [Display(Name = "Categorie")]
        public string Name { get; set; }
    }

}

