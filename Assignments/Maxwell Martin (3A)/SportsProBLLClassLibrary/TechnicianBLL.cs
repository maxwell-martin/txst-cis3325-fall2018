using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SportsProDALClassLibrary;

namespace SportsProBLLClassLibrary
{
    public class TechnicianBLL
    {
        private TechnicianDAL myTechnicianDAL = new TechnicianDAL();

        public DataTable GetTechnicianNames()
        {
            DataTable dtTechnicianNames = new DataTable();

            try
            {
                //Gets all technician names from DAL.
                dtTechnicianNames  = myTechnicianDAL.RetrieveTechnicianNames();
            }
            catch //Throws exception to calling method.
            {
                throw;
            }

            return dtTechnicianNames;
        }

        public Technician GetTechnicianDetails(int techID)
        {
            Technician myTechnician = new Technician();
            DataTable dtTechnicianDetails = new DataTable();

            try
            {
                //Gets technician details from DAL.
                dtTechnicianDetails = myTechnicianDAL.RetrieveTechnicianDetails(techID);
            }
            catch //Throws exception to calling method.
            {
                throw;
            }

            /*
             * Loops through DataTable.
             * Sets values to corresponding Technician properties.
            */
            foreach (DataRow dr in dtTechnicianDetails.Rows)
            {
                myTechnician.TechEmail = dr["Email"].ToString();
                myTechnician.TechPhone = dr["Phone"].ToString();
            }

            return myTechnician;
        }
    }
}
