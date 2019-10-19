using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class TodoItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(10, ErrorMessage = "Nome inválido")]
        public string Name { get; set; }

        [Required]
        public bool IsComplete { get; set; }
    }
}