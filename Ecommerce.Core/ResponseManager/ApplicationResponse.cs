namespace Ecommerce.Application.ResponseManager;

public sealed class ApplicationResponse<T>
{
    public ApplicationResponse(bool success, HttpStatusCode statusCode, T? data, string? message = null)
    {
        Success = success;
        StatusCode = statusCode;
        Message = message;
        Data = data;
    }

    public bool Success { get; set; }
    public HttpStatusCode StatusCode { get; set; }
    public string? Message { get; set; } = null;
    public T? Data { get; set; }
}
