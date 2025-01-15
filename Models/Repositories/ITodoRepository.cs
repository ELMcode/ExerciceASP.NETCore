using System.Collections.Generic;

namespace ExerciceASP.NETCore.Models.Repositories
{
    public interface ITodoRepository
    {
        IEnumerable<Todo> GetAll();
        Todo? GetById(int id);
        void Add(Todo todo);
        void Update(Todo todo);
        void Delete(int id);
    }
} 