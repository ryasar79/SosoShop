using System.Threading.Tasks;
using SOSOSHOP.Business.Commands;
using SOSOSHOP.Business.DTO.Request;
using SOSOSHOP.Business.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SOSOSHOP.Api.Controllers
{
    /// <summary>
    /// Orders Controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        #region fields

        private readonly IMediator _mediator;

        #endregion

        #region ctor

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="mediator"></param>
        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        #endregion

        #region methods

        /// <summary>
        /// Gets the list of all Orders
        /// </summary>
        /// <returns>Returns All Orders List</returns>
        /// <response code="200">Returns All Orders List</response>
        /// <response code="404">If the item is null</response> 
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetAllOrders()
        {
            var result = await _mediator.Send(new GetAllOrdersQuery());
            return Ok(result);
        }

        /// <summary>
        /// Get Order Given By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returns the Given By Id Order</returns>
        /// <response code="200">Returns the Given By Id Order</response>
        /// <response code="404">If the item is null</response> 
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetOrderById(int id)
        {
            var result = await _mediator.Send(new GetOrderByIdQuery(id));
            return Ok(result);
        }

        /// <summary>
        /// Create an Order
        /// </summary>
        /// <param name="createOrderRequest"></param>
        /// <returns>A newly created Order</returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response> 
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderRequest createOrderRequest)
        {
            var result = await _mediator.Send(new CreateOrderCommand(createOrderRequest));
            return Ok(result);
        }

        /// <summary>
        /// Update an Order
        /// </summary>
        /// <param name="updateOrderRequest"></param>
        /// <returns>A newly updated Order</returns>
        /// <response code="200">Returns the newly updated item</response>
        /// <response code="400">If the item is null</response> 
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateOrder([FromBody] UpdateOrderRequest updateOrderRequest)
        {
            var result = await _mediator.Send(new UpdateOrderCommand(updateOrderRequest));
            return Ok(result);
        }

        /// <summary>
        /// Delete Order Given By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returns boolean</returns>
        /// <response code="204">Order Successfully Deleted</response>
        /// <response code="400">If the item is null</response>
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteOrder([FromQuery] int id)
        {
            await _mediator.Send(new DeleteOrderCommand(id));
            return NoContent();
        }

        #endregion
    }
}