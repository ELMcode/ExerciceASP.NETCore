using Microsoft.EntityFrameworkCore;

namespace ExerciceASP.NETCore.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TodoContext(serviceProvider.GetRequiredService<DbContextOptions<TodoContext>>()))
            {
                if (context.Todos.Any())
                {
                    return;
                }

                context.Todos.AddRange(
                    new Todo
                    {
                        Title = "Rangement",
                        Description = "Préparer le salon",
                        IsCompleted = true
                    },
                    new Todo
                    {
                        Title = "Promenade",
                        Description = "Promener le chien",
                        IsCompleted = true
                    },
                    new Todo
                    {
                        Title = "Courses",
                        Description = "Acheter des trucs pour la semaine",
                        IsCompleted = false
                    },
                    new Todo
                    {
                        Title = "Révisions",
                        Description = "Réviser le cours ASP.NET",
                        IsCompleted = false
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
