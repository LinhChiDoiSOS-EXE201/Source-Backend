using LinhChiDoiSOS.Application.Common.Mappings;
using LinhChiDoiSOS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.ChuanDoans.Queries.GetListChuanDoanByKeyword
{
    public class ChuanDoanByKeywordResponse
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? Created { get; set; } 
        public List<KeywordData> keywordListData { get; set; }
    }

    public class KeywordData : IMapFrom<Keyword>
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
    }
}


