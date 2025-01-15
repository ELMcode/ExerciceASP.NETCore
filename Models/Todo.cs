using System.ComponentModel.DataAnnotations;

namespace ExerciceASP.NETCore.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [Display(Name = "Task Title")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Description is required")]
        [Display(Name = "Task Description")]
        public string Description { get; set; } = string.Empty;

        public bool IsCompleted { get; set; }
    }
} 