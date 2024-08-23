namespace Ecommerce.Application.Mapper.ReviewMapper;

public partial class ReviewProfile
{
    private void ApplyReviewGetAllMapper()
    {
        CreateMap<Pagination<Review>, Pagination<ReviewGetAllResult>>()
                .ForMember(dest => dest.Data, opt => opt.MapFrom(src => src.Data));

        CreateMap<Review, ReviewGetAllResult>()
                .ForMember(dest => dest.User, opt => opt.MapFrom<ReviewGetAll_ConvertUserIdToUser_Resolver>());

    }
}
