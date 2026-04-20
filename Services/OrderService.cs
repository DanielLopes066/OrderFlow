using OrderFlow.Models;

namespace OrderFlow.Services {

    public class OrderService {

        public List<Order> ReturnOrderList() {

            var ordersList = new List<Order>() {

                 new Order {
                     Id = 1,
                     CustomerName = "Monroe",
                 },
                 new Order {
                     Id = 2,
                     CustomerName = "Stevesson",
                 }, new Order {
                     Id = 3,
                     CustomerName = "Thompson",
                 }
            };

            return ordersList;
        }
    }
}
