using MOQExample.Services.Contracts;

namespace MOQExample.Services;

public class OrderService
{
    private readonly IPrice _service;
    private readonly IProduct _product;
    private const decimal discount = 10;
    public OrderService(IPrice service, IProduct product)
    {
        _service = service;
        _product = product;
    }
    public Order CreateOrder(decimal productCount, decimal productPrice)
    {
        var totalAmount = _service.Calculate(productCount, productPrice, discount);
        var product = _product.GetProductById(2);
        var order = new Order()
        {
            OrderId = Guid.NewGuid(),
            TotalAmount = totalAmount
        };
        return order;
    }
    
}