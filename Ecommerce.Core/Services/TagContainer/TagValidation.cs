namespace Ecommerce.Application.Services.TagContainer;

public sealed class TagValidation : ITagValidation
{
    private readonly IUnitOfWork _unitOfWork;
    public TagValidation(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public Task<bool> TagIsExist(string tagId)
    {
        return _unitOfWork.TagRepository.IsExist(i => i.Id == tagId);
    }
}
