namespace Ecommerce.Domain.Entities;

public sealed class PaymentMethod
{
    public PaymentMethod()
    {
        Id = Guid.NewGuid().ToString();
        IsActive = true;
    }
    public string Id { get; set; }
    public PaymentMethodName Name { get; set; }
    public bool IsActive { get; set; }
    public decimal AdditionalCoast { get; set; }
}
