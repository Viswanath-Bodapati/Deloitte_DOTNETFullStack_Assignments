using Day8Assignements.Models;
using Day8Assignements.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Day8Assignements.Services
{
    public class ProductService:IProductService
    {
        public IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public List<Product> DisplayProducts()
        {
            return _productRepository.DisplayProducts();
        }

        public Product getProductById(int id)
        {
            return _productRepository.getProductById(id);
        }

        public string AddProduct(Product product)
        {
            return _productRepository.AddProduct(product);
        }

        public string EditProduct(Product product)
        {
            return _productRepository.EditProduct(product);
        }

        public string DeleteProduct(int id)
        {
            return _productRepository.DeleteProduct(id);
        }

        public List<Product> GetProductsByCategory(string category)
        {
            return _productRepository.GetProductsByCategory(category);
        }
        public List<Product> OutOfStockProducts()
        {
            return _productRepository.OutOfStockProducts();
        }

        public List<Product> GetProductsBetweenRange(double min, double max)
        {
            return _productRepository.GetProductsBetweenRange(min, max);
        }

        public List<string> GetCategories()
        {
            return _productRepository.GetCategories();
        }
    }
}
