using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
  
    class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }

    class LegalEntity : Contact
    {
        public string LegalName { get; set; }
        public string RegistrationNumber { get; set; }
    }

    class GovEntity : Contact
    {
        public string GovernmentID { get; set; }
        public string Department { get; set; }
    }

    class Person : Contact
    {
        public string SocialSecurityNumber { get; set; }
        public string Address { get; set; }
    }

    class Family : Contact
    {
        
    }

    class Company : LegalEntity
    {
        public string Industry { get; set; }
        public int NumberOfEmployees { get; set; }
    }

}
