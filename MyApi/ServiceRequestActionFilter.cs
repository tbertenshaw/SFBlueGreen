using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApi
{
    //internal class ServiceRequestActionFilter : ActionFilterAttribute
    //{
    //    public override void OnActionExecuting(HttpActionContext actionContext)
    //    {
    //        ServiceEventSource.Current.ServiceRequestStart(actionContext.ActionDescriptor.ActionName);
    //    }

    //    public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
    //    {
    //        ServiceEventSource.Current.ServiceRequestStop(actionExecutedContext.ActionContext.ActionDescriptor.ActionName,
    //            actionExecutedContext.Exception?.ToString() ?? string.Empty);
    //    }
    //}
}
