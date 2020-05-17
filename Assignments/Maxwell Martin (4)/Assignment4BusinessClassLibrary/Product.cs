using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4BusinessClassLibrary
{
    public class Product
    {
        //Backing Fields. Only necessary fields for this project.
        private string productCode;
        private string name;

        public Product()
        {
            //Default Constructor
        }

        /// <summary>
        /// Gets or sets the product's code.
        /// </summary>
        public string ProductCode
        {
            get { return productCode; }
            set { productCode = value; }
        }

        /// <summary>
        /// Gets or sets the product's name.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
