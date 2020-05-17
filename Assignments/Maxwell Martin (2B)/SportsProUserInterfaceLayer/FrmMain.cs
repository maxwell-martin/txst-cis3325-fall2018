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
        //Instances of the two forms to be displayed.
        static FrmViewAllIncidents allIncidentsFrm = new FrmViewAllIncidents();
        static FrmViewIncidentsByTechnician allIncidentsByTechnicianFrm = new FrmViewIncidentsByTechnician();

        public FrmMain()
        {
            InitializeComponent();

            //Properly formats both instances of child forms when Main form is constructed.
            FormatMdiChild(allIncidentsFrm);
            FormatMdiChild(allIncidentsByTechnicianFrm);
        }

        //Display selected form.
        private void DisplayForm(object sender, EventArgs e)
        {
            //Determines which ToolStripMenuItem the user clicked.
            if (((ToolStripMenuItem)sender).Text == "Display All Incidents")
            {
                HideFormIfOpen(allIncidentsByTechnicianFrm);
                allIncidentsFrm.Show();
            }
            else if (((ToolStripMenuItem)sender).Text == "Display Incidents By Technician")
            {
                HideFormIfOpen(allIncidentsFrm);
                allIncidentsByTechnicianFrm.Show();
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
            /*
             * After stepping through each line of code that comes
             * after this.Close(), it appears that this.Close()
             * automatically disposes my two child forms and itself. 
             * Because of this, I did not include the foreach loop to 
             * dispose of the two forms.
            */
            this.Close();
            Application.Exit();
        }

        private void HideFormIfOpen(Form frm)
        {
            if (frm.Visible)
            {
                frm.Hide();
            }
        }
    }
}
