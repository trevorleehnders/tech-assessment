
namespace Orders.Models;

public interface IOrdersEntity
{

}
public class OrdersEntity : IOrdersEntity {

    public int Id {get; set;}
    public string? Name {get; set;}

    public OrdersEntity(int id, string customer) {
        Id = id;
        Name = customer;
    }

}
