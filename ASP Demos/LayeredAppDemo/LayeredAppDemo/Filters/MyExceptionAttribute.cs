using LayeredAppDemo.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace LayeredAppDemo.Filters
{
    public class MyExceptionAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var message = context.Exception.Message;
            var exceptionType = context.Exception.GetType();

            if (exceptionType == typeof(CustomerNotFoundException))
            {
                context.Result = new NotFoundObjectResult(message);
            }
            else if (exceptionType == typeof(CustomerAlreadyExistsException))
            {
                context.Result = new ConflictObjectResult(message);
            }
            else
            {
                context.Result = new BadRequestObjectResult("Something went wrong");
            }
        }
    }
}
