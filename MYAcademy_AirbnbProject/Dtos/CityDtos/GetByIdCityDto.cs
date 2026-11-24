namespace MYAcademy_AirbnbProject.Dtos.CityDtos
{
    public class GetByIdCityDto
    {
        public string CityId { get; set; }
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
    }
}
