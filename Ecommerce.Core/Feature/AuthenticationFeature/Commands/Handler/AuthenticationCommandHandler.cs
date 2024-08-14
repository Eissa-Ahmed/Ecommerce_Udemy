namespace Ecommerce.Application.Feature.AuthenticationFeature.Commands.Handler;

public sealed class AuthenticationCommandHandler : ResponseHandler,
    IRequestHandler<AuthenticationLoginModel, ApplicationResponse<AuthenticationLoginResult>>,
    IRequestHandler<AuthenticationRegisterModel, ApplicationResponse<string>>
{
    private readonly IAuthenticationService _authenticationService;
    private readonly IMapper _mapper;

    public AuthenticationCommandHandler(IAuthenticationService authenticationService, IMapper mapper)
    {
        _authenticationService = authenticationService;
        _mapper = mapper;
    }

    public async Task<ApplicationResponse<AuthenticationLoginResult>> Handle(AuthenticationLoginModel request, CancellationToken cancellationToken)
    {
        LoginModel loginModel = _mapper.Map<LoginModel>(request);
        AuthenticationModel authenticationModel = await _authenticationService.LoginAsync(loginModel);
        if (authenticationModel.IsAuthenticated)
            return Success(_mapper.Map<AuthenticationLoginResult>(authenticationModel));
        else
            return Unauthorized(_mapper.Map<AuthenticationLoginResult>(authenticationModel));
    }

    public async Task<ApplicationResponse<string>> Handle(AuthenticationRegisterModel request, CancellationToken cancellationToken)
    {
        string? result = await _authenticationService.RegisterAsync(_mapper.Map<RegisterModel>(request));
        if (result is null)
            return Created();
        else
            return BadRequest(result);
    }
}
