namespace Ecommerce.Application.Middleware;

public class ErrorHandlerMiddleware
{
    private readonly RequestDelegate _next;
    public ErrorHandlerMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception error)
        {
            var response = context.Response;
            response.ContentType = "application/json";

            switch (error)
            {
                case ValidationException e:
                    applicationResponse.Message = e.Message;
                    applicationResponse.StatusCode = HttpStatusCode.UnprocessableEntity;
                    break;
                case UnauthorizedAccessException e:
                    applicationResponse.Message = e.Message;
                    applicationResponse.StatusCode = HttpStatusCode.Unauthorized;
                    break;

                case KeyNotFoundException e:
                    applicationResponse.Message = e.Message;
                    applicationResponse.StatusCode = HttpStatusCode.NotFound;
                    break;
                case DbUpdateException e:
                    applicationResponse.Message = e.Message;
                    applicationResponse.StatusCode = HttpStatusCode.NotFound;
                    break;


                default:
                    responseModel.Message = "An unexpected error occurred.";
                    responseModel.StatusCode = HttpStatusCode.InternalServerError;
                    response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    break;
            }

            var result = JsonSerializer.Serialize(responseModel);
            await response.WriteAsync(result);
        }
    }
}
