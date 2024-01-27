using AutoMapper;
using LinhChiDoiSOS.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.ChuanDoans.Queries.GetListChuanDoanByKeyword
{
    public class GetChuanDoanByKeyQuery : IRequest<List<ChuanDoanByKeywordResponse>>
    {
        //public Guid KeywordId { get; set; }
    }

    public class GetChuanDoanByKeyQueryHandler : IRequestHandler<GetChuanDoanByKeyQuery, List<ChuanDoanByKeywordResponse>>
    {
        public readonly ILinhChiDoiSOSDbContext _dbContext;
        public readonly IMapper _mapper;
        public GetChuanDoanByKeyQueryHandler(ILinhChiDoiSOSDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<ChuanDoanByKeywordResponse>> Handle(GetChuanDoanByKeyQuery request, CancellationToken cancellationToken)
        {
            var chuanDoansGrouped = await _dbContext.ChuanDoan
                                        .Where(c => !c.IsDelete)
                                        .GroupBy(c => new { c.Name, c.Description })
                                        .ToListAsync();
            //var chuanDoanList = await _dbContext.ChuanDoan.Where(c => c.KeywordId == request.KeywordId).ToListAsync();

            var response = new List<ChuanDoanByKeywordResponse>();

            foreach (var group in chuanDoansGrouped) {
                var keywordList = group.Select(c => c.KeywordId)
                    .Distinct()
                    .Select(keywordId => _mapper.Map<KeywordData>(
                        _dbContext.Keyword
                            .FirstOrDefault(k => k.Id == keywordId)
                    ))
                    .ToList();

                var res = new ChuanDoanByKeywordResponse
                {
                    Id = Guid.NewGuid(), // Đang suy nghĩ khúc này sao nha
                    Name = group.Key.Name,
                    Description = group.Key.Description,
                    keywordListData = keywordList
                };

                response.Add(res);
            }

            return response;
        }
    }


}
