using GloboMart.Data.Infrastructure;
using GloboMart.Data.Repository.Products;
using GloboMart.Model;
using GloboMart.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.Service.Products
{
    public class ProductService : IProductService
    {
        private IProductRepository ProductRepository;
        private IUnitOfWork UnitOfWork;

        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork){
            ProductRepository=productRepository;
            UnitOfWork = unitOfWork;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return ProductRepository.GetAllProduct();
        }

        public Product GetById(long id)
        {
            return ProductRepository.GetByProductId(id);
        }

        public void CreateProduct(Product product)
        {
            ProductRepository.CreateProduct(product);
            UnitOfWork.Commit();
        }

        public void DeleteProduct(Product product)
        {
            ProductRepository.DeleteProduct(product);
            UnitOfWork.Commit();
        }

        public IEnumerable<Product> GetProductByType(int typeId)
        {
            return ProductRepository.GetProductByType(X => typeId.Equals(X.ProductTypeId));
        }
    }
}
