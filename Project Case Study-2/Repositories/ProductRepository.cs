using Day8Assignements.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day8Assignements.Repositories
{
    public class ProductRepository:IProductRepository
    {
        public SalesDbContext _context;
        public ProductRepository(SalesDbContext context)
        {
            _context = context;
        }
        public List<Product> DisplayProducts()
        {
            List<Product> products = _context.Products.ToList();
            return products;
        }

        public List<Product> GetProductsByCategory(string category)
        {
            List<Product> products = _context.Products.Where(x => x.Category==category).ToList();
            return products;
        }

        public List<Product> OutOfStockProducts()
        {
            List<Product> products = _context.Products.Where(x => x.Quantity == 0).ToList();
            return products;
        }

        public List<Product> GetProductsBetweenRange(double min, double max)
        {
            List<Product> products = _context.Products.Where(x => (x.UnitPrice>min && x.UnitPrice<max)).ToList();
            return products;
        }

        public List<string> GetCategories()
        {
            List<string> categories = (from x in _context.Products
                                       select x.Category).Distinct().ToList();
            return categories;
        }
        public Product getProductById(int id)
        {
            Product productObj = _context.Products.Find(id);
            return productObj;
        }

        public string AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return "New product added to the database successfully...";
        }

        public string EditProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
            return "Product details updated to the database successfully...";

        }

        public string DeleteProduct(int id)
        {
            Product productObj = _context.Products.Find(id);
            if (productObj != null)
            {
                _context.Products.Remove(productObj);
                _context.SaveChanges();
                return "1";
            }
            else
            { return "-1"; }

        }


    }
}
