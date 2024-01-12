using AutoMapper;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Features.Customers.Queries;
using LinhChiDoiSOS.Application.Features.Customers.Queries.GetAllCustomer;
using LinhChiDoiSOS.Domain.IdentityModels;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

public class GetAllCustomerQueryHandler : IRequestHandler<GetAllCustomerQuery, List<CustomerResponse>>
{
    private readonly ILinhChiDoiSOSDbContext _dbConext;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly IMapper _mapper;
    public GetAllCustomerQueryHandler(ILinhChiDoiSOSDbContext context, 
        IMapper mapper,
        UserManager<ApplicationUser> userManager, 
        RoleManager<IdentityRole> roleManager, 
        SignInManager<ApplicationUser> signInManager)
    {
        _dbConext = context;
        _mapper = mapper;
        _userManager = userManager;
        _roleManager = roleManager;
        _signInManager = signInManager;
    }
    public async Task<List<CustomerResponse>> Handle(GetAllCustomerQuery request, CancellationToken cancellationToken)
    {
        var customerList = await _dbConext.Customer.Where(c => !c.IsDelete).ToListAsync();

        var listResult = new List<CustomerResponse>();
        foreach (var customer in customerList) {
            var customerInfo = await _userManager.FindByIdAsync(customer.ApplicationUserId);
            var result = new CustomerResponse
            {
                CustomerData = _mapper.Map<CustomerData>(customer),
                ApplicationUserData = _mapper.Map<ApplicationCustomer>(customerInfo),
                /* CustomerData = customer,
                 ApplicationUserData = customerInfo*/
            };
            listResult.Add(result);
        }

        return listResult;
    }
}
