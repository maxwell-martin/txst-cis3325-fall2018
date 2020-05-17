using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsProBLLClassLibrary
{
    public class Registration
    {
        //Backing fields.
        private int customerID;
        private string productCode;
        private DateTime registrationDate;

        public Registration()
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
        /// Gets or sets product's code of product being registered.
        /// </summary>
        public string ProductCode
        {
            get { return productCode; }
            set { productCode = value; }
        }

        /// <summary>
        /// Gets or sets the registration date.
        /// </summary>
        public DateTime RegistrationDate
        {
            get { return registrationDate; }
            set { registrationDate = value; }
        }
    }
}
