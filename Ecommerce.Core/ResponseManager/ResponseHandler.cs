namespace Ecommerce.Application.ResponseManager;

public class ResponseHandler
{
    public ApplicationResponse<T> Created<T>(T data, string? message = null)
    {
        return new ApplicationResponse<T>(true, HttpStatusCode.Created, data, message ?? "Created Successfully");
    }
    public ApplicationResponse<string> Created(string? message = null)
    {
        return new ApplicationResponse<string>(true, HttpStatusCode.Created, null, message ?? "Created Successfully");
    }
    public ApplicationResponse<T> Success<T>(T data, string? message = null)
    {
        return new ApplicationResponse<T>(true, HttpStatusCode.OK, data, message ?? "Success");
    }
    public ApplicationResponse<string> Success(string? message = null)
    {
        return new ApplicationResponse<string>(true, HttpStatusCode.OK, null, message ?? "Success");
    }
    public ApplicationResponse<T> Unauthorized<T>(T data, string? message = null)
    {
        return new ApplicationResponse<T>(false, HttpStatusCode.Unauthorized, data, message ?? "Unauthorized");
    }
    public ApplicationResponse<string> BadRequest(string? message = null)
    {
        return new ApplicationResponse<string>(false, HttpStatusCode.BadRequest, null, message ?? "BadRequest");
    }
}
