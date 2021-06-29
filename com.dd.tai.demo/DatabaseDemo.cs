using ooptaii.com.dd.tai.dao;

using System;
using System.Collections.Generic;
using System.Text;

namespace ooptaii.com.dd.tai.demo
{
    class DatabaseDemo : Database
    {
        const string PRODUCT_TABLE = "productTable";
        const string CATEGORY_TABLE = "categoryTable";
        const string ACCESSORY_TABLE = "accessoryTable";

        Database db = new Database();
        public void insertTableTest()
        {
            ProductDemo productDemo = new ProductDemo();
            if (db.insertTable(PRODUCT_TABLE, productDemo.createProductTest()) == 1)
            {

            }    
        }


        public void print(Database database)
        {
            Console.WriteLine("ad");
        }
    }
}
