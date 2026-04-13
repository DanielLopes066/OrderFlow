using OrderFlow.Models;

namespace OrderFlow.Services {

    public class OrderService {

        public List<Order> ReturnOrderList() {

            var ordersList = new List<Order>() {

                 new Order {
                     Id = 1,
                     CustomerName = "Monroe",
                     TotalAmount = 10m
                 },
                 new Order {
                     Id = 2,
                     CustomerName = "Stevesson",
                     TotalAmount = 15m
                 }, new Order {
                     Id = 3,
                     CustomerName = "Thompson",
                     TotalAmount = 7m
                 }
            };

            return ordersList;
        }
    }
}
