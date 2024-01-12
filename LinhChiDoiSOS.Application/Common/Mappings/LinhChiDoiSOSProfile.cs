using AutoMapper;
using LinhChiDoiSOS.Application.Features.Customers.Queries;
using LinhChiDoiSOS.Domain.Entities;
using LinhChiDoiSOS.Domain.IdentityModels;

namespace LinhChiDoiSOS.Application.Common.Mappings
{
    public class LinhChiDoiSOSProfile : Profile
    {
        public LinhChiDoiSOSProfile()
        {
            CreateMap<ApplicationCustomer, ApplicationUser>().ReverseMap();
            CreateMap<ApplicationUser, ApplicationCustomer>().ReverseMap();

            CreateMap<CustomerData, Customer>().ReverseMap();
            CreateMap<Customer, CustomerData>().ReverseMap();
        }
    }
}
