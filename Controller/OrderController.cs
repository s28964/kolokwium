using Kolokwium.DTOs;
using Kolokwium.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium.Controller;

[ApiController]
[Route("api/[controller]")]
public class OrderController
{

    public class OrdersController : ControllerBase
    {
        private readonly IDbService _dbService;

        public OrdersController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet("{id}/purchases")]
        public async Task<IActionResult> GetOrder(int id)
        {
            try
            {
                var order = await _dbService.GetClientOrders(id);
                return Ok(order);
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }
        
        [HttpPut("/customers")]
        public async Task<IActionResult> AddCustomerWithTickets(int orderId, AddCustomerWithTicketsDto dto)
        {
            try
            {
                await _dbService.AddCustomerWithTickets(orderId, dto);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}