using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsProBLLClassLibrary
{
    public class Technician
    {
        //Backing fields.
        private int techID;
        private string techName;
        private string techEmail;
        private string techPhone;

        //Gets or sets technician ID.
        public int TechID
        {
            get { return techID; }
            set { techID = value; }
        }

        //Gets or sets technician name.
        public string TechName
        {
            get { return techName; }
            set { techName = value; }
        }

        //Gets or sets technician email.
        public string TechEmail
        {
            get { return techEmail; }
            set { techEmail = value; }
        }

        //Gets or sets technician phone number.
        public string TechPhone
        {
            get { return techPhone; }
            set { techPhone = value; }
        }

        public Technician()
        {
            //Default Constructor
        }
    }
}
