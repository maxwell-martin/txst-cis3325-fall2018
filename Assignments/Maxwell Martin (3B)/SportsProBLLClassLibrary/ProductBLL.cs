using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SportsProDALClassLibrary;

namespace SportsProBLLClassLibrary
{
    public class ProductBLL
    {
        public ProductBLL()
        {
            //Default Constructor
        }

        /// <summary>
        /// Retrieves the ProductCode and Name of all products from the ProductDAL.
        /// </summary>
        /// <returns>A List of Products with each Product containing its ProductCode and Name.</returns>
        public List<Product> RetrieveProductNameAndCode()
        {
            DataTable dtProductNameAndCode = new DataTable();
            List<Product> lstProductNameAndCode = new List<Product>();
            ProductDAL myProductDAL = new ProductDAL();

            try
            {
                dtProductNameAndCode = myProductDAL.GetProductNameAndCode();
            }
            catch //Throws exception to calling method.
            {
                throw;
            }
            
            TransferDataToListOfProducts(dtProductNameAndCode, lstProductNameAndCode);

            return lstProductNameAndCode;
        }

        /// <summary>
        /// Takes data from a DataTable and transfers the data to a List of Products.
        /// A Product object contains only two properties: ProductCode and Name.
        /// </summary>
        /// <param name="dt">A DataTable object containing records of ProductCode and Name for each product.</param>
        /// <param name="lst">A List object that can only contain Product objects.</param>
        private void TransferDataToListOfProducts(DataTable dt, List<Product> lst)
        {
            /* Loops through DataTable
             * Sets values to corresponding Product properties.
             * Adds each Product to list. */
            foreach (DataRow dr in dt.Rows)
            {
                Product myProduct = new Product();
                myProduct.ProductCode = dr["ProductCode"].ToString();
                myProduct.Name = dr["Name"].ToString();

                lst.Add(myProduct);
            }
        }
    }
}
