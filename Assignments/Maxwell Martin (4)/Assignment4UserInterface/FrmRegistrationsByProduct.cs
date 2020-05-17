using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment4BusinessClassLibrary;

namespace Assignment4UserInterface
{
    public partial class FrmRegistrationsByProduct : Form
    {
        //Used to access the CustomerRegistrationBLL.
        CustomerRegistrationBLL myCustRegBLL = new CustomerRegistrationBLL();

        //Holds all customer registrations.
        List<CustomerRegistration> lstCustRegForSpecifiedProd = new List<CustomerRegistration>();

        public FrmRegistrationsByProduct()
        {
            InitializeComponent();
        }

        private void CboProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Variable to hold the selected product's code.
            string prodCode = cboProduct.SelectedValue.ToString();

            //Prevents new data from stacking on top of old data.
            dgvCustomerRegistration.Rows.Clear();

            /* Without this line of code, for whatever reason, the DisplayMembers (the Names of all the Products) 
             * rearrange after a Product has been selected. Clearing the DataBindings every time a Product is 
             * selected solved this problem. */
            cboProduct.DataBindings.Clear();

            try
            {
                lstCustRegForSpecifiedProd = myCustRegBLL.GetCustRegForSpecifiedProd(prodCode);

                AddObjectsToBindingSource(lstCustRegForSpecifiedProd, bsCustomerRegistration);
            }
            catch //Action after exception has bubbled up from the DAL.
            {
                MessageBox.Show("Error accessing the database.", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmRegistrationsByProduct_Load(object sender, EventArgs e)
        {
            ProductBLL myProductBLL = new ProductBLL();
            List<Product> lstAllProducts = new List<Product>();

            try
            {
                lstAllProducts = myProductBLL.GetAllProducts();

                AddObjectsToBindingSource(lstAllProducts, bsProduct);

                //Prevents a pre-selected product from appearing.
                cboProduct.SelectedIndex = -1;
            }
            catch //Action after exception has bubbled up from the DAL.
            {
                MessageBox.Show("Error accessing the database.", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Generic method to loop through a List of objects and 
        /// add each object to the binding source specified.
        /// </summary>
        /// <typeparam name="Object">Any object the user uses inside the specified List.</typeparam>
        /// <param name="lst">A List containing any type of object.</param>
        /// <param name="bs">A BindingSource object.</param>
        private void AddObjectsToBindingSource<Object>(List<Object> lst, BindingSource bs)
        {
            foreach (Object obj in lst)
            {
                bs.Add(obj);
            }
        }

        //Closes the form and exits the application.
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
