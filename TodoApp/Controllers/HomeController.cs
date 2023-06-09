using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TodoApp.Core.BusinessServices;
using TodoApp.Domain.Entities;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITodoService _todoService;
        private readonly ICategoryService _categoryService;

        public HomeController(ITodoService todoService, ICategoryService categoryService)
        {
            _todoService = todoService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var tasks = await _todoService.GetAllAsync();
            return View(tasks);
        }

        public async Task<IActionResult> Add()
        {
            var vm = await EmptyTodoViewModel();
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Add(TodoViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var todo = new Todo()
                {
                    CategoryId = vm.CategoryId,
                    Title = vm.Title,
                    Description = vm.Description,
                    ScheduledFor = vm.ScheduledFor
                };

                await _todoService.AddAsync(todo);

                return RedirectToAction("Index");
            }

            return View(await EmptyTodoViewModel());
        }

        private async Task<TodoViewModel> EmptyTodoViewModel()
        {
            return new TodoViewModel()
            {
                Categories = await _categoryService.GetAllAsync(),
                ScheduledFor = DateTime.Today
            };
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}