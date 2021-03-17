using Contact.API.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contact.API.Service
{
    public class ContactService : IContactService
    {
        public Models.ContactModels.Contact GetContact()
        {
            return new Models.ContactModels.Contact()
            {
                Id = Guid.NewGuid(),
                FirstName = "Salih",
                LastName = "Cantekin"
            };
        }

        public Models.ContactModels.Contact GetContactById(Guid Id)
        {
            return new Models.ContactModels.Contact()
            {
                Id = Id,
                FirstName = "Salih",
                LastName = "Cantekin"
            };
        }
    }
}
