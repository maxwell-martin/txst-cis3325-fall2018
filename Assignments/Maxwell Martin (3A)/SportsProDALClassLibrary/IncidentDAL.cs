using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SportsProDALClassLibrary
{
    public class IncidentDAL
    {
        public DataTable RetrieveAllIncidents()
        {
            DataTable dtAllIncidents = new DataTable();
            SqlConnection connection = TechSupportDB.GetTechSupportConnection();
            SqlCommand selectAllIncidents = new SqlCommand();
            
            //String for command text.
            string selectStatement =
                "SELECT IncidentID, CustomerID, ProductCode, TechID, " +
                    "DateOpened, DateClosed, Title, Description " +
                "FROM dbo.Incidents;";

            //Sets up command.
            SetUpSqlCommand(selectAllIncidents, connection, selectStatement, CommandType.Text);
            
            try
            {
                connection.Open();

                //Executes query and loads result set into DataTable.
                dtAllIncidents.Load(selectAllIncidents.ExecuteReader());
            }
            catch //Throws exception to calling method.
            {
                throw;
            }

            finally //Closes connection even if exception occurs.
            {
                connection.Close();
            }

            return dtAllIncidents;
        }

        public DataTable RetrieveIncidentsByTechnician(int techID)
        {
            DataTable dtIncidentsByTechnician = new DataTable();
            SqlConnection connection = TechSupportDB.GetTechSupportConnection();
            SqlCommand selectIncidentsByTechID = new SqlCommand();

            //String for command text.
            string selectStatement = 
                "SELECT IncidentID, CustomerID, ProductCode, TechID, " +
                    "DateOpened, DateClosed, Title, Description " +
                "FROM dbo.Incidents " +
                "WHERE TechID = @techID";

            //Sets up SqlCommand.
            SetUpSqlCommand(selectIncidentsByTechID, connection, selectStatement, CommandType.Text);

            //Sets up and adds parameter to command. Default direction is 'Input'.
            selectIncidentsByTechID.Parameters.AddWithValue("@techID", techID);

            try
            {
                connection.Open();

                //Executes query and loads result set into DataTable.
                dtIncidentsByTechnician.Load(selectIncidentsByTechID.ExecuteReader());
            }
            catch //Throws exception to calling method.
            {
                throw;
            }
            finally //Closes connection even if exception occurs.
            {
                connection.Close();
            }

            return dtIncidentsByTechnician;
        }

        public DataTable RetrieveOpenIncidentsByTechnician(int techID)
        {
            DataTable dtOpenIncidentsByTechnician = new DataTable();
            SqlConnection connection = TechSupportDB.GetTechSupportConnection();
            SqlCommand selectOpenIncidentsByTechID = new SqlCommand();

            //String for command text.
            string selectStatement =
                "SELECT IncidentID, CustomerID, ProductCode, TechID, " +
                    "DateOpened, DateClosed, Title, Description " +
                "FROM dbo.Incidents " +
                "WHERE TechID = @techID AND DateClosed IS NULL;";

            //Sets up SqlCommand.
            SetUpSqlCommand(selectOpenIncidentsByTechID, connection, selectStatement, CommandType.Text);

            //Sets up and adds parameter to command. Default direction is 'Input'.
            selectOpenIncidentsByTechID.Parameters.AddWithValue("@techID", techID);

            try
            {
                connection.Open();

                //Executes query and loads result set into DataTable.
                dtOpenIncidentsByTechnician.Load(selectOpenIncidentsByTechID.ExecuteReader());
            }
            catch //Throws exception to calling method.
            {
                throw;
            }
            finally //Closes connection even if exception occurs.
            {
                connection.Close();
            }

            return dtOpenIncidentsByTechnician;
        }

        //Method to set up an SqlCommand.
        private void SetUpSqlCommand(SqlCommand cmd, SqlConnection conn, string cmdText, CommandType cmdType)
        {
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            cmd.CommandType = cmdType;
        }
    }
}
