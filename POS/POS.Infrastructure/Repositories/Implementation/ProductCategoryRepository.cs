using POS.Domain.Entities;
using POS.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Infrastructure.Repositories.Implementation
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        public async Task<BaseResponse<string>> GetAllProductCategory()
        {
            BaseResponse<string> baseResponse = new BaseResponse<string>();
            baseResponse.Data = "Product Category Fetched Successfully";
            return baseResponse;
        }
    }
}
