using Day8Assignements.Models;
using Microsoft.EntityFrameworkCore;

namespace Day8Assignements.Repositories
{
    public interface IProductRepository
    {
        public List<Product> DisplayProducts();

        public Product getProductById(int id);

        public string AddProduct(Product product);

        public string EditProduct(Product product);

        public string DeleteProduct(int id);
  
    }
}
