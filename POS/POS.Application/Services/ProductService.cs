using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using POS.Application.DTOs;
using POS.Application.Services.Interfaces;

namespace POS.Application.Services
{
    public class ProductService : IProductService
    {
        public List<ProductDto> GetAllProducts()
        {
            return new List<ProductDto>
            {
                new ProductDto
                {
                    Id = 1,
                    Name = "Laptop",
                    Category = "Electronics",
                    Price = 85000,
                    Stock = 10
                },

                new ProductDto
                {
                    Id = 2,
                    Name = "Mouse",
                    Category = "Accessories",
                    Price = 1500,
                    Stock = 50
                },

                new ProductDto
                {
                    Id = 3,
                    Name = "Keyboard",
                    Category = "Accessories",
                    Price = 3500,
                    Stock = 35
                },

                new ProductDto
                {
                    Id = 4,
                    Name = "Monitor",
                    Category = "Electronics",
                    Price = 28000,
                    Stock = 15
                },

                new ProductDto
                {
                    Id = 5,
                    Name = "Printer",
                    Category = "Office",
                    Price = 32000,
                    Stock = 8
                }
            };
        }
    }
}