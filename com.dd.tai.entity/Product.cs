using System;
using System.Collections.Generic;
using System.Text;

namespace ooptaii
{
    class Product
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int categoryId;

        public int CategoryID
        {
            get { return categoryId; }
            set { categoryId = value; }
        }

    }
}
