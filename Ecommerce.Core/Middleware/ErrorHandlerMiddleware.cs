namespace Ecommerce.Application.Middleware;

public sealed class ErrorHandlerMiddleware
{
    private readonly RequestDelegate _next;

    public ErrorHandlerMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task Invoke(HttpContext context)
    {
        ApplicationResponse<string> applicationResponse = new() { Success = false };
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            HttpResponse response = context.Response;
            response.ContentType = "application/json";

            switch (ex)
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
                    applicationResponse.Message = ex.Message;
                    applicationResponse.StatusCode = HttpStatusCode.InternalServerError;
                    break;
            }


            string result = JsonSerializer.Serialize(applicationResponse);
            await response.WriteAsync(result);
        }
    }
}
