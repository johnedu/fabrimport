using AutoMapper;
using Project.Authorization.Users;
using Project.Authorization.Users.Dto;
using Project.Domain.Entities;
using Project.ProjectApplication.General.CustomerApp.DTOs.OutputModels;
using Project.ProjectApplication.General.EmployeeApp.DTOs.OutputModels;
using Project.ProjectApplication.General.PersonApp.DTOs.OutputModels;
using Project.ProjectApplication.General.ProductApp.DTOs.OutputModels;
using System.Linq;

namespace Project
{
    internal static class CustomDtoMapper
    {
        private static volatile bool _mappedBefore;
        private static readonly object SyncObj = new object();

        public static void CreateMappings(IMapperConfigurationExpression mapper)
        {
            lock (SyncObj)
            {
                if (_mappedBefore)
                {
                    return;
                }

                CreateMappingsInternal(mapper);

                _mappedBefore = true;
            }
        }

        private static void CreateMappingsInternal(IMapperConfigurationExpression mapper)
        {
            CreateMappingsUser(mapper);
            CreateMappingsPerson(mapper);
            CreateMappingsEmployee(mapper);
            CreateMappingsCustomer(mapper);
            CreateMappingsProduct(mapper);
        }

        private static void CreateMappingsUser(IMapperConfigurationExpression mapper)
        {
            mapper.CreateMap<User, UserEditDto>().ForMember(dto => dto.Password, options => options.Ignore())
                                                 .ReverseMap()
                                                 .ForMember(user => user.Password, options => options.Ignore());
        }

        private static void CreateMappingsPerson(IMapperConfigurationExpression mapper)
        {
            mapper.CreateMap<Address, AddressOutput>()
                .ForMember(dest => dest.CityName, opt => opt.MapFrom(src => src.City.Name));

            mapper.CreateMap<Phone, PhoneOutput>()
               .ForMember(dest => dest.CityName, opt => opt.MapFrom(src => src.CityId.HasValue ? src.City.Name : string.Empty))
               .ForMember(dest => dest.CountryName, opt => opt.MapFrom(src => src.CountryId.HasValue ? src.Country.Name : string.Empty))
               .ForMember(dest => dest.TypeName, opt => opt.MapFrom(src => src.Type.Name));

            mapper.CreateMap<Person, PersonOutput>()
                .ForMember(dest => dest.DocumentTypeName, opt => opt.MapFrom(src => src.DocumentType.Name));
        }

        private static void CreateMappingsEmployee(IMapperConfigurationExpression mapper)
        {
            mapper.CreateMap<Employee, EmployeeOutput>()
                .ForMember(dest => dest.PersonName, opt => opt.MapFrom(src => src.Person.FullName));
        }

        private static void CreateMappingsCustomer(IMapperConfigurationExpression mapper)
        {
            mapper.CreateMap<Customer, CustomerOutput>()
                .ForMember(dest => dest.PersonName, opt => opt.MapFrom(src => src.Person.FullName))
                .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.CompanyId.HasValue ? src.Company.Name : string.Empty));
        }

        private static void CreateMappingsProduct(IMapperConfigurationExpression mapper)
        {
            mapper.CreateMap<Product, BasicProductOutput>()
                .ForMember(dest => dest.ProductCategoryName, opt => opt.MapFrom(src => src.ProductCategory.Name))
                .ForMember(dest => dest.ProductPrice, opt => opt.MapFrom(src => src.ProductPrices.Any(x => x.IsActive) ? src.ProductPrices.First(x => x.IsActive).Value : (decimal?)null));
        }
    }
}