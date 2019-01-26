using KatlaSport.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http.Filters;

namespace KatlaSport.WebApi.CustomFilters
{
    public class CustomExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public ILogger _logger;

        public CustomExceptionFilterAttribute(ILogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public CustomExceptionFilterAttribute() : this(new NLogLogger())
        {
        }
        
        public override void OnException(HttpActionExecutedContext context)
        {
            // TODO Add logging here.
            _logger.Warning(context.Exception);

            if (context.Exception is RequestedResourceNotFoundException)
            {
                context.Response = new HttpResponseMessage(HttpStatusCode.NotFound);
            }
            else if (context.Exception is RequestedResourceHasConflictException)
            {
                context.Response = new HttpResponseMessage(HttpStatusCode.Conflict);
            }
            else if (context.Exception is Exception)
            {
                context.Response = new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }
    }
}
