using GloboMart.Model;
using GloboMart.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.Service.Products
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product GetById(long id);
        void CreateProduct(Product product);
        void DeleteProduct(Product product);
        IEnumerable<Product> GetProductByType(int typeId);
    }
}
