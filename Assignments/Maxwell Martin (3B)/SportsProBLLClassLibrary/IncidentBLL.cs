using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SportsProDALClassLibrary;

namespace SportsProBLLClassLibrary
{
    public class IncidentBLL
    {
        //A "global" instance of the IncidentDAL class to be used wherever needed.
        private static IncidentDAL myIncidentDAL = new IncidentDAL();

        public IncidentBLL()
        {
            //Default Constructor
        }

        /// <summary>
        /// Gets all incidents from the IncidentDAL.
        /// </summary>
        /// <returns>A list of all Incidents.</returns>
        public List<Incident> GetAllIncidents()
        {
            List<Incident> lstAllIncidents = new List<Incident>();
            DataTable dtAllIncidents = new DataTable();

            try
            {
                dtAllIncidents = myIncidentDAL.RetrieveAllIncidents();
            }
            catch //Throws exception to calling method.
            {
                throw;
            }
            
            TransferDataToListOfIncidents(dtAllIncidents, lstAllIncidents);

            return lstAllIncidents;
        }
        
        /// <summary>
        /// Gets all incidents for a specific technician from the IncidentDAL.
        /// </summary>
        /// <param name="techID">An integer value for the technician's ID.</param>
        /// <returns>A List of all Incidents for the specified technician.</returns>
        public List<Incident> GetIncidentsByTechnician(int techID)
        {
            List<Incident> lstIncidentsByTechnician = new List<Incident>();
            DataTable dtIncidentsByTechnician = new DataTable();

            try
            {
                dtIncidentsByTechnician = myIncidentDAL.RetrieveIncidentsByTechnician(techID);
            }
            catch //Throws exception to calling method.
            {
                throw;
            }
            
            TransferDataToListOfIncidents(dtIncidentsByTechnician, lstIncidentsByTechnician);

            return lstIncidentsByTechnician;
        }

        /// <summary>
        /// Gets all open incidents for a specific technician from the IncidentDAL.
        /// An open incident is where the DateClosed is null or empty.
        /// </summary>
        /// <param name="techID">An integer value for the technician's ID.</param>
        /// <returns>A List of all open Incidents for the specified technician.</returns>
        public List<Incident> GetOpenIncidentsByTechnician(int techID)
        {
            List<Incident> lstOpenIncidentsByTechnician = new List<Incident>();
            DataTable dtOpenIncidentsByTechnician = new DataTable();

            try
            {
                dtOpenIncidentsByTechnician = myIncidentDAL.RetrieveOpenIncidentsByTechnician(techID);
            }
            catch
            {
                throw;
            }
            
            TransferDataToListOfIncidents(dtOpenIncidentsByTechnician, lstOpenIncidentsByTechnician);

            return lstOpenIncidentsByTechnician;
        }

        /// <summary>
        /// Takes data from a DataTable and transfers the data to a List of Incidents.
        /// </summary>
        /// <param name="dt">A DataTable object containing records of incidents and their corresponding attributes.</param>
        /// <param name="lst">A List object that can only contain Incident objects.</param>
        private void TransferDataToListOfIncidents(DataTable dt, List<Incident> lst)
        {
            /* Loops through DataTable.
             * Sets values to corresponding Incident properties.
             * Adds each Incident to list.*/
            foreach (DataRow row in dt.Rows)
            {
                Incident myIncident = new Incident();

                myIncident.IncidentID = (int)row["IncidentID"];
                myIncident.CustomerID = (int)row["CustomerID"];
                myIncident.ProductCode = row["ProductCode"].ToString();

                //Checks if TechID is null or empty before assigning value.
                if (row["TechID"] == DBNull.Value || row["TechID"].ToString() == string.Empty)
                    myIncident.TechID = null;
                else
                    myIncident.TechID = (int)row["TechID"];

                myIncident.DateOpened = (DateTime)row["DateOpened"];

                //Checks if DateClosed is null or empty before assigning value.
                if (row["DateClosed"] == DBNull.Value || row["DateClosed"].ToString() == string.Empty)
                    myIncident.DateClosed = null;
                else
                    myIncident.DateClosed = (DateTime)row["DateClosed"];

                myIncident.Title = row["Title"].ToString();
                myIncident.Description = row["Description"].ToString();

                lst.Add(myIncident);
            }
        }
    }
}
