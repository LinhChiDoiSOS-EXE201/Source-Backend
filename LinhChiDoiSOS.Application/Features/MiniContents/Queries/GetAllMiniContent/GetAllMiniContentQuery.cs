using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.MiniContents.Queries.GetAllMiniContent
{
    public class GetAllMiniContentQuery : IRequest<List<MiniContentResponse>>
    {
    }
}
