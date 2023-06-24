using MOQExample.Entitities;

namespace MOQExample.Services.Contracts;

public interface IProduct
{
    Product GetProductById(int Id);
}