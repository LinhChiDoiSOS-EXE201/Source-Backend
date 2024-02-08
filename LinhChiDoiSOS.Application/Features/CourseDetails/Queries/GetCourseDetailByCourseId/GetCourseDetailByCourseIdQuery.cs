using AutoMapper;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Features.CourseDetails.Commands.CreateCourseDetail;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.CourseDetails.Queries.GetCourseDetailByCourseId
{
    public class GetCourseDetailByCourseIdQuery : IRequest<CourseDetailResponse>
    {
        public string CourseId { get; set; }
    }

    public class GetCourseDetailByCourseIdQueryHandler : IRequestHandler<GetCourseDetailByCourseIdQuery, CourseDetailResponse>
    {
        public readonly ILinhChiDoiSOSDbContext _dbContext;
        public readonly IMapper _mapper;
        public GetCourseDetailByCourseIdQueryHandler(ILinhChiDoiSOSDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<CourseDetailResponse> Handle(GetCourseDetailByCourseIdQuery request, CancellationToken cancellationToken)
        {
            // check course in courseDetail
            var courseDetail = await _dbContext.CourseDetail
                .Where(c => c.CourseId == Guid.Parse(request.CourseId) && !c.IsDelete)
                .SingleOrDefaultAsync();
            if(courseDetail == null) {
                throw new NotFoundException("CourseID does not existed");
            }
            var response = new CourseDetailResponse
            {
                Id = courseDetail.Id,
                Name = courseDetail.Name,
                Content = courseDetail.Content,
                ImageUrl = courseDetail.ImageUrl,
                StepCourseDetailList = _mapper
                            .Map<List<StepCourseDetail>>(_dbContext.StepOfCourseDetail
                                        .Where(s => s.CourseDetailId == courseDetail.Id).ToList()
                                    ),
                Conlusion = courseDetail.Conlusion,
                CourseId = courseDetail.CourseId,
                CourseData = _mapper.Map<CourseResponse>(_dbContext.Course.Where(c => c.Id == courseDetail.CourseId).SingleOrDefault())
            };

            return response;
        }
    }
}
