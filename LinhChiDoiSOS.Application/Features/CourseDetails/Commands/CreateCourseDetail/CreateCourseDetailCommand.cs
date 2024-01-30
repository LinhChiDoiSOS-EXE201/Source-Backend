using AutoMapper;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Common.Response;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.CourseDetails.Commands.CreateCourseDetail
{
    public class CreateCourseDetailCommand : IRequest<SOSResponse>
    {
        #region Course
        public string? CourseName {  get; set; }
        public string? ImageCourse { get; set; }
        public Guid CategoryCourseId {  get; set; }
        #endregion

        #region CourseDetail
        public string? CourseDetailName {  get; set; }
        public string? Content { get; set; }
        public string? ImageCourseDetail {  get; set; }

        public string? Step { get; set; }
        public string? ContentStep {  get; set; }

        public string? Conlusion { get; set; }
        #endregion
    }

    public class CreateCourseDetailCommandHandler : IRequestHandler<CreateCourseDetailCommand, SOSResponse>
    {
        public readonly ILinhChiDoiSOSDbContext _dbContext;
        public readonly IMapper _mapper;
        public CreateCourseDetailCommandHandler(ILinhChiDoiSOSDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<SOSResponse> Handle(CreateCourseDetailCommand request, CancellationToken cancellationToken)
        {
            #region Course
            var course = new Course
            {
                Name = request.CourseName,
                Image = request.ImageCourse,
                CategoryId = request.CategoryCourseId,
            };
            _dbContext.Course.Add(course);
            await _dbContext.SaveChangesAsync();
            #endregion

            #region CourseDetail
            var coureExist = await _dbContext.Course.Where(c => c.Id == course.Id && !c.IsDelete).SingleOrDefaultAsync();
            if (coureExist == null) {
                throw new NotFoundException($"Does not exist course {course.Id}");
            }
            var courseDetail = new CourseDetail
            {
                Name = request.CourseDetailName,
                Content = request.Content,
                ImageUrl = request.ImageCourseDetail,
                Step = request.Step,
                ContentStep = request.ContentStep,
                Conlusion = request.Conlusion,
                CourseId = course.Id
            };
            _dbContext.CourseDetail.Add(courseDetail);
            await _dbContext.SaveChangesAsync();
            #endregion

            return new SOSResponse
            {
                Message = "Create Successfully"
            };
        }
    }
}
