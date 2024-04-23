using AutoMapper;
using AutoMapper.QueryableExtensions;
using LinhChiDoiSOS.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LinhChiDoiSOS.Application.Features.MiniContents.Queries.GetAllMiniContent
{
    public class GetAllMiniContentQueryHandler : IRequestHandler<GetAllMiniContentQuery, List<MiniContentResponse>>
    {
        private readonly ILinhChiDoiSOSDbContext _dbContext;
        private IMapper _mapper;

        public GetAllMiniContentQueryHandler(ILinhChiDoiSOSDbContext dbContext, IMapper mapper)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<List<MiniContentResponse>> Handle(GetAllMiniContentQuery request, CancellationToken cancellationToken)
        {
            var miniContent = await _dbContext.MiniContent.Where(c => !c.IsDelete)
                .ProjectTo<MiniContentResponse>(_mapper.ConfigurationProvider)
                .ToListAsync();

            return miniContent;
        }
    }
}
