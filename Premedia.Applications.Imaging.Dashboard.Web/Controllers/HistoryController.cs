﻿using Microsoft.AspNetCore.Mvc;
using Premedia.Applications.Imaging.Dashboard.Application.Commands;
using Premedia.Applications.Imaging.Dashboard.Application.Contracts;
using Premedia.Applications.Imaging.Dashboard.Application.ReadModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Premedia.Applications.Imaging.Dashboard.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HistoryController : ControllerBase
    {
        private readonly IHistoryApplicationService _historyApplicationService;
        public HistoryController(IHistoryApplicationService historyApplicationService)
        {
            _historyApplicationService = historyApplicationService;
        }

        [HttpGet(nameof(GetChangedHistories))]
        public async Task<ActionResult<List<HistoryReadModel>>> GetChangedHistories()
        {
            return await _historyApplicationService.GetChangedHistories();
        }

        [HttpGet(nameof(GetHistoryById))]
        public async Task<ActionResult<HistoryReadModel>> GetHistoryById(Guid id)
        {
            return await _historyApplicationService.GetHistoryById(id);
        }

        [HttpGet(nameof(GetAllHistories))]
        public async Task<ActionResult<List<HistoryReadModel>>> GetAllHistories()
        {
            return await _historyApplicationService.GetAllHistories();
        }
        [HttpPost(nameof(GetAllHistories))]
        public async Task<ActionResult<HistoryReadModel>> CreateHistory(CreateHistoryCommand command)
        {
            return await _historyApplicationService.CreateHistory(command);
        }

        [HttpPut]
        public async Task<ActionResult<HistoryReadModel>> UpdateHistory(Guid id, UpdateHistoryCommand command)
        {
            return await _historyApplicationService.UpdateHistory(id, command);
        }
    }
}
