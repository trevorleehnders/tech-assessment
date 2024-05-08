using Orders.Models;

namespace Orders.Data;
public interface IOrderRepository
{
    IOrdersEntity GetOrderById(int id);
    IOrdersEntity GetOrderByName(string name);
}
public class OrderRepository : IOrderRepository
{
    public IOrdersEntity GetOrderById(int id)
    {
        return new OrdersEntity(1, "Data layer");
    }

    public IOrdersEntity GetOrderByName(string name)
    {
        return new OrdersEntity(1, "Data layer");
    }
}