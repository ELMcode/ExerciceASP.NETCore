using Microsoft.AspNetCore.Mvc;
using ExerciceASP.NETCore.Models;
using ExerciceASP.NETCore.Models.Repositories;
using ExerciceASP.NETCore.Models.ViewModels;

namespace ExerciceASP.NETCore.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoRepository _todoRepository;

        public TodoController(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        // GET: Todo
        public IActionResult Index()
        {
            var todos = _todoRepository.GetAll();
            return View(todos);
        }

        // GET: Todo/Form
        public IActionResult Form()
        {
            return View(new TodoViewModel());
        }

        // POST: Todo/Add
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add([Bind("Title,Description")] TodoViewModel model)
        {
            if (ModelState.IsValid)
            {
                var todo = new Todo
                {
                    Title = model.Title,
                    Description = model.Description,
                    IsCompleted = false
                };
                _todoRepository.Add(todo);
                return RedirectToAction(nameof(Index));
            }
            return View("Form", model);
        }

        // POST: Todo/ToggleComplete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ToggleComplete(int id)
        {
            var todo = _todoRepository.GetById(id);
            if (todo != null)
            {
                todo.IsCompleted = !todo.IsCompleted;
                _todoRepository.Update(todo);
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: Todo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _todoRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
