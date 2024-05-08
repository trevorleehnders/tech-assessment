using Moq;
using Orders.Models;
using Orders.Services;
using Orders.Data;
using FluentAssertions;

namespace Orders.Test;

public class OrderServicesUnitTests
{
    [Fact]
    public void ShouldReturnOrder()
    {
        var _orderSerivce = new OrderService(new OrderRepository());
        string customer = "John Doe";

        var order = new OrdersEntity(1, customer);
        var orderRepositoryMock = new Mock<IOrderRepository>();
        orderRepositoryMock.Setup(x => 
            x.GetOrderById(1)).Returns(new OrdersEntity(1, customer));
        orderRepositoryMock.Setup(x => 
            x.GetOrderByName("John Dow")).Returns(new OrdersEntity(1, "John Doe"));

        var orderById = _orderSerivce.GetOrderByOrderId(1);
        var orderByCustomer = _orderSerivce.GetOrderByName(customer);


        Assert.True(orderById.Equals(order)); //.Equal(orderById, order.Id);
        Assert.True(orderByCustomer.Equals(order));//, order.Name);   
    
    }
}

