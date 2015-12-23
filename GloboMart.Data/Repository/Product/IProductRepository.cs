﻿using GloboMart.Model;
using GloboMart.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.Data.Repository.Products
{
    public interface IProductRepository
    {
        Product GetByProductId(long id);
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
        IEnumerable<Product> GetAllProduct();
        IEnumerable<Product> GetProductByType(Expression<Func<Product, bool>> exp);
    }
}
