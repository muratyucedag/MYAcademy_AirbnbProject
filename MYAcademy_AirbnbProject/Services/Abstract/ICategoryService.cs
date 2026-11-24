using MYAcademy_AirbnbProject.Dtos.CategoryDtos;

namespace MYAcademy_AirbnbProject.Services.Abstract
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GetAllCategoriesAsync();
        Task<GetByIdCategoryDto> GetByIdCategoryAsync(string id);
        Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        Task DeleteCategoryAsync(string id);
        Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
    }
}
