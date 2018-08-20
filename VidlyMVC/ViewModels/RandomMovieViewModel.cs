using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyMVC.Models;

namespace VidlyMVC.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie movieName { get; set; }

        public Customer customerInfo { get; set; }
        public List<Customer> lstCustomers { get; set; }
    }
}