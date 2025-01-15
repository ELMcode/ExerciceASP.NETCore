using System.ComponentModel.DataAnnotations;

namespace ExerciceASP.NETCore.Models.ViewModels
{
    public class TodoViewModel
    {
        [Required(ErrorMessage = "Le titre est obligatoire")]
        [Display(Name = "Titre de la tâche")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "La description est obligatoire")]
        [Display(Name = "Description de la tâche")]
        public string Description { get; set; } = string.Empty;
    }
} 