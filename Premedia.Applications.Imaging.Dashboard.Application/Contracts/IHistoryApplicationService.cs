﻿using Microsoft.AspNetCore.Mvc;
using Premedia.Applications.Imaging.Dashboard.Application.Commands;
using Premedia.Applications.Imaging.Dashboard.Application.ReadModels;
using Premedia.Applications.Imaging.Dashboard.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premedia.Applications.Imaging.Dashboard.Application.Contracts
{
    public interface IHistoryApplicationService
    {
        Task<ActionResult<List<HistoryReadModel>>> GetChangedHistories();
        Task<ActionResult<HistoryReadModel>> GetHistoryById(Guid id);
        Task<ActionResult<List<HistoryReadModel>>> GetAllHistories();
        Task<ActionResult<HistoryReadModel>> CreateHistory(CreateHistoryCommand command);
        Task<ActionResult<HistoryReadModel>> UpdateHistory(Guid id, UpdateHistoryCommand command);
    }
}
