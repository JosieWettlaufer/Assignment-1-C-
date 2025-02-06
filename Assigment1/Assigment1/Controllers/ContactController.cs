using Assigment1.Models;  // Import the namespace where Contact model and ContactContext are defined
using Microsoft.AspNetCore.Mvc;  // Import ASP.NET Core MVC framework

namespace Assigment1.Controllers  // Define the namespace for the controller
{
    public class ContactController : Controller  // ContactController handles requests related to contacts
    {
        private ContactContext context { get; set; }  // Database context for accessing the Contacts table

        // Constructor that initializes the database context through dependency injection
        public ContactController(ContactContext ctx)
        {
            context = ctx;
        }

        // Displays the Add Contact form
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";  // Set the action name for the view
            ViewBag.Categories = context.Categories.OrderBy(c => c.CategoryName).ToList();
            return View("Edit", new Contact());  // Reuse the Edit view for adding a new contact
        }

        // Displays the Edit Contact form for a specific contact
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";  // Set the action name for the view
            ViewBag.Categories = context.Categories.OrderBy(c => c.CategoryName).ToList();
            var contact = context.Contacts.Find(id);  // Find the contact by ID
            return View(contact);  // Pass the contact to the view
        }

        // Handles form submission for adding or updating a contact
        [HttpPost]
        public IActionResult Edit(Contact contact)
        {
            if (ModelState.IsValid)  // Check if form data is valid
            {
                if (contact.ContactId == 0)  // If no ID, it's a new contact (Add)
                {
                    context.Contacts.Add(contact);
                }
                else  // If ID exists, update the existing contact
                {
                    context.Contacts.Update(contact);
                }
                context.SaveChanges();  // Save changes to the database
                return RedirectToAction("Index", "Home");  // Redirect to the home page
            }
            else
            {
                ViewBag.Action = (contact.ContactId == 0) ? "Add" : "Edit";  // Set ViewBag for the form title
                ViewBag.Categories = context.Categories.OrderBy(c => c.CategoryName).ToList();
                return View(contact);  // Return the form with validation errors
            }
        }

        // Displays the Delete confirmation page
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contact = context.Contacts.Find(id);  // Find the contact by ID
            return View(contact);  // Pass the contact to the view
        }

        // Handles form submission for deleting a contact
        [HttpPost]
        public IActionResult Delete(Contact contact)
        {
            context.Contacts.Remove(contact);  // Remove the contact from the database
            context.SaveChanges();  // Save changes
            return RedirectToAction("Index", "Home");  // Redirect to home page
        }
    }
}
