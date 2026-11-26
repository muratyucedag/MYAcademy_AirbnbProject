using Microsoft.AspNetCore.Mvc;
using MYAcademy_AirbnbProject.Dtos.CategoryDtos;
using MYAcademy_AirbnbProject.Services.Abstract;

namespace MYAcademy_AirbnbProject.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        
        //public CategoryController(ICategoryService categoryService)
        //{
        //    _categoryService = categoryService;
        //}
        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            await _categoryService.CreateCategoryAsync(createCategoryDto);
            return RedirectToAction("CategoryList");
        }

        public async Task<IActionResult> CategoryList()
        {
            return View();
        }
    }
}
