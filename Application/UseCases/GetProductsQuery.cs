using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Application.DTOs;

namespace Application.UseCases
{
    public class GetProductsQuery
    {
        private readonly IRepository<Product> _repository;

        public GetProductsQuery(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ProductDto>> HandleAsync()
        {
            var products = await _repository.GetAllAsync();
            return products.Select(x => new ProductDto
            {
                id = x.Id,
                name = x.Name,
                price = x.Price
            }
            );
        }
    }
}
