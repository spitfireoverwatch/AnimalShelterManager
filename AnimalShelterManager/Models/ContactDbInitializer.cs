using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AnimalShelterManager.Models
{
    public class ContactDbInitializer : DropCreateDatabaseAlways<ContactContext>
    {
        protected override void Seed(ContactContext db)
        {
            db.Contacts.Add(new Contact { FullName = "Дмитрий" });
            db.Contacts.Add(new Contact { FullName = "Константин" });
            db.Contacts.Add(new Contact { FullName = "Владимир" });

            base.Seed(db);
        }
    }
}