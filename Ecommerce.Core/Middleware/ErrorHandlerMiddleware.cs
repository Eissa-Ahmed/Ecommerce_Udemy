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
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            HttpResponse response = context.Response;
            response.ContentType = "application/json";
            ApplicationResponse<string> applicationResponse = new() { Success = false };

            switch (ex)
            {
                case ValidationException e:
                    applicationResponse.Message = e.Message;
                    applicationResponse.StatusCode = HttpStatusCode.UnprocessableEntity;
                    response.StatusCode = (int)HttpStatusCode.UnprocessableEntity;
                    break;
                case UnauthorizedAccessException e:
                    applicationResponse.Message = e.Message;
                    applicationResponse.StatusCode = HttpStatusCode.Unauthorized;
                    response.StatusCode = (int)HttpStatusCode.Unauthorized;
                    break;
                case KeyNotFoundException e:
                    applicationResponse.Message = e.Message;
                    applicationResponse.StatusCode = HttpStatusCode.NotFound;
                    response.StatusCode = (int)HttpStatusCode.NotFound;
                    break;
                case DbUpdateException e:
                    applicationResponse.Message = e.Message;
                    applicationResponse.StatusCode = HttpStatusCode.NotFound;
                    response.StatusCode = (int)HttpStatusCode.NotFound;
                    break;
                case ArgumentException e:
                    applicationResponse.Message = e.Message;
                    applicationResponse.StatusCode = HttpStatusCode.BadRequest;
                    response.StatusCode = (int)HttpStatusCode.BadRequest;
                    break;
                case Exception e:
                    applicationResponse.Message = e.Message;
                    applicationResponse.StatusCode = HttpStatusCode.BadRequest;
                    response.StatusCode = (int)HttpStatusCode.BadRequest;
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
