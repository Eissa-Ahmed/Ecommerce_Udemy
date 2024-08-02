namespace Ecommerce.API.Controllers.Base;

[ApiController]
public class ApplicationBaseController : ControllerBase
{
    protected IMediator _mediator => HttpContext.RequestServices.GetService<IMediator>()!;
    public ObjectResult BaseResponse<T>(ApplicationResponse<T> response)
    {
        switch (response.StatusCode)
        {
            case HttpStatusCode.OK:
                return new OkObjectResult(response);
            case HttpStatusCode.Created:
                return new CreatedResult(string.Empty, response);
            case HttpStatusCode.Accepted:
                return new AcceptedResult(string.Empty, response);
            case HttpStatusCode.NotFound:
                return new NotFoundObjectResult(response);
            case HttpStatusCode.Conflict:
                return new ConflictObjectResult(response);
            case HttpStatusCode.BadRequest:
                return new BadRequestObjectResult(response);
            case HttpStatusCode.Unauthorized:
                return new UnauthorizedObjectResult(response);
            case HttpStatusCode.UnprocessableEntity:
                return new UnprocessableEntityObjectResult(response);
            default:
                return new BadRequestObjectResult(response);
        }
    }
}
