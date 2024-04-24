﻿using LinhChiDoiSOS.Application.Common.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.MiniContents.Commands
{
    public class CreateMiniContentCommand : IRequest<SOSResponse>
    {
        public Guid EmergencyDetailId { get; set; }
        public string? ContentUrl { get; set; }
        public string? Content { get; set; }
    }
}