using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AnimalShelterManager;
using AnimalShelterManager.Models;

namespace AnimalShelterManager.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext db = new ContactContext();

        public ActionResult Index()
        {
            IEnumerable<Contact> contacts = db.Contacts;
            ViewBag.Contacts = contacts;
            return View();
        }
        [HttpGet]
        public ActionResult Add()
        {
            ViewBag.Contact = new Contact();
            return View();
        }
        [HttpPost]
        public ActionResult Add(Contact entityToAdd)
        {
            db.Contacts.Add(entityToAdd);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(Guid id)
        {
            var contact = db.Contacts.Find(id);
            if (contact != null)
            {
                ViewBag.Contact = contact;
                return View();
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Edit(Contact contact)
        {
            if (contact != null)
            {
                var entityToUpdate = db.Contacts.Find(contact.Id);
                if (entityToUpdate != null)
                {
                    db.Entry(entityToUpdate).CurrentValues.SetValues(contact);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(Guid id)
        {
            var contact = db.Contacts.Find(id);
            if (contact != null)
            {
                db.Contacts.Remove(contact);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}