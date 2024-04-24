using LinhChiDoiSOS.Application.Common.Response;
using LinhChiDoiSOS.Domain.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.MiniContents.Commands.DeleteMiniContent
{
    public class DeleteMiniContentCommand : IRequest<SOSResponse>, ISoftDelete
    {
        public Guid MiniContentId { get; set; }

        public bool IsDelete { get; set; }
    }
}