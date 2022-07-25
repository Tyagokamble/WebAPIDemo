using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo.Model;

namespace WebAPIDemo.Services
{
    public class ProductRepository : IProductRepository
    {
        public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int AddProduct(Product prod)
        {
            throw new NotImplementedException();
        }

        public int DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public int ModifyProduct(Product prod)
        {
            throw new NotImplementedException();
        }
    }
}

