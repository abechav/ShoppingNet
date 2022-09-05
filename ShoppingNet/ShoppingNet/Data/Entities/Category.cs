using System.ComponentModel.DataAnnotations;

namespace ShoppingNet.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name = "Categoría")]
        [MaxLength(100)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Name { get; set; }
    }
}
