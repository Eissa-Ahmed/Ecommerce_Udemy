namespace Ecommerce.Domain.Entities;

public sealed class Payment
{
    public Payment()
    {
        Id = Guid.NewGuid().ToString();
    }
    public string Id { get; set; }
    public string OrderId { get; set; } = null!;
    public Order Order { get; set; } = null!;
    public string PaymentMethodId { get; set; } = null!;
    public PaymentMethod PaymentMethod { get; set; } = null!;
    public DateTime PaymentDate { get; set; }
    public decimal Amount { get; set; }
    public PaymentStatus PaymentStatus { get; set; }
}
