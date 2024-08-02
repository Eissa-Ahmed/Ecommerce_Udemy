namespace Ecommerce.Application.ApplicationValidation;

public sealed class ValidationFilter : IActionFilter
{
    public void OnActionExecuted(ActionExecutedContext context)
    {
        if (!context.ModelState.IsValid)
        {
            Console.WriteLine("====================Start====================");
            var errors = context.ModelState
                .Where(ms => ms.Value?.Errors.Count > 0)
                .Select(ms => new ValidationFailure(ms.Key, ms.Value?.Errors.First().ErrorMessage)).First();

            var customResponse = new ApplicationResponse<string>
            {
                Success = false,
                StatusCode = HttpStatusCode.UnprocessableEntity,
                Message = errors.PropertyName + ": " + errors.ErrorMessage
            };

            context.Result = new JsonResult(customResponse)
            {
                StatusCode = StatusCodes.Status400BadRequest
            };
        }
    }

    public void OnActionExecuting(ActionExecutingContext context) { }
}
