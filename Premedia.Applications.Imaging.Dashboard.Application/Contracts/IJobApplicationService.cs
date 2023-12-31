﻿using Microsoft.AspNetCore.Mvc;
using Premedia.Applications.Imaging.Dashboard.Application.Commands;
using Premedia.Applications.Imaging.Dashboard.Application.ReadModels;
using Premedia.Applications.Imaging.Dashboard.Core.Entities;

namespace Premedia.Applications.Imaging.Dashboard.Application.Contracts
{
    public interface IJobApplicationService
    {
        Task<ActionResult<List<JobReadModel>>> GetNewJobs();
        Task<ActionResult<List<JobReadModel>>> GetAllJobs();
        Task<ActionResult<JobReadModel>> GetJobById(Guid id);
        Task<ActionResult<List<JobReadModel>>> GetJobsByEditor(User editor);
        Task<ActionResult<List<JobReadModel>>> GetOpenJobsByEditorId(Guid id);
        Task<ActionResult<List<JobReadModel>>> GetOpenColleagueJobs(Guid id);
        Task<ActionResult<List<JobReadModel>>> GetTransferredJobs();
        Task<ActionResult<List<JobReadModel>>> GetDoneJobs();
        Task<ActionResult<JobReadModel>> CreateJob(CreateJobCommand jobEntity);
        Task<ActionResult<JobReadModel>> UpdateJob(UpdateJobCommand command);
        Task<ActionResult<JobReadModel>> ChangeEditor(UpdateJobEditorCommand command);

    }
}