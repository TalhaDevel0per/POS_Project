using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POS.Application.Services.Interfaces;
using POS.Domain.Entities;
using POS.Infrastructure.Repositories.Interfaces;

namespace POS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        public readonly IProductCategoryService productCategoryService;
        public ProductCategoryController(IProductCategoryService productCatService) {
            this.productCategoryService = productCatService;

        }
        [HttpGet]
        [Route("GetAllProductCategory")]
        public async  Task<BaseResponse<string>> GetAllProductCategory()
        {
            var response = await this.productCategoryService.GetAllProductCategory();
            return response;

        }
    }
}
