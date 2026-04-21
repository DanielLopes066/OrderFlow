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
        public IActionResult GetAllOrders() {

            var createdOrder = _orderService.GetAllOrders();

            return Ok(createdOrder);
        }


        [HttpPost()]
        public IActionResult CreateOrder(Order order) {

            try {
                var showMainOrder = _orderService.CreateOrder(order);
                return Ok(showMainOrder);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}



