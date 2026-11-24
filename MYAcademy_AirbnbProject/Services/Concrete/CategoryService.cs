using AutoMapper;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MYAcademy_AirbnbProject.Dtos.CategoryDtos;
using MYAcademy_AirbnbProject.Entities;
using MYAcademy_AirbnbProject.Services.Abstract;
using MYAcademy_AirbnbProject.Settings;

namespace MYAcademy_AirbnbProject.Services.Concrete
{
    public class CategoryService : ICategoryService
    {
        //Category c=new Category();
        private readonly IMongoCollection<Category> _categoryCollection;
        private readonly IMapper _mapper;
        public CategoryService(IOptions<MongoDbSettings> mongoDbSettings, IMapper mapper)
        {
            var mongoClient = new MongoClient(mongoDbSettings.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(mongoDbSettings.Value.DatabaseName);
            _categoryCollection = mongoDatabase.GetCollection<Category>(mongoDbSettings.Value.CategoryCollectionName);
            _mapper = mapper;
        }

        public async Task CreateCategoryAsync(CreateCategoryDto createCategoryDto)
        {
            var category = _mapper.Map<Category>(createCategoryDto);
            await _categoryCollection.InsertOneAsync(category);
        }

        public async Task DeleteCategoryAsync(string id)
        {
            await _categoryCollection.DeleteOneAsync(x => x.CategoryId == id);
        }

        public async Task<List<ResultCategoryDto>> GetAllCategoriesAsync()
        {
            var values = await _categoryCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultCategoryDto>>(values);
        }

        public async Task<GetByIdCategoryDto> GetByIdCategoryAsync(string id)
        {
            var value = await _categoryCollection.Find(x => x.CategoryId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetByIdCategoryDto>(value);
        }

        public async Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto)
        {
            var value = _mapper.Map<Category>(updateCategoryDto);
            await _categoryCollection.ReplaceOneAsync(x => x.CategoryId == updateCategoryDto.CategoryId, value);
        }
    }
}
