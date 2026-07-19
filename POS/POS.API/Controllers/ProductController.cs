//using Microsoft.AspNetCore.Mvc;
//using POS.Application.Services.Interfaces;

//namespace POS.API.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProductController : ControllerBase
//    {
//        private readonly IProductService_productService;

//        public ProductController(IProductService productService)
//        {
//            _productService = productService;
//        }

//        [HttpGet("GetAll")]
//        public IActionResult GetAll()
//        {
//            var data = _productService.GetAllProducts();

//            return Ok(data);
//        }
//    }
//}