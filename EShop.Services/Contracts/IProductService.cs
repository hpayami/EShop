using EShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Services.Contracts
{
    public interface IProductService
    {
        void Add(Product product);
        List<Product> GetAll();
    }
}
