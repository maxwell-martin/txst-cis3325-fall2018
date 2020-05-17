using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4BusinessClassLibrary
{
    public class CustomerRegistration
    {
        //Backing fields.
        private int customerID;
        private string name;
        private string email;
        private DateTime registrationDate;

        public CustomerRegistration()
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

        /// <summary>
        /// Gets or sets customer's email. Can be null.
        /// </summary>
        public string Email
        {
            get { return email; }
            set { email = value; }
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
