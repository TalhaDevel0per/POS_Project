using POS.Application.Services.Interfaces;
using POS.Domain.Entities;
using POS.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Application.Services.Implementation
{
    public class ProductCategoryService : IProductCategoryService
    {
        public readonly IProductCategoryRepository productCategoryRepository;
        public ProductCategoryService(IProductCategoryRepository productCatRepository)
        {
            this.productCategoryRepository = productCatRepository;
        }
        public async Task<BaseResponse<string>> GetAllProductCategory()
        {
            var response = await this.productCategoryRepository.GetAllProductCategory();
            return response;
        }

    }
}
