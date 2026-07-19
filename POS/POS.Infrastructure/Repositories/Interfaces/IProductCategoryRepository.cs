using POS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Infrastructure.Repositories.Interfaces
{
    public interface IProductCategoryRepository
    {
        Task<BaseResponse<string>> GetAllProductCategory();

    }
}
