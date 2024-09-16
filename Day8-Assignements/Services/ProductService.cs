using Day8Assignements.Models;
using Day8Assignements.Repositories;

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
    }
}
