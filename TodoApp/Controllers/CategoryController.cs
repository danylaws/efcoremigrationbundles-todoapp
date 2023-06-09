using Microsoft.AspNetCore.Mvc;
using TodoApp.Core.BusinessServices;
using TodoApp.Domain.Entities;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _service.GetAllAsync());
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CategoryViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var category = new Category()
                {
                    Name = vm.Name
                };

                await _service.AddAsync(category);

                return RedirectToAction("Index");
            }

            return View();
        }
    }
}