namespace Ecommerce.Application.Services.AttributeContainer;

public sealed class AttributeValidation : IAttributeValidation
{
    private readonly IUnitOfWork _unitOfWork;

    public AttributeValidation(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<bool> AttributeIsExist(string attributeId)
    {
        List<Expression<Func<Attributes, bool>>> criteria = new List<Expression<Func<Attributes, bool>>>()
        {
            attribute => attribute.Id == attributeId
        };
        AttributesSpecification attributesSpecification = new AttributesSpecification(criteria);
        Attributes? attribute = await _unitOfWork.AttributesRepository.GetByIdAsync(attributesSpecification);
        return attribute != null;
    }
}
