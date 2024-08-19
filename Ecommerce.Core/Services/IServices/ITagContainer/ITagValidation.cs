namespace Ecommerce.Application.Services.IServices.ITagContainer;

public interface ITagValidation
{
    Task<bool> TagIsExist(string tagId);
}
