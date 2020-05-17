using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Assignment4DatabaseClassLibrary
{
    public class CustomerRegistrationDAL
    {
        public CustomerRegistrationDAL()
        {
            //Default constructor.
        }

        /// <summary>
        /// Queries the TechSupport database to retrieve all customer registrations for a specific product
        /// using a stored procedure called "spCustomerProductRegistrations."
        /// </summary>
        /// <param name="prodCode">A string containing the product's code.</param>
        /// <returns>A DataTable containing all customer registrations for the given product.</returns>
        public DataTable RetrieveCustRegForSpecifiedProduct(string prodCode)
        {
            DataTable dtCustRegForSpecifiedProd = new DataTable();

            /* Sets up SqlCommand using the parameterized constructor.
             * CommandText is set to the name of the stored procedure. */
            SqlCommand cmdCustRegForSpecifiedProd = 
                new SqlCommand("spCustomerProductRegistrations", TechSupportDB.GetTechSupportConnection());

            //Changes SqlCommand's CommandType to StoredProcedure and sets up the needed parameter.
            cmdCustRegForSpecifiedProd.CommandType = CommandType.StoredProcedure;
            cmdCustRegForSpecifiedProd.Parameters.AddWithValue("@ProductCode", prodCode);

            try
            {
                cmdCustRegForSpecifiedProd.Connection.Open();

                //Executes query and loads result set into the DataTable.
                dtCustRegForSpecifiedProd.Load(cmdCustRegForSpecifiedProd.ExecuteReader());
            }
            catch //Throws exception to the calling method.
            {
                throw;
            }
            finally //Closes connection even if exception is thrown.
            {
                cmdCustRegForSpecifiedProd.Connection.Close();
            }

            return dtCustRegForSpecifiedProd;
        }
    }
}
