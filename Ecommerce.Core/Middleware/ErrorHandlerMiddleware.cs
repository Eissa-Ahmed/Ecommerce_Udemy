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
            ApplicationResponse<string> responseModel = new() { Success = false };

            switch (error)
            {
                case UnauthorizedAccessException e:
                    responseModel.Message = "User is unauthorized.";
                    responseModel.StatusCode = HttpStatusCode.Unauthorized;
                    response.StatusCode = (int)HttpStatusCode.Unauthorized;
                    break;

                case ArgumentNullException e:
                    responseModel.Message = "A required argument was null.";
                    responseModel.StatusCode = HttpStatusCode.BadRequest;
                    response.StatusCode = (int)HttpStatusCode.BadRequest;
                    break;

                case ArgumentOutOfRangeException e:
                    responseModel.Message = "An argument was out of range.";
                    responseModel.StatusCode = HttpStatusCode.BadRequest;
                    response.StatusCode = (int)HttpStatusCode.BadRequest;
                    break;

                case InvalidOperationException e:
                    responseModel.Message = "Operation is not valid.";
                    responseModel.StatusCode = HttpStatusCode.BadRequest;
                    response.StatusCode = (int)HttpStatusCode.BadRequest;
                    break;

                case NotSupportedException e:
                    responseModel.Message = "Operation is not supported.";
                    responseModel.StatusCode = HttpStatusCode.NotImplemented;
                    response.StatusCode = (int)HttpStatusCode.NotImplemented;
                    break;

                case KeyNotFoundException e:
                    responseModel.Message = "The specified key was not found.";
                    responseModel.StatusCode = HttpStatusCode.NotFound;
                    response.StatusCode = (int)HttpStatusCode.NotFound;
                    break;

                case TimeoutException e:
                    responseModel.Message = "The operation timed out.";
                    responseModel.StatusCode = HttpStatusCode.RequestTimeout;
                    response.StatusCode = (int)HttpStatusCode.RequestTimeout;
                    break;

                case HttpRequestException e:
                    responseModel.Message = "There was an error with the HTTP request.";
                    responseModel.StatusCode = HttpStatusCode.BadRequest;
                    response.StatusCode = (int)HttpStatusCode.BadRequest;
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
