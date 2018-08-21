using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Services.Description;
using VidlyMVC.ViewModels;
using VidlyMVC.Models;

namespace VidlyMVC.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        private List<Customer> lstCustomers;
        private CustomerContext _CustomerContext = new CustomerContext();
        public CustomersController()
        {
            lstCustomers = new List<Customer>
            {
                new Customer {Id = 1, Name = "John Dow", Address = "Harrison Garden"},
                new Customer {Id = 2, Name = "Priyansh Shah", Address = "Cole St"}
            };
        }

        [HttpPost]
        public JsonResult CreateCustomer(Customer cust)
        {
            _CustomerContext.dbSetCustomers.Add(cust);
            _CustomerContext.SaveChangesAsync();
            return Json(new {Message = "Success", JsonRequestBehavior.AllowGet});
        }

        public JsonResult GetCustomers(string Id)
        {
            List<Customer> lstGetCustomers = new List<Customer>();
            lstGetCustomers = _CustomerContext.dbSetCustomers.ToList();
            return Json(lstGetCustomers, JsonRequestBehavior.AllowGet);
        }

        //[Route("customers")]
        public ActionResult Index()
        {
            RandomMovieViewModel viewCustomers = null;
            try
            {
                viewCustomers = new RandomMovieViewModel
                {
                    //lstCustomers = this.lstCustomers,
                    lstCustomers = _CustomerContext.dbSetCustomers.ToList(),
                    //customerInfo = new Customer { Name = lstCustomers[0].Name, Address = lstCustomers[0].Address}
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return RedirectToAction("Index", "Home");
            }
            return View(viewCustomers);
        }

        //[Route("customers/details/{id}")]
        public ActionResult Details(int? id)
        {
            var lstCustomerById = _CustomerContext.dbSetCustomers.SingleOrDefault(cust => cust.Id == id); //Return Single Customer
            if (lstCustomerById is null)
                return HttpNotFound();
            return View(lstCustomerById);

        }

        public ActionResult Edit(int id)
        {
            var editCustomer = _CustomerContext.dbSetCustomers.SingleOrDefault(cust => cust.Id == id);
            if (editCustomer is null)
                return HttpNotFound();
            var viewEditCustomer = new RandomMovieViewModel
            {
                customerInfo = editCustomer
            };
            return View("Index", viewEditCustomer);
        }
    }
}