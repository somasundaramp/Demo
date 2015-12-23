using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using GloboMart.Data;
using GloboMart.Model;
using GloboMart.Service.Products;
using GloboMart.Data.Infrastructure;

namespace GloboMart.Service.Controllers
{
    public class ProductsController : ApiController
    {
        private IProductService ProductService;

        public ProductsController(IProductService productService)
        {
            ProductService = productService;
        }

        // GET: api/Products
        [ResponseType(typeof(Product))]
        public IHttpActionResult GetAllProducts()
        {
            List<Product> product = ProductService.GetAllProducts().ToList();
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // GET: api/Products/5
        [ResponseType(typeof(Product))]
        public IHttpActionResult GetProduct(int id)
        {
            Product product = ProductService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // POST: api/Products
        [ResponseType(typeof(Product))]
        public IHttpActionResult PostProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            ProductService.CreateProduct(product);
            return CreatedAtRoute("DefaultApi", new { id = product.ID }, product);
        }

        // DELETE: api/Products/5
        [ResponseType(typeof(Product))]
        public IHttpActionResult DeleteProduct(int id)
        {
            Product product = ProductService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }

            ProductService.DeleteProduct(product);
            return Ok(product);
        }

        // GET: api/Products/5
        [ResponseType(typeof(Product))]
        public IHttpActionResult GetProductByType(int typeId)
        {
            List<Product> product = ProductService.GetProductByType(typeId).ToList();
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }
    }
}