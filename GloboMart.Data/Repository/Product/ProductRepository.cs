using GloboMart.Data.Infrastructure;
using GloboMart.Model;
using GloboMart.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.Data.Repository.Products
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {            
        }

        public Product GetByProductId(long id) 
        {
            return this.GetById(id);
        }

        public void CreateProduct(Product product)
        {
            if (product == null) throw new ArgumentNullException("product");
            this.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            if (product == null) throw new ArgumentNullException("product");
            this.Update(product);
        }

        public void DeleteProduct(Product product)
        {
            if (product == null) throw new ArgumentNullException("product");
            this.Delete(product);
        }

        public IEnumerable<Product> GetAllProduct()
        {
            return this.GetAll();
        }

        public IEnumerable<Product> GetProductByType(Expression<Func<Product, bool>> exp)
        {
            return this.GetMany(exp);
        }
    }
}
