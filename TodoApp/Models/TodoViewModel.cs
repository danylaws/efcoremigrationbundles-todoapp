using System.ComponentModel.DataAnnotations;
using TodoApp.Domain.Entities;

namespace TodoApp.Models
{
    public class TodoViewModel
    {
        [Required]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Category")]
        public string CategoryId { get; set; }

        public string? Description { get; set; }
        public DateTime ScheduledFor { get; set; }
        public IEnumerable<Category> Categories { get; set; } = new List<Category>();
    }
}