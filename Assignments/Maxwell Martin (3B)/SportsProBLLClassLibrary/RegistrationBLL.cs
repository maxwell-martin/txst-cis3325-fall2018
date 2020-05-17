using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsProDALClassLibrary;

namespace SportsProBLLClassLibrary
{
    public class RegistrationBLL
    {
        public RegistrationBLL()
        {
            //Default Constructor
        }

        /// <summary>
        /// Sends registration information to RegistrationDAL.
        /// </summary>
        /// <param name="aRegistration">A Registration object.</param>
        /// <returns>True if registration succeeded and false if registration failed.</returns>
        public bool AddNewRegistration(Registration aRegistration)
        {
            RegistrationDAL myRegistrationDAL = new RegistrationDAL();

            //Variables to hold registration information.
            string productCode = aRegistration.ProductCode;
            int customerID = aRegistration.CustomerID;
            DateTime registrationDate = aRegistration.RegistrationDate;
            bool registrationStatus;

            try
            {
                registrationStatus = myRegistrationDAL.RegisterProduct(productCode, customerID, registrationDate);
            }
            catch
            {
                throw;
            }

            return registrationStatus;
        }
    }
}
