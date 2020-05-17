using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SportsProDALClassLibrary
{
    public static class TechSupportDB
    {
        public static SqlConnection GetTechSupportConnection()
        {
            SqlConnection connection = new SqlConnection();

            //Sets connection string to specified SQL Server database location.
            connection.ConnectionString = "Data Source = cissql.matrix.txstate.edu\\cis3325fall18; " +
                "Initial Catalog = TechSupport; Integrated Security = True;";

            return connection;
        }
    }
}
