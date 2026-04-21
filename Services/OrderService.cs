using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Http.HttpResults;
using OrderFlow.Models;

namespace OrderFlow.Services {

    public class OrderService {

        private static readonly List<Order> _orders = new List<Order>();

        public List<Order> GetAllOrders() {
            return _orders;
        }

        public Order CreateOrder(Order order) {

            if (order.OrderItems == null || order.OrderItems.Count == 0) {
                throw new Exception("Pedido deve ter pelo menos um item");
            }

            order.Id = _orders.Count + 1;
            order.Status = OrderStatus.Pending;
            _orders.Add(order);
            return order;
        }
    }
}
