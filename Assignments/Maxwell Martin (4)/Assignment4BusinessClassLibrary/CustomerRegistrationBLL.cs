using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Assignment4DatabaseClassLibrary;

namespace Assignment4BusinessClassLibrary
{
    public class CustomerRegistrationBLL
    {
        public CustomerRegistrationBLL()
        {
            //Default constructor.
        }

        /// <summary>
        /// Gets all customer registrations for the specified product from the CustomerRegistrationDAL.
        /// </summary>
        /// <param name="prodCode">A string containing the product's code.</param>
        /// <returns>A List of CustomerRegistration objects holding data about each customer's registration.</returns>
        public List<CustomerRegistration> GetCustRegForSpecifiedProd(string prodCode)
        {
            DataTable dtCustRegForSpecifiedProd = new DataTable();
            List<CustomerRegistration> lstCustRegForSpecifiedProd = new List<CustomerRegistration>();
            CustomerRegistrationDAL myCustRegDAL = new CustomerRegistrationDAL();

            try
            {
                dtCustRegForSpecifiedProd = myCustRegDAL.RetrieveCustRegForSpecifiedProduct(prodCode);
            }
            catch //Throws exception to calling method.
            {
                throw;
            }

            TransferDataToListOfCustReg(dtCustRegForSpecifiedProd, lstCustRegForSpecifiedProd);

            return lstCustRegForSpecifiedProd;

        }

        /// <summary>
        /// Takes data from a DataTable and transfers the data to a List of CustomerRegistrations.
        /// </summary>
        /// <param name="dt">A DataTable object containing records of customer registration information.</param>
        /// <param name="lst">A List object that can only contain CustomerRegistration objects.</param>
        private void TransferDataToListOfCustReg(DataTable dt, List<CustomerRegistration> lst)
        {
            /* Loops through DataTable
             * Sets values to corresponding CustomerRegistration properties.
             * Adds each CustomerRegistratoin to list. */
            foreach (DataRow dr in dt.Rows)
            {
                CustomerRegistration myCustReg = new CustomerRegistration();

                myCustReg.CustomerID = (int)dr["CustomerID"];
                myCustReg.Name = dr["Name"].ToString();

                if (string.IsNullOrWhiteSpace(dr["Email"].ToString()))
                    myCustReg.Email = null;
                else
                    myCustReg.Email = dr["Email"].ToString();

                myCustReg.RegistrationDate = (DateTime)dr["RegistrationDate"];

                lst.Add(myCustReg);
            }
        }
    }
}
