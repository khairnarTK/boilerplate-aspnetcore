using AutoMapper;
using DevIQ.Api.Models;
using DevIQ.Core.Specifications.Filters;
using DevIQ.Core.Entities;

namespace DevIQ.Api
{
    public class AutomapperMaps : Profile
    {
        public AutomapperMaps()
        {
            CreateMap<BaseFilterModel, BaseFilter>().IncludeAllDerived().ReverseMap();
            CreateMap<CustomerFilterModel, CustomerFilter>().ReverseMap();

            CreateMap<Customer, CustomerModel>();
            CreateMap<Store, StoreModel>();
        }
    }
}