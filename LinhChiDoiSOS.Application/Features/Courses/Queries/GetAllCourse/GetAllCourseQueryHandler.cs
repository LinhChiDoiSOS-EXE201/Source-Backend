using AutoMapper;
using AutoMapper.QueryableExtensions;
using LinhChiDoiSOS.Application.Common.Exceptions;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Features.CourseDetails.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LinhChiDoiSOS.Application.Features.Courses.Queries.GetAllCourse
{
    public class GetAllCourseQueryHandler : IRequestHandler<GetAllCourseQuery, List<CategoryResponse>>
    {
        public readonly ILinhChiDoiSOSDbContext _dbContext;
        public readonly IMapper _mapper;
        public GetAllCourseQueryHandler(ILinhChiDoiSOSDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<List<CategoryResponse>> Handle(GetAllCourseQuery request, CancellationToken cancellationToken)
        {
            // check isPaid from Customer
            var customerIsPaid = await _dbContext.Customer.Where(c => c.Id == Guid.Parse(request.CustomerId) && c.IsPaid).SingleOrDefaultAsync();
            if (customerIsPaid == null) {
                throw new BadRequestException("Your account do not pay for learning skill");
            }

            var categoryList = await _dbContext.Category.Where(c => !c.IsDelete).ToListAsync();
            var response = new List<CategoryResponse>();
            foreach (var category in categoryList) {
                var categoryResponse = new CategoryResponse
                {
                    Id = category.Id,
                    Name = category.Name,
                    CourseResponses = CourseRes(category.Id)
                };
                response.Add(categoryResponse);
            }
            return response;

        }
        #region private
        private List<CourseResponse> CourseRes(Guid categoryId)
        {
            var listCourseByCategoryId = _dbContext.Course
                .Where(c => c.CategoryId == categoryId)
                .ProjectTo<CourseResponse>(_mapper.ConfigurationProvider)
                .ToList();
            return listCourseByCategoryId;
        }
        #endregion
    }
}
