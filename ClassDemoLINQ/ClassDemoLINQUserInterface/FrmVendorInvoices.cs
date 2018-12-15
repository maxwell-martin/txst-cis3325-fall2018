using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassDemoLINQUserInterface
{
    public partial class FrmVendorInvoices : Form
    {
        ClassDemoLINQtoSQLDataContext myDataContext = new ClassDemoLINQtoSQLDataContext();

        public FrmVendorInvoices()
        {
            InitializeComponent();
        }

        private void FrmVendorInvoices_Load(object sender, EventArgs e)
        {
            var vendors = from aVendor in myDataContext.Vendors
                          orderby aVendor.Name
                          select new { aVendor.VendorID, aVendor.Name };

            nameComboBox.DisplayMember = "Name";
            nameComboBox.ValueMember = "VendorID";
            nameComboBox.DataSource = vendors;
            nameComboBox.SelectedIndex = -1;
        }

        private void GetVendorInvoicesDetails()
        {
            int vendorID = (int)nameComboBox.SelectedValue;

            var selectedVendor = (from aVendor in myDataContext.Vendors
                                 where aVendor.VendorID == vendorID
                                 select aVendor).Single();

            vendorBindingSource.Add(selectedVendor);

            invoiceBindingSource.DataSource = selectedVendor.Invoices;
        }

        private void nameComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.GetVendorInvoicesDetails();
        }
    }
}
