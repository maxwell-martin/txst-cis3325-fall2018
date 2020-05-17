using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Assignment4DatabaseClassLibrary
{
    public class ProductDAL
    {
        public ProductDAL()
        {
            //Default constructor.
        }

        /// <summary>
        /// Queries the TechSupport database to get the ProductCode and Name
        /// of all products from the Products table.
        /// </summary>
        /// <returns>A DataTable containing the ProductCode and Name of all products.</returns>
        public DataTable RetrieveAllProducts()
        {
            DataTable dtAllProducts = new DataTable();

            string selectStatement =
                "SELECT ProductCode, Name " +
                "FROM dbo.Products;";

            //Sets up SqlCommand using the parameterized constructor. CommandText is text by default.
            SqlCommand cmdRetrieveAllProducts = new SqlCommand(selectStatement, TechSupportDB.GetTechSupportConnection());

            try
            {
                cmdRetrieveAllProducts.Connection.Open();

                //Executes query and loads result set into the DataTable.
                dtAllProducts.Load(cmdRetrieveAllProducts.ExecuteReader());
            }
            catch //Throws exception to the calling method.
            {
                throw;
            }
            finally //Closes connection even if exception is thrown.
            {
                cmdRetrieveAllProducts.Connection.Close();
            }

            return dtAllProducts;
        }
    }
}
