using EShop.DataLayer.Context;
using EShop.Entities;
using EShop.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EShop.Services.EFServices
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _uow;
        private readonly DbSet<Product> _product;

        public ProductService(IUnitOfWork uow)
        {
            _uow = uow;
            _product = uow.Set<Product>();
        }

        public void Add(Product product)
         => _product.Add(product);

        public List<Product> GetAll()
            => _product.ToList();
    }
}
