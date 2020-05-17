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
        private int incidentID;
        private int customerID;
        private string productCode;
        private int? techID;
        private DateTime dateOpened;
        private DateTime? dateClosed;
        private string title;
        private string description;

        public Incident()
        {
            //Default Constructor;
        }

        /// <summary>
        /// Gets or sets the incident ID.
        /// </summary>
        public int IncidentID
        {
            get { return incidentID; }
            set { incidentID = value; }
        }

        /// <summary>
        /// Gets or sets customer ID of incident.
        /// </summary>
        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        /// <summary>
        /// Gets or sets the product code related to the incident.
        /// </summary>
        public string ProductCode
        {
            get { return productCode; }
            set { productCode = value; }
        }

        /// <summary>
        /// Gets or sets the technician ID that handled the incident.
        /// The value can be null.
        /// </summary>
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

        /// <summary>
        /// Gets or sets the date the incident was opened.
        /// </summary>
        public DateTime DateOpened
        {
            get { return dateOpened; }
            set { dateOpened = value; }
        }

        /// <summary>
        /// Gets or sets the date the incident was closed.
        /// The value can be null.
        /// </summary>
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

        /// <summary>
        /// Gets or sets title of the incident.
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        /// <summary>
        /// Gets or sets the description of the incident.
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
