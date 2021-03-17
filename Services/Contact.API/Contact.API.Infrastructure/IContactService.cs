using System;
using System.Collections.Generic;
using System.Text;

namespace Contact.API.Infrastructure
{
    public interface IContactService
    {
        public Models.ContactModels.Contact GetContact();

        public Models.ContactModels.Contact GetContactById(Guid Id);
    }
}
