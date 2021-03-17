using System;
using System.Collections.Generic;
using System.Text;

namespace Contact.API.Models.ContactModels
{
    public class Contact
    {
        public Guid Id { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String FullName => $"{FirstName} {LastName}";
    }
}
