﻿namespace Ecommerce.Application.Feature.ApplicationSettingsFeature.Queries.Handler
{
    public sealed class ApplicationSettingsQueryHandler : ResponseHandler,
        IRequestHandler<ApplicationSettingsGetModel, ApplicationResponse<ApplicationSettingsGetResult>>
    {
        private readonly IApplicationSettingsService _applicationSettingsService;
        private readonly IMapper _mapper;

        public ApplicationSettingsQueryHandler(IApplicationSettingsService applicationSettingsService, IMapper mapper)
        {
            _applicationSettingsService = applicationSettingsService;
            _mapper = mapper;
        }

        public async Task<ApplicationResponse<ApplicationSettingsGetResult>> Handle(ApplicationSettingsGetModel request, CancellationToken cancellationToken)
        {
            return Success(_mapper.Map<ApplicationSettingsGetResult>(await _applicationSettingsService.GetAsync()));
        }
    }
}
