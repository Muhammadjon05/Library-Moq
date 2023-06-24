namespace MOQExample.Services.Contracts;

public interface IPrice
{
    decimal Calculate(decimal productCount, decimal productPrice,decimal discount);
}