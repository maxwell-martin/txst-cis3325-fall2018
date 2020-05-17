using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsProUserInterfaceLayer
{
    public partial class FrmMain : Form
    {
        //Instances of the currently available forms.
        static FrmViewAllIncidents allIncidentsFrm = new FrmViewAllIncidents();
        static FrmViewIncidentsByTechnician allIncidentsByTechnicianFrm = new FrmViewIncidentsByTechnician();
        static FrmOpenIncidentsByTechnician allOpenIncidentsByTechnicianFrm = new FrmOpenIncidentsByTechnician();

        public FrmMain()
        {
            InitializeComponent();

            //Properly formats both instances of child forms when Main form is constructed.
            FormatMdiChild(allIncidentsFrm);
            FormatMdiChild(allIncidentsByTechnicianFrm);
            FormatMdiChild(allOpenIncidentsByTechnicianFrm);
        }

        //Display selected form.
        private void DisplayForm(object sender, EventArgs e)
        {
            //Determines which ToolStripMenuItem the user clicked.
            switch (((ToolStripMenuItem)sender).Text)
            {
                case "Display All Incidents":
                    if (HideFormIfOpen(allIncidentsByTechnicianFrm))
                    {
                        ResetFrmViewAllIncidentsByTechnician();
                    }
                    if (HideFormIfOpen(allOpenIncidentsByTechnicianFrm))
                    {
                        ResetFrmOpenIncidentsByTechnician();
                    }
                    allIncidentsFrm.Show();
                    break;
                case "Display Incidents By Technician":
                    HideFormIfOpen(allIncidentsFrm);
                    if (HideFormIfOpen(allOpenIncidentsByTechnicianFrm))
                    {
                        ResetFrmOpenIncidentsByTechnician();
                    }
                    allIncidentsByTechnicianFrm.Show();
                    allIncidentsByTechnicianFrm.txtInputTechID.Focus();
                    break;
                case "Display Open Incidents By Technician":
                    HideFormIfOpen(allIncidentsFrm);
                    if (HideFormIfOpen(allIncidentsByTechnicianFrm))
                    {
                        ResetFrmViewAllIncidentsByTechnician();
                    }
                    allOpenIncidentsByTechnicianFrm.Show();
                    allOpenIncidentsByTechnicianFrm.cboTechnicians.Focus();
                    break;
                default:
                    break;
            }
        }

        //Formats a form to properly attach to parent.
        private void FormatMdiChild(Form someForm)
        {
            someForm.MdiParent = this;
            someForm.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            someForm.Dock = DockStyle.Fill;
        }

        //Closes all forms and exits application.
        private void ExitApplication(object sender, EventArgs e)
        {
            //Disposes and closes all child forms.
            foreach (Form frm in this. MdiChildren)
            {
                frm.Close();
            }
            
            //Disposes and closes the main form.
            this.Close();

            //Exits the application.
            Application.Exit();
        }

        //Hides form if open and tells calling method if the form was open or not.
        private bool HideFormIfOpen(Form frm)
        {
            if (frm.Visible)
            {
                frm.Hide();
                return true;
            }

            return false;
        }

        private void ResetFrmViewAllIncidentsByTechnician()
        {
            allIncidentsByTechnicianFrm.txtInputTechID.Text = string.Empty;
            allIncidentsByTechnicianFrm.dgvIncidentsByTechnician.DataSource = null;
        }

        private void ResetFrmOpenIncidentsByTechnician()
        {
            allOpenIncidentsByTechnicianFrm.cboTechnicians.SelectedIndex = -1;
            allOpenIncidentsByTechnicianFrm.lblTechnicianEmail.Text = string.Empty;
            allOpenIncidentsByTechnicianFrm.lblTechnicianPhone.Text = string.Empty;
            allOpenIncidentsByTechnicianFrm.dgvOpenIncidentsByTechnician.DataSource = null;
        }
    }
}
