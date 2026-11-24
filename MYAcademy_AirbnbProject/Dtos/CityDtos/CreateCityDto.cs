namespace MYAcademy_AirbnbProject.Dtos.CityDtos
{
    public class CreateCityDto
    {
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
    }
}
