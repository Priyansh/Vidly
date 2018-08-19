﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyMVC.ViewModels;
using VidlyMVC.Models;

namespace VidlyMVC.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        private List<Customer> lstCustomers;

        public CustomersController()
        {
            lstCustomers = new List<Customer>
            {
                new Customer {Id = 1, Name = "John Dow"},
                new Customer {Id = 2, Name = "Priyansh Shah"}
            };
        }

        [Route("customers")]
        public ActionResult Index()
        {
            
            var viewCustomers = new RandomMovieViewModel
            {
                lstCustomers = this.lstCustomers
            };
            return View(viewCustomers);
        }

        [Route("customers/details/{id}")]
        public ActionResult Details(int id)
        {
            if (id > lstCustomers.Count)
                return Content("No matching record found");
            return Content(lstCustomers[id - 1].Name);
        }
    }
}