using Orders.Models;
using Orders.Data;

namespace Orders.Services;

public interface IOrderService {
    IOrdersEntity GetOrderByOrderId(int id);
    IOrdersEntity GetOrderByName(string name);
 }
public class OrderService : IOrderService {
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository) {
        _orderRepository = orderRepository;
    }
    public IOrdersEntity GetOrderByOrderId(int id) {
        var order = _orderRepository.GetOrderById(id);
        return order;
    }

    public IOrdersEntity GetOrderByName(string name) {
        return _orderRepository.GetOrderByName(name);
    }
}
