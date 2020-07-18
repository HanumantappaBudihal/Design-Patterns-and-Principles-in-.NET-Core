using Hexagonal.DesignPatterns.DIUsingUnityIoC.Interfaces;
using System;
using System.Collections.Generic;

namespace Hexagonal.DesignPatterns.DIUsingUnityIoC.Models
{
    public class ProductRepository : IProductRepository
    {
        private List<IProduct> products = new List<IProduct>();
        private int _nextId = 1;

        public ProductRepository()
        {
            // Add products for the Demonstration
            Add(new Product { Name = "Computer", Category = "Electronics", Price = 23.54M });
            Add(new Product { Name = "Laptop", Category = "Electronics", Price = 33.75M });
            Add(new Product { Name = "iPhone4", Category = "Phone", Price = 16.99M });
        }

        public IEnumerable<IProduct> GetAll()
        {
            return products;
        }

        public IProduct Get(int id)
        {
            return products.Find(p => p.Id == id);
        }

        public IProduct Add(IProduct product)
        {
            if (product == null)
            {
                throw new ArgumentNullException("item");
            }

            product.Id = _nextId++;
            products.Add(product);

            return product;
        }

        public bool Update(IProduct product)
        {
            if (product == null)
            {
                throw new ArgumentNullException("item");
            }

            int index = products.FindIndex(p => p.Id == product.Id);
            if (index == -1)
            {
                return false;
            }
            products.RemoveAt(index);
            products.Add(product);

            return true;
        }

        public bool Delete(int id)
        {
            //Need to hadle properly
            //Add the only required to code to undestand the simple
            products.RemoveAll(p => p.Id == id);
            return true;
        }
    }
}