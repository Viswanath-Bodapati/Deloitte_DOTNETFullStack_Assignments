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

        public List<Product> GetProductsByCategory(string category);

        public List<Product> OutOfStockProducts();

        public List<Product> GetProductsBetweenRange(double min, double max);

        public List<string> GetCategories();
    }
}
