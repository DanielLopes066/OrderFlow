using System.Security.AccessControl;
using Microsoft.AspNetCore.Mvc;
using OrderFlow.Models;
using OrderFlow.Services;

namespace OrderFlow.Controllers {

    [ApiController]
    [Route("api/orders")]
    public class OrdersController : ControllerBase {
        private readonly OrderService _orderService;


        public OrdersController(OrderService orderService) {
            _orderService = orderService;
        }

        [HttpGet()]
        public IActionResult GetOrders() {

            var showMainOrder = _orderService.ReturnOrderList();

            return Ok(showMainOrder);
        }
    }
}



