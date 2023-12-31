﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Premedia.Applications.Imaging.Dashboard.Core.Exceptions;

namespace Premedia.Applications.Imaging.Dashboard.ActionFIlters;

public class HttpResponseExceptionFilter : IActionFilter, IOrderedFilter
{
    public void OnActionExecuting(ActionExecutingContext context)
    {
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        if (context.Exception is HttpResponseException exception)
        {
            context.Result = new ObjectResult(exception.Value)
            {
                StatusCode = exception.Status
            };
            context.ExceptionHandled = true;
        }
    }

    public int Order { get; } = int.MaxValue - 10;
}