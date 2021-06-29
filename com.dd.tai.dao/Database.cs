using ooptaii.com.dd.tai.entity;

using System;
using System.Collections.Generic;
using System.Text;

namespace ooptaii.com.dd.tai.dao
{
    class Database
    {
        const string PRODUCT_TABLE = "productTable";
        const string CATEGORY_TABLE = "categoryTable";
        const string ACCESSORY_TABLE = "accessoryTable";

        public List<Product> productTable = new List<Product>();
        public List<Category> categoryTable = new List<Category>();
        public List<Accessory> accessoryTable = new List<Accessory>();


        // thêm từng dòng dữ liệu vào array theo name tương ứng
        public int insertTable(string name, dynamic row)
        {
            int countListProduct = productTable.Count;
            int countListCategory = categoryTable.Count;
            int countListAccessory = accessoryTable.Count;

            switch (name)
            {
                case PRODUCT_TABLE:
                    productTable.Add(row);
                        if (productTable.Count != countListProduct)
                            return 1;
                    break;

                case CATEGORY_TABLE:
                    categoryTable.Add(row);
                    if (categoryTable.Count != countListCategory)
                        return 1;
                    break;

                case ACCESSORY_TABLE:
                    accessoryTable.Add(row);
                    if (accessoryTable.Count != countListAccessory)
                        return 1;
                    break;
            }

            return 0;
        }


        // duyệt toàn bộ mảng name 
        public List<dynamic> selectTable(string name)
        {
            List<dynamic> result = new List<dynamic>();

            switch (name)
            {
                case PRODUCT_TABLE:
                    foreach (Product productItem in productTable)
                    {
                        result.Add(productItem);
                    }
                    break;

                case CATEGORY_TABLE:
                    foreach (Category categoryItem in categoryTable)
                    {
                        result.Add(categoryItem);
                    }
                    break;

                case ACCESSORY_TABLE:
                    foreach (Accessory accessoryItem in accessoryTable)
                    {
                        result.Add(accessoryItem);
                    }
                    break;
            }

            return result;
        }


        // cập nhật lại thông tin cho từng mảng theo id của row 
        public int updateList(string name, dynamic row)
        {
            switch (name)
            {
                case PRODUCT_TABLE:
                    row = (Product) row;
                    foreach (Product item in productTable)
                    {
                        if (item.ID == row.ID)
                        {
                            item.Name = row.Name;
                            item.CategoryID = row.CategoryID;
                        }
                        return 1;
                    }
                    break;

                case CATEGORY_TABLE:
                    row = (Category) row;
                    foreach (Category item in categoryTable)
                    {
                        if (item.ID == row.ID)
                        {
                            item.Name = row.Name;
                        }
                        return 1;
                    }
                    break;

                case ACCESSORY_TABLE:
                    row = (Accessory) row;
                    foreach (Accessory item in accessoryTable)
                    {
                        if (item.ID == row.ID)
                        {
                            item.Name = row.Name;
                        }
                        return 1;
                    }
                    break;
            }

            return 0;
        }


        // xóa 1 phần tử trong database dựa trên id của row
        public bool deleteList(string name, dynamic row)
        {
            switch (name)
            {
                case PRODUCT_TABLE:
                    row = (Product) row;
                    foreach (Product item in productTable)
                    {
                        if (item.ID == row.ID)
                        {
                            productTable.Remove(item);
                        }
                        return true;
                    }
                    break;

                case CATEGORY_TABLE:
                    row = (Category) row;
                    foreach (Category item in categoryTable)
                    {
                        if (item.ID == row.ID)
                        {
                            categoryTable.Remove(item);
                        }
                        return true;
                    }
                    break;

                case ACCESSORY_TABLE:
                    row = (Accessory) row;
                    foreach (Accessory item in accessoryTable)
                    {
                        if (item.ID == row.ID)
                        {
                            accessoryTable.Remove(item);
                        }
                        return true;
                    }
                    break;
            }

            return false;
        }


        // xóa toàn bộ database
        public void truncateTable(string name)
        {
            switch (name)
            {
                case PRODUCT_TABLE:
                    productTable.Clear();
                    break;

                case CATEGORY_TABLE:
                    categoryTable.Clear();
                    break;

                case ACCESSORY_TABLE:
                    accessoryTable.Clear();
                    break;
            }
        }
    }
}
