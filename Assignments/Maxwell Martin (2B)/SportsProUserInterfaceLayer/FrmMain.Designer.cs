namespace SportsProUserInterfaceLayer
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.msMainMenuForm = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMaintainProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMaintainCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMaintainRegistrations = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMaintainTechnicians = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIncidents = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDisplayAllIncidents = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDisplayIncidentsByTechnician = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreateIncident = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdateIncident = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMainMenuForm = new System.Windows.Forms.StatusStrip();
            this.tsslMainMenuForm = new System.Windows.Forms.ToolStripStatusLabel();
            this.msMainMenuForm.SuspendLayout();
            this.ssMainMenuForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMainMenuForm
            // 
            this.msMainMenuForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMainMenuForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiMaintenance,
            this.tsmiRegistration,
            this.tsmiIncidents});
            this.msMainMenuForm.Location = new System.Drawing.Point(0, 0);
            this.msMainMenuForm.Name = "msMainMenuForm";
            this.msMainMenuForm.Size = new System.Drawing.Size(1464, 28);
            this.msMainMenuForm.TabIndex = 1;
            this.msMainMenuForm.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(44, 24);
            this.tsmiFile.Text = "File";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(181, 26);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.ExitApplication);
            // 
            // tsmiMaintenance
            // 
            this.tsmiMaintenance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMaintainProducts,
            this.tsmiMaintainCustomers,
            this.tsmiMaintainRegistrations,
            this.tsmiMaintainTechnicians});
            this.tsmiMaintenance.Name = "tsmiMaintenance";
            this.tsmiMaintenance.Size = new System.Drawing.Size(106, 24);
            this.tsmiMaintenance.Text = "Maintenance";
            // 
            // tsmiMaintainProducts
            // 
            this.tsmiMaintainProducts.Name = "tsmiMaintainProducts";
            this.tsmiMaintainProducts.Size = new System.Drawing.Size(232, 26);
            this.tsmiMaintainProducts.Text = "Maintain Products";
            // 
            // tsmiMaintainCustomers
            // 
            this.tsmiMaintainCustomers.Name = "tsmiMaintainCustomers";
            this.tsmiMaintainCustomers.Size = new System.Drawing.Size(232, 26);
            this.tsmiMaintainCustomers.Text = "Maintain Customers";
            // 
            // tsmiMaintainRegistrations
            // 
            this.tsmiMaintainRegistrations.Name = "tsmiMaintainRegistrations";
            this.tsmiMaintainRegistrations.Size = new System.Drawing.Size(232, 26);
            this.tsmiMaintainRegistrations.Text = "Maintain Registrations";
            // 
            // tsmiMaintainTechnicians
            // 
            this.tsmiMaintainTechnicians.Name = "tsmiMaintainTechnicians";
            this.tsmiMaintainTechnicians.Size = new System.Drawing.Size(232, 26);
            this.tsmiMaintainTechnicians.Text = "Maintain Technicians";
            // 
            // tsmiRegistration
            // 
            this.tsmiRegistration.Name = "tsmiRegistration";
            this.tsmiRegistration.Size = new System.Drawing.Size(101, 24);
            this.tsmiRegistration.Text = "Registration";
            // 
            // tsmiIncidents
            // 
            this.tsmiIncidents.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDisplayAllIncidents,
            this.tsmiDisplayIncidentsByTechnician,
            this.tsmiCreateIncident,
            this.tsmiUpdateIncident});
            this.tsmiIncidents.Name = "tsmiIncidents";
            this.tsmiIncidents.Size = new System.Drawing.Size(80, 24);
            this.tsmiIncidents.Text = "Incidents";
            // 
            // tsmiDisplayAllIncidents
            // 
            this.tsmiDisplayAllIncidents.Name = "tsmiDisplayAllIncidents";
            this.tsmiDisplayAllIncidents.Size = new System.Drawing.Size(289, 26);
            this.tsmiDisplayAllIncidents.Text = "Display All Incidents";
            this.tsmiDisplayAllIncidents.Click += new System.EventHandler(this.DisplayForm);
            // 
            // tsmiDisplayIncidentsByTechnician
            // 
            this.tsmiDisplayIncidentsByTechnician.Name = "tsmiDisplayIncidentsByTechnician";
            this.tsmiDisplayIncidentsByTechnician.Size = new System.Drawing.Size(289, 26);
            this.tsmiDisplayIncidentsByTechnician.Text = "Display Incidents By Technician";
            this.tsmiDisplayIncidentsByTechnician.Click += new System.EventHandler(this.DisplayForm);
            // 
            // tsmiCreateIncident
            // 
            this.tsmiCreateIncident.Name = "tsmiCreateIncident";
            this.tsmiCreateIncident.Size = new System.Drawing.Size(289, 26);
            this.tsmiCreateIncident.Text = "Create Incident";
            // 
            // tsmiUpdateIncident
            // 
            this.tsmiUpdateIncident.Name = "tsmiUpdateIncident";
            this.tsmiUpdateIncident.Size = new System.Drawing.Size(289, 26);
            this.tsmiUpdateIncident.Text = "Update Incident";
            // 
            // ssMainMenuForm
            // 
            this.ssMainMenuForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssMainMenuForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMainMenuForm});
            this.ssMainMenuForm.Location = new System.Drawing.Point(0, 773);
            this.ssMainMenuForm.Name = "ssMainMenuForm";
            this.ssMainMenuForm.Size = new System.Drawing.Size(1464, 25);
            this.ssMainMenuForm.TabIndex = 2;
            this.ssMainMenuForm.Text = "statusStrip1";
            // 
            // tsslMainMenuForm
            // 
            this.tsslMainMenuForm.Name = "tsslMainMenuForm";
            this.tsslMainMenuForm.Size = new System.Drawing.Size(357, 20);
            this.tsslMainMenuForm.Text = "SportsPro Application - Designed By Maxwell Martin";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 798);
            this.Controls.Add(this.ssMainMenuForm);
            this.Controls.Add(this.msMainMenuForm);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMainMenuForm;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sports Pro Application - Main Menu";
            this.msMainMenuForm.ResumeLayout(false);
            this.msMainMenuForm.PerformLayout();
            this.ssMainMenuForm.ResumeLayout(false);
            this.ssMainMenuForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainMenuForm;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiMaintenance;
        private System.Windows.Forms.ToolStripMenuItem tsmiMaintainProducts;
        private System.Windows.Forms.ToolStripMenuItem tsmiMaintainCustomers;
        private System.Windows.Forms.ToolStripMenuItem tsmiMaintainRegistrations;
        private System.Windows.Forms.ToolStripMenuItem tsmiMaintainTechnicians;
        private System.Windows.Forms.ToolStripMenuItem tsmiRegistration;
        private System.Windows.Forms.ToolStripMenuItem tsmiIncidents;
        private System.Windows.Forms.ToolStripMenuItem tsmiDisplayAllIncidents;
        private System.Windows.Forms.ToolStripMenuItem tsmiDisplayIncidentsByTechnician;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreateIncident;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateIncident;
        private System.Windows.Forms.StatusStrip ssMainMenuForm;
        private System.Windows.Forms.ToolStripStatusLabel tsslMainMenuForm;
    }
}

