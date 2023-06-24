using FluentAssertions;
using Moq;
using MOQExample.Services;
using MOQExample.Services.Contracts;
using Range = Moq.Range;

namespace MOQ.Test;

public class OrderServiceTest
{
     [Fact]
     public void CreateOrder_AndReturnWithCorrectAmount()
     {
          //Arrange
          var mockPriceService = new Mock<IPrice>();
          mockPriceService.Setup(e => e.Calculate(10,10,10)).Returns(90);
          /*mockPriceService.Setup(k =>
               k.Calculate(It.IsInRange
                    (1, 10, Range.Exclusive), 
                    It.IsInRange(1, 10, Range.Exclusive), 
                    10)).Returns(90);*/
          
          mockPriceService.Setup(e => e.Calculate(1,10,10)).Returns(9);
          var priceService = mockPriceService.Object;
          
          
          var mockProductService = new Mock<IProduct>();
          var productService = mockProductService.Object;
          
          
          //Act
          var orderService = new OrderService(priceService,productService);
          var order = orderService.CreateOrder(10, 10);
          //Assert
          Assert.Equal(90,order.TotalAmount);

          var str = "Fluent Assertions";

          str.Should().StartWith("F").And.NotContainAny(" ");

     }
     
}