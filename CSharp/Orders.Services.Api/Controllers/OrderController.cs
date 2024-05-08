using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Orders.Models;
using Orders.Services;

namespace Orders.Controllers;

interface IOrderController {

}
public class OrderController : IOrderController
{
    private IOrderService _orderService;
    public OrderController(IOrderService OrderService) {
        _orderService = OrderService;
    }

    [HttpGet]
    [Route("orders/{id:orderid}")]
    public IActionResult GetOrderByOrderId(int OrderId) {
        var response = _orderService.GetOrderByOrderId(OrderId);

        throw new NotImplementedException();
    }

    [HttpGet]
    [Route("orders/{name:customername}")]
    public IActionResult GetOrderByOrderId(string name) {
        var response = _orderService.GetOrderByName(name);

        throw new NotImplementedException();
    }

}
