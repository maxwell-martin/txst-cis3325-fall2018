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
    public partial class FrmViewIncidentsByTechnician : Form
    {
        public FrmViewIncidentsByTechnician()
        {
            InitializeComponent();
        }

        private void GetIncidentsBtn_Click(object sender, EventArgs e)
        {
            //Prevents data in DGV from being added on top of each other.
            dgvIncidentsByTechnician.DataSource = null;

            int techID;

            //Checks if Technician ID entered is a valid integer.
            if (int.TryParse(txtInputTechID.Text, out techID))
            {
                List<Incident> lstAllIncidentsByTechnician = new List<Incident>();
                IncidentBLL bllIncident = new IncidentBLL();

                try
                {
                    //Gets list of all incidents by technician from BLL.
                    lstAllIncidentsByTechnician = bllIncident.GetIncidentsByTechnician(techID);

                    //Checks if the returned list has any Incidents in it.
                    if (lstAllIncidentsByTechnician.Count == 0)
                    {
                        MessageBox.Show("No results found.");
                        txtInputTechID.Focus();
                    }
                    else
                    {
                        //Sets data source for DGV with list of all incidents.
                        dgvIncidentsByTechnician.DataSource = lstAllIncidentsByTechnician;
                        FormatColumnOrder();
                    }
                }
                //Action performed after exception has bubbled up from DAL
                //when the database is unreachable.
                catch
                {
                    MessageBox.Show("Error accessing data.");
                }
            }
            else
            {
                MessageBox.Show("Technician ID entered is invalid.");
                txtInputTechID.Focus();
            }
        }

        private void ReturnToMainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Resets DataGridView and TextBox to original state.
            dgvIncidentsByTechnician.DataSource = null;
            txtInputTechID.Clear();
        }

        //Formats columns in correct order.
        private void FormatColumnOrder()
        {
            dgvIncidentsByTechnician.Columns["IncidentID"].DisplayIndex = 0;
            dgvIncidentsByTechnician.Columns["CustomerID"].DisplayIndex = 1;
            dgvIncidentsByTechnician.Columns["ProductCode"].DisplayIndex = 2;
            dgvIncidentsByTechnician.Columns["TechID"].DisplayIndex = 3;
            dgvIncidentsByTechnician.Columns["DateOpened"].DisplayIndex = 4;
            dgvIncidentsByTechnician.Columns["DateClosed"].DisplayIndex = 5;
            dgvIncidentsByTechnician.Columns["Title"].DisplayIndex = 6;
            dgvIncidentsByTechnician.Columns["Description"].DisplayIndex = 7;
        }
    }
}
