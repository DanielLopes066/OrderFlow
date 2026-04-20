using OrderFlow.Models;

namespace OrderFlow.Models {

    public class Order {

        public int Id { get; set; }
        public string CustomerName { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();      
    }
}
