using AutoMapper;
using MYAcademy_AirbnbProject.Dtos.AppUserDtos;
using MYAcademy_AirbnbProject.Dtos.CategoryDtos;
using MYAcademy_AirbnbProject.Dtos.HouseDtos;
using MYAcademy_AirbnbProject.Entities;

namespace MYAcademy_AirbnbProject.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Category, CreateCategoryDto>();
            CreateMap<Category, UpdateCategoryDto>();
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, GetByIdCategoryDto>().ReverseMap();

            CreateMap<House, CreateHouseDto>();
            CreateMap<House, UpdateHouseDto>();
            CreateMap<House, ResultHouseDto>().ReverseMap();
            CreateMap<House, GetByIdHouseDto>().ReverseMap();
        }
    }
}
