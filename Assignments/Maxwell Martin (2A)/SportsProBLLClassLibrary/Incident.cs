using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsProBLLClassLibrary
{
    public class Incident
    {
        //Backing fields.
        private int customerID;
        private DateTime? dateClosed;
        private DateTime dateOpened;
        private string description;
        private int incidentID;
        private string productCode;
        private int? techID;
        private string title;

        //Gets or sets customer ID of incident.
        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        //Gets or sets the date the incident was closed.
        public DateTime? DateClosed
        {
            //Checks if dateClosed has a value.
            //Returns value if it does and null if it doesn't.
            get
            {
                if (dateClosed.HasValue)
                    return dateClosed;
                else
                    return null;
            }
            set { dateClosed = value; }
        }

        //Gets or sets the date the incident was opened.
        public DateTime DateOpened
        {
            get { return dateOpened; }
            set { dateOpened = value; }
        }

        //Gets or sets the description of the incident.
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        //Gets or sets the incident ID.
        public int IncidentID
        {
            get { return incidentID; }
            set { incidentID = value; }
        }

        //Gets or sets the product code related to the incident.
        public string ProductCode
        {
            get { return productCode; }
            set { productCode = value; }
        }

        //Gets or sets the technician ID that handled the incident.
        public int? TechID
        {
            //Checks if techID has a value.
            //Returns value if it does and null if it doesn't.
            get
            {
                if (techID.HasValue)
                    return techID;
                else
                    return null;
            }
            set { techID = value; }
        }

        //Gets or sets title of the incident.
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public Incident()
        {
            //Default Constructor;
        }
    }
}
