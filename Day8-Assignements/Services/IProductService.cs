using Day8Assignements.Models;

namespace Day8Assignements.Services
{
    public interface IProductService
    {
        public List<Product> DisplayProducts();

        public Product getProductById(int id);

        public string AddProduct(Product product);

        public string EditProduct(Product product);

        public string DeleteProduct(int id);
    }
}
