using MYAcademy_AirbnbProject.Dtos.HouseDtos;

namespace MYAcademy_AirbnbProject.Services.Abstract
{
    public interface IHouseService
    {
        Task<List<ResultHouseDto>> GetAllHousesAsync();
        Task<GetByIdHouseDto> GetByIdHouseAsync(string id);
        Task CreateHouseAsync(CreateHouseDto createHouseDto);
        Task UpdateHouseAsync(UpdateHouseDto updateHouseDto);
        Task DeleteHouseAsync(string id);
    }
}
