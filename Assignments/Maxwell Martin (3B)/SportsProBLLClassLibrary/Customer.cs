using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsProBLLClassLibrary
{
    public class Customer
    {
        //Backing fields.
        private int customerID;
        private string name;

        public Customer()
        {
            //Default Constructor
        }

        /// <summary>
        /// Gets or sets customer's ID.
        /// </summary>
        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        /// <summary>
        /// Gets or sets customer's name.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
