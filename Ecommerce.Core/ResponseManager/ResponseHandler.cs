namespace Ecommerce.Application.ResponseManager;

public class ResponseHandler
{
    public ApplicationResponse<T> Created<T>(T data, string? message = null)
    {
        return new ApplicationResponse<T>(true, HttpStatusCode.Created, data, message ?? "Created Successfully");
    }
    public ApplicationResponse<T> Success<T>(T data, string? message = null)
    {
        return new ApplicationResponse<T>(true, HttpStatusCode.OK, data, message ?? "Success");
    }
    public ApplicationResponse<string> Success(string? message = null)
    {
        return new ApplicationResponse<string>(true, HttpStatusCode.OK, null, message ?? "Success");
    }
}
