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
    /// Products Controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        #region fields

        private readonly IMediator _mediator;

        #endregion

        #region ctor

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="mediator"></param>
        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        #endregion

        #region methods

        /// <summary>
        /// Gets the list of all Products
        /// </summary>
        /// <returns>Returns All Products List</returns>
        /// <response code="200">Returns All Products List</response>
        /// <response code="404">If the item is null</response> 
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetAllProducts()
        {
            var result = await _mediator.Send(new GetAllProductsQuery());
            return Ok(result);
        }

        /// <summary>
        /// Get Product Given By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returns the Given By Id Product</returns>
        /// <response code="200">Returns the Given By Id Product</response>
        /// <response code="404">If the item is null</response> 
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetProductById(int id)
        {
            var result = await _mediator.Send(new GetProductByIdQuery(id));
            return Ok(result);
        }

        /// <summary>
        /// Create an Product
        /// </summary>
        /// <param name="createProductRequest"></param>
        /// <returns>A newly created Product</returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response> 
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductRequest createProductRequest)
        {
            var result = await _mediator.Send(new CreateProductCommand(createProductRequest));
            return Ok(result);
        }

        /// <summary>
        /// Update an Product
        /// </summary>
        /// <param name="updateProductRequest"></param>
        /// <returns>A newly updated Product</returns>
        /// <response code="200">Returns the newly updated item</response>
        /// <response code="400">If the item is null</response> 
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateProduct([FromBody] UpdateProductRequest updateProductRequest)
        {
            var result = await _mediator.Send(new UpdateProductCommand(updateProductRequest));
            return Ok(result);
        }

        /// <summary>
        /// Delete Product Given By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returns boolean</returns>
        /// <response code="204">Product Successfully Deleted</response>
        /// <response code="400">If the item is null</response>
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteProduct([FromQuery] int id)
        {
            await _mediator.Send(new DeleteProductCommand(id));
            return NoContent();
        }

        #endregion
    }
}