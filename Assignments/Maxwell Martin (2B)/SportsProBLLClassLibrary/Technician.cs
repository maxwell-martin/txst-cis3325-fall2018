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
        private string name;
        private string email;
        private string phone;

        //Gets or sets technician ID.
        public int TechID
        {
            get { return techID; }
            set { techID = value; }
        }

        //Gets or sets technician name.
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Gets or sets technician email.
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        //Gets or sets technician phone number.
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public Technician()
        {
            //Default Constructor
        }
    }
}
