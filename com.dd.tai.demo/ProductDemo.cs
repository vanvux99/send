
using System;
using System.Collections.Generic;
using System.Text;

namespace ooptaii.com.dd.tai.demo
{
    class ProductDemo : Product
    {
        public Product createProductTest(int x, string y, int z)
        {
            Product product = new Product();
            product.ID = x;
            product.Name = y;
            product.CategoryID = z;

            return product;
        }

        public void PrintProduct(Product product)
        {
            Console.WriteLine("Product: id = {0}, name = {1}, categoryID = {2}", product.ID, product.Name, product.CategoryID);
        }
    }
}
