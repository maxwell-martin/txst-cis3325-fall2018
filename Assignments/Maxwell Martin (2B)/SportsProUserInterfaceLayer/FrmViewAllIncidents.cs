using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportsProBLLClassLibrary;

namespace SportsProUserInterfaceLayer
{
    public partial class FrmViewAllIncidents : Form
    {
        public FrmViewAllIncidents()
        {
            InitializeComponent();
        }

        private void FrmViewAllIncidents_Load(object sender, EventArgs e)
        {
            IncidentBLL bllIncident = new IncidentBLL();
            
            try
            {
                //Gets all incidents from BLL and sets as data source for DGV
                dgvAllIncidents.DataSource = bllIncident.GetAllIncidents();

                /* 
                    * Fixes weird column ordering error.
                    * The FormatColumnOrder() method works for every column except
                    * "DateOpened" and "DateClosed". "DateClosed" would appear before
                    * "DateOpened" even though the DisplayIndex for "DateOpened" is
                    * less than the DisplayIndex for "DateClosed".
                    * 
                    * This is the only fix I found. AutoGenerateColumns = false
                    * must come after setting the DataGridView DataSource.
                */
                dgvAllIncidents.AutoGenerateColumns = false;

                FormatColumnOrder();
            }
            //Action performed after exception has bubbled up from DAL
            //when the database is unreachable.
            catch
            {
                MessageBox.Show("Error accessing data.");
            }
        }

        //Formats columns in correct order.
        private void FormatColumnOrder()
        {
            dgvAllIncidents.Columns["IncidentID"].DisplayIndex = 0;
            dgvAllIncidents.Columns["CustomerID"].DisplayIndex = 1;
            dgvAllIncidents.Columns["ProductCode"].DisplayIndex = 2;
            dgvAllIncidents.Columns["TechID"].DisplayIndex = 3;
            dgvAllIncidents.Columns["DateOpened"].DisplayIndex = 4;
            dgvAllIncidents.Columns["DateClosed"].DisplayIndex = 5;
            dgvAllIncidents.Columns["Title"].DisplayIndex = 6;
            dgvAllIncidents.Columns["Description"].DisplayIndex = 7;
        }

        private void ReturnToMainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
