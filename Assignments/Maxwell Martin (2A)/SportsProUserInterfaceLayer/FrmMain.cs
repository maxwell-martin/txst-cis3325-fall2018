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
        //Instance of form to be displayed.
        static FrmViewAllIncidents allIncidentsFrm = new FrmViewAllIncidents();

        public FrmMain()
        {
            InitializeComponent();

            //Properly formats instance of child form when Main form is constructed.
            FormatMdiChild(allIncidentsFrm);
        }

        //Display selected form.
        private void DisplayForm(object sender, EventArgs e)
        {
            //Determines which ToolStripMenuItem the user clicked.
            if (((ToolStripMenuItem)sender).Text == "Display All Incidents")
            {
                allIncidentsFrm.Show();
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
            this.Close();
            allIncidentsFrm.Close();
            Application.Exit();
        }
    }
}
