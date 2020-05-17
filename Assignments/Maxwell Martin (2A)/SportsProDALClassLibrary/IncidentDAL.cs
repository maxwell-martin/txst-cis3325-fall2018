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
            SqlConnection connection = new SqlConnection();
            SqlCommand selectAllIncidents = new SqlCommand();

            //Gets connection string.
            connection = TechSupportDB.GetTechSupportConnection();

            //Sets connection to command.
            selectAllIncidents.Connection = connection;

            //Sets query text.
            selectAllIncidents.CommandText =
                "SELECT IncidentID, CustomerID, ProductCode, TechID, " +
                    "DateOpened, DateClosed, Title, Description " +
                "FROM dbo.Incidents;";

            //Sets command type.
            selectAllIncidents.CommandType = CommandType.Text;
            
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
    }
}
