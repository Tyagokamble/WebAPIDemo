using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo.Model;

namespace WebAPIDemo.Services
{
    public class ProductServices : IProductServices
    {
        private readonly IProductRepositoy _iProductRepo;
        // Injecition of Dependancy using constructor
        public ProductServices(IProductRepositoy iProductRepo)
        {
            _iProductRepo = iProductRepo;
        }


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
