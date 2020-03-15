using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AnimalShelterManager.Models
{
    public class Contact
    {
        public Guid Id { get; set; }
        [Display(Name = "Name")]
        public string FullName { get; set; }
        public DateTime CreatedOn { get; set; }

        public Contact()
        {
            Id = Guid.NewGuid();
            CreatedOn = DateTime.UtcNow;
        }
    }
}