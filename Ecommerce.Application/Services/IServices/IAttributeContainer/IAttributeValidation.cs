namespace Ecommerce.Application.Services.IServices.IAttributeContainer;

public interface IAttributeValidation
{
    public Task<bool> AttributeIsExist(string attributeId);
}
