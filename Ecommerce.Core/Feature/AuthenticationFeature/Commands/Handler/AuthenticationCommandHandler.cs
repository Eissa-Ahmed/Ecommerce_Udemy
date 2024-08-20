namespace Ecommerce.Application.Feature.AuthenticationFeature.Commands.Handler;

public sealed class AuthenticationCommandHandler : ResponseHandler,
    IRequestHandler<AuthenticationLoginModel, ApplicationResponse<AuthenticationLoginResult>>,
    IRequestHandler<AuthenticationRefreshTokenModel, ApplicationResponse<AuthenticationLoginResult>>,
    IRequestHandler<AuthenticationRegisterModel, ApplicationResponse<string>>,
    IRequestHandler<AuthenticationRevokeTokenModel, ApplicationResponse<string>>,
    IRequestHandler<AuthenticationForgetPasswordModel, ApplicationResponse<string>>,
    IRequestHandler<AuthenticationTokenVerifyModel, ApplicationResponse<string>>,
    IRequestHandler<AuthenticationResetPasswordModel, ApplicationResponse<string>>
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

    public async Task<ApplicationResponse<AuthenticationLoginResult>> Handle(AuthenticationRefreshTokenModel request, CancellationToken cancellationToken)
    {
        AuthenticationModel authenticationModel = await _authenticationService.RefreshTokenAsync();
        if (authenticationModel.IsAuthenticated)
            return Success(_mapper.Map<AuthenticationLoginResult>(authenticationModel));
        else
            return Unauthorized(_mapper.Map<AuthenticationLoginResult>(authenticationModel));
    }

    public async Task<ApplicationResponse<string>> Handle(AuthenticationRevokeTokenModel request, CancellationToken cancellationToken)
    {
        bool result = await _authenticationService.RevokeTokenAsync();
        if (result)
            return Success();
        else
            return BadRequest("Invalid token");
    }

    public async Task<ApplicationResponse<string>> Handle(AuthenticationForgetPasswordModel request, CancellationToken cancellationToken)
    {
        await _authenticationService.ForgotPasswordAsync(request.Email);
        return Success();
    }

    public async Task<ApplicationResponse<string>> Handle(AuthenticationTokenVerifyModel request, CancellationToken cancellationToken)
    {
        bool isValid = await _authenticationService.TokenVerifyAsync(request.Email, request.Token.Replace(" ", "+"));
        if (!isValid)
            return BadRequest("Invalid token");
        else
            return Success("Valid token");
    }

    public async Task<ApplicationResponse<string>> Handle(AuthenticationResetPasswordModel request, CancellationToken cancellationToken)
    {
        await _authenticationService.ResetPasswordAsync(request.Email, request.Password, request.Token.Replace(" ", "+"));
        return Success();
    }
}
