using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models
{
    public class CategoryViewModel
    {
        [Required]
        public string Name { get; set; }
    }
}