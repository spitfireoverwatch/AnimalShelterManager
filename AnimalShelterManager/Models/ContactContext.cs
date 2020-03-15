using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AnimalShelterManager.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext() : base("MainDB")
        { }

        public DbSet<Contact> Contacts { get; set; }
    }
}