﻿using Microsoft.AspNetCore.Mvc;
using Premedia.Applications.Imaging.Dashboard.Application.Commands;
using Premedia.Applications.Imaging.Dashboard.Application.Contracts;
using Premedia.Applications.Imaging.Dashboard.Application.ReadModels;
using Premedia.Applications.Imaging.Dashboard.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Premedia.Applications.Imaging.Dashboard.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobController:ControllerBase
    {
        private readonly IJobApplicationService _jobApplicationService;
        public JobController(IJobApplicationService jobApplicationService)
        {
            _jobApplicationService=jobApplicationService;
        }

        [HttpGet(nameof(GetNewJobs))]
        public async Task<ActionResult<List<JobReadModel>>> GetNewJobs()
        {
            return await _jobApplicationService.GetNewJobs().ConfigureAwait(false);
        }

        [HttpGet(nameof(GetAllJobs))]
        public async Task<ActionResult<List<JobReadModel>>> GetAllJobs()
        {
            return await _jobApplicationService.GetAllJobs().ConfigureAwait(false);
        }

        [HttpGet(nameof(GetJobById))]
        public async Task<ActionResult<JobReadModel>> GetJobById(Guid id)
        {
            return await _jobApplicationService.GetJobById(id).ConfigureAwait(false);
        }

        [HttpGet(nameof(GetJobsByEditor))]
        public async Task<ActionResult<List<JobReadModel>>> GetJobsByEditor(User editor)
        {
            return await _jobApplicationService.GetJobsByEditor(editor).ConfigureAwait(false);
        }

        [HttpPost]
        public async Task<ActionResult<JobReadModel>> CreateJob(CreateJobCommand command)
        {
            return await _jobApplicationService.CreateJob(command).ConfigureAwait(false);
        }

        [HttpPut]
        public async Task<ActionResult<JobReadModel>> UpdateJob(Guid id, UpdateJobCommand command)
        {
            await _jobApplicationService.UpdateJob(id, command).ConfigureAwait(false);
            return Ok();
        }

        [HttpPut(nameof(ChangeEditor))]
        public async Task<ActionResult<JobReadModel>> ChangeEditor(Guid id, UpdateJobEditorCommand command)
        {
            await _jobApplicationService.ChangeEditor(id, command).ConfigureAwait(false);
            return Ok();
        }
    }
}