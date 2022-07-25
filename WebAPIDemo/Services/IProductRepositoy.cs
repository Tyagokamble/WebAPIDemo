using WebAPIDemo.Model;

namespace WebAPIDemo.Services
{
    public interface IProductRepositoy
    {
        int AddProduct(Product prod);
    }
}