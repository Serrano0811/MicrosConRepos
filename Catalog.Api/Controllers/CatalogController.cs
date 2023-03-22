using Catalog.Api.Entities;
using Catalog.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Api.Controllers
{
	[ApiController]
	[Route("api/v1/[controller]")]
	public class CatalogController : ControllerBase
	{
		private readonly IProductRepository productRepository;

		public CatalogController(IProductRepository productRepository)
        {
			this.productRepository = productRepository;
		}
		
		[HttpPost]
		public async Task<ActionResult<Product>> CreateProduct([FromBody] Product product)
		{
			await productRepository.CreateProduct(product);
			return Ok();
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
		{
			await productRepository.GetProducts();
			return Ok();
		}

		[HttpGet("{id:length(24)}")]
		public async Task<ActionResult<Product>> GetProductById(string id)
		{
			var product = await productRepository.GetProduct(id);
			if (product is null)
				return NotFound();
			
			return product;
		}
    }
}
