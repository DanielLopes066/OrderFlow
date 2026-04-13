using System.Security.AccessControl;
using Microsoft.AspNetCore.Mvc;
using OrderFlow.Models;
using OrderFlow.Services;

namespace OrderFlow.Controllers {

    [ApiController]
    [Route("api/orders")]
    public class OrdersController : ControllerBase {
        private OrderService takeOrder;


        public OrdersController(OrderService _orderService) {
            takeOrder = _orderService;
        }

        [HttpGet()]
        public IActionResult GetOrders() {

            var showMainOrder = takeOrder.ReturnOrderList();

            return Ok(showMainOrder);
        }
    }
}



