using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SportsProDALClassLibrary;

namespace SportsProBLLClassLibrary
{
    public class CustomerBLL
    {
        public CustomerBLL()
        {
            //Default Constructor
        }

        /// <summary>
        /// Retrieves the CustomerID and Name of all customers from the CustomerDAL.
        /// </summary>
        /// <returns>A List of all Customers with each Customer containing his or her CustomerID and Name.</returns>
        public List<Customer> RetrieveCustomerIDandName()
        {
            DataTable dtCustomerIDandName = new DataTable();
            List<Customer> lstCustomerIDandName = new List<Customer>();
            CustomerDAL myCustomerDAL = new CustomerDAL();

            try
            {
                dtCustomerIDandName = myCustomerDAL.GetCustomerIDandName();
            }
            catch //Throws exception to calling method.
            {
                throw;
            }

            TransferDataToListOfCustomers(dtCustomerIDandName, lstCustomerIDandName);

            return lstCustomerIDandName;
        }

        /// <summary>
        /// Takes data from a DataTable and transfers the data to a List of Customers.
        /// A Customer object contains only two properties: CustomerID and Name.
        /// </summary>
        /// <param name="dt">A DataTable object containing records of CustomerID and Name for each customer.</param>
        /// <param name="lst">A List object that can only contain Customer objects.</param>
        private void TransferDataToListOfCustomers(DataTable dt, List<Customer> lst)
        {
            /* Loops through DataTable
             * Sets values to corresponding Customer properties.
             * Adds each Customer to List. */
            foreach(DataRow dr in dt.Rows)
            {
                Customer myCustomer = new Customer();
                myCustomer.CustomerID = (int)dr["CustomerID"];
                myCustomer.Name = dr["Name"].ToString();

                lst.Add(myCustomer);
            }
        }
    }
}
