using System.Collections.Generic;
using System.Linq;
using ExerciceASP.NETCore.Models;

namespace ExerciceASP.NETCore.Models.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private readonly TodoContext _context;

        public TodoRepository(TodoContext context)
        {
            _context = context;
        }

        public IEnumerable<Todo> GetAll()
        {
            return _context.Todos.ToList();
        }

        public Todo? GetById(int id)
        {
            return _context.Todos.Find(id);
        }

        public void Add(Todo todo)
        {
            _context.Todos.Add(todo);
            _context.SaveChanges();
        }

        public void Update(Todo todo)
        {
            _context.Todos.Update(todo);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var todo = _context.Todos.Find(id);
            if (todo != null)
            {
                _context.Todos.Remove(todo);
                _context.SaveChanges();
            }
        }
    }
} 