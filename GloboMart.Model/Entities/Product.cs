using GloboMart.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.Model
{
    [Serializable]
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ProductTypeId { get; set; }
        public virtual ProductType ProductType { get; set; }
        public decimal Price { get; set; }
    }
}
