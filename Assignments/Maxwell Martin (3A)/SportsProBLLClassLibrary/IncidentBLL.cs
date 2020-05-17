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
        private IncidentDAL myIncidentDAL = new IncidentDAL();

        public List<Incident> GetAllIncidents()
        {
            List<Incident> lstAllIncidents = new List<Incident>();
            DataTable dtAllIncidents = new DataTable();

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

        public List<Incident> GetOpenIncidentsByTechnician(int techID)
        {
            List<Incident> lstOpenIncidentsByTechnician = new List<Incident>();
            DataTable dtOpenIncidentsByTechnician = new DataTable();

            try
            {
                //Gets open incidents by technician from DAL.
                dtOpenIncidentsByTechnician = myIncidentDAL.RetrieveOpenIncidentsByTechnician(techID);
            }
            catch
            {
                throw;
            }

            //Transfers data from DataTable to List.
            TransferDataToListOfIncidents(dtOpenIncidentsByTechnician, lstOpenIncidentsByTechnician);

            return lstOpenIncidentsByTechnician;
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

                myIncident.IncidentID = (int)row["IncidentID"];
                myIncident.CustomerID = (int)row["CustomerID"];
                myIncident.ProductCode = row["ProductCode"].ToString();

                //Checks if TechID is null or empty before assigning value.
                if (row["TechID"] == null || row["TechID"].ToString() == "")
                    myIncident.TechID = null;
                else
                    myIncident.TechID = (int)row["TechID"];

                myIncident.DateOpened = (DateTime)row["DateOpened"];

                //Checks if DateClosed is null or empty before assigning value.
                if (row["DateClosed"] == null || row["DateClosed"].ToString() == "")
                    myIncident.DateClosed = null;
                else
                    myIncident.DateClosed = (DateTime)row["DateClosed"];

                myIncident.Title = row["Title"].ToString();
                myIncident.Description = row["Description"].ToString();

                //Adds Incident to list.
                lst.Add(myIncident);
            }
        }
    }
}
