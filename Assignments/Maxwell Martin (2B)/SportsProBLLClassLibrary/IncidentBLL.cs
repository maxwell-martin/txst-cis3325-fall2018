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
        public List<Incident> GetAllIncidents()
        {
            List<Incident> lstAllIncidents = new List<Incident>();
            DataTable dtAllIncidents = new DataTable();
            IncidentDAL myIncidentDAL = new IncidentDAL();

            try
            {
                //Gets all incidents from DAL.
                dtAllIncidents = myIncidentDAL.RetrieveAllIncidents();
            }
            catch //Throws exception to calling method.
            {
                throw;
            }

            //Transfers data from DataTable to List.
            TransferDataToListOfIncidents(dtAllIncidents, lstAllIncidents);

            return lstAllIncidents;
        }
        
        public List<Incident> GetIncidentsByTechnician(int techID)
        {
            List<Incident> lstIncidentsByTechnician = new List<Incident>();
            DataTable dtIncidentsByTechnician = new DataTable();
            IncidentDAL myIncidentDAL = new IncidentDAL();

            try
            {
                //Gets incidents by technician from DAL.
                dtIncidentsByTechnician = myIncidentDAL.RetrieveIncidentsByTechnician(techID);
            }
            catch //Throws exception to calling method.
            {
                throw;
            }

            //Transfers data from DataTable to List.
            TransferDataToListOfIncidents(dtIncidentsByTechnician, lstIncidentsByTechnician);

            return lstIncidentsByTechnician;
        }

        //Method to transfer data from DataTable to List.
        private void TransferDataToListOfIncidents(DataTable dt, List<Incident> lst)
        {
            /*
             * Loops through DataTable.
             * Sets values to corresponding Incident properties.
             * Adds each Incident to a list of Incidents.
            */
            foreach (DataRow row in dt.Rows)
            {
                Incident myIncident = new Incident();

                myIncident.CustomerID = (int)row["CustomerID"];

                //Checks if DateClosed is null or empty before assigning value.
                if (row["DateClosed"] == null || row["DateClosed"].ToString() == "")
                    myIncident.DateClosed = null;
                else
                    myIncident.DateClosed = (DateTime)row["DateClosed"];

                myIncident.DateOpened = (DateTime)row["DateOpened"];
                myIncident.Description = row["Description"].ToString();
                myIncident.IncidentID = (int)row["IncidentID"];
                myIncident.ProductCode = row["ProductCode"].ToString();

                //Checks if TechID is null or empty before assigning value.
                if (row["TechID"] == null || row["TechID"].ToString() == "")
                    myIncident.TechID = null;
                else
                    myIncident.TechID = (int)row["TechID"];

                myIncident.Title = row["Title"].ToString();

                //Adds Incident to list.
                lst.Add(myIncident);
            }
        }
    }
}
