using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SportsProDALClassLibrary
{
    public class TechnicianDAL
    {
        public DataTable RetrieveTechnicianNames()
        {
            DataTable dtTechnicianNames = new DataTable();
            SqlConnection connection = TechSupportDB.GetTechSupportConnection();
            SqlCommand selectTechnicianNames = new SqlCommand();

            //Select statement to retrieve all technician names;
            string selectStatement =
                "SELECT TechID, Name " +
                "FROM dbo.Technicians;";

            //Sets up SqlCommand.
            SetUpSqlCommand(selectTechnicianNames, connection, selectStatement, CommandType.Text);

            try
            {
                connection.Open();

                //Executes query and loads result set into DataTable.
                dtTechnicianNames.Load(selectTechnicianNames.ExecuteReader());
            }
            catch //Throws exception to calling method.
            {
                throw;
            }
            finally //Closes connection even if exception occurs.
            {
                connection.Close();
            }

            return dtTechnicianNames;
        }

        public DataTable RetrieveTechnicianDetails(int techID)
        {
            DataTable dtTechnicianDetails = new DataTable();
            SqlConnection connection = TechSupportDB.GetTechSupportConnection();
            SqlCommand selectTechnicianDetails = new SqlCommand();

            //Select technician details.
            string selectStatement =
                "SELECT Email, Phone " +
                "FROM dbo.Technicians " +
                "WHERE TechID = @techID;";

            //Sets up SqlCommand.
            SetUpSqlCommand(selectTechnicianDetails, connection, selectStatement, CommandType.Text);

            //Sets up and adds parameter to SqlCommand.
            selectTechnicianDetails.Parameters.AddWithValue("@techID", techID);

            try
            {
                connection.Open();

                //Executes query and loads result set into DataTable.
                dtTechnicianDetails.Load(selectTechnicianDetails.ExecuteReader());
            }
            catch //Throws exception to calling method.
            {
                throw;
            }
            finally //Closes connection even if exception occurs.
            {
                connection.Close();
            }

            return dtTechnicianDetails;
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
