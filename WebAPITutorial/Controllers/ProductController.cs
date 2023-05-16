using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPITutorial.Models.Dto.Product;
using WebAPITutorial.Models.ORM;

namespace WebAPITutorial.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            AlohaCRMContext context = new AlohaCRMContext();

            List<GetAllProductsResponseDto> result = context.Products.Include("Category").Select(x => new GetAllProductsResponseDto()
            {
                Id = x.Id,
                Name = x.Name,
                UnitPrice = x.UnitPrice,
                CategoryName = x.Category.Name
            }).ToList();


            return Ok(result);

        }

        [HttpGet("{id}")]
        public IActionResult Index(int id)
        {
            AlohaCRMContext alohaCRMContext = new AlohaCRMContext();

            Product product = alohaCRMContext.Products.FirstOrDefault(x => x.Id == id);

            if (product == null)
            {
                return NotFound(id + " idye sahip urun bulunamadi");
            }
            else
            {
                GetProductByIdResponseDto response = new GetProductByIdResponseDto();
                response.Name = product.Name.ToUpper();
                response.UnitPrice = product.UnitPrice;
                response.Stock = product.UnitsInStock;

                return Ok(response);
            }

        }


        [HttpGet("categories/{id}")]
        public IActionResult GetProductsByCategoryId(int id)
        {
            return Ok();
        }


        [HttpPost]
        public IActionResult Add(CreateProductRequestDto request)
        { 
            AlohaCRMContext context = new AlohaCRMContext();

            Product product = new Product();
            product.Name = request.Name;
            product.UnitPrice = request.UnitPrice;
            product.UnitsInStock= request.UnitsInStock;

            context.Products.Add(product);
            context.SaveChanges();

            return Created("OK",request);


        }
        
    }
}
