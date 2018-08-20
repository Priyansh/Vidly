using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace VidlyMVC.Models
{
    public class CustomerContext : DbContext
    {
        public DbSet<Customer> dbSetCustomers { get; set; }
    }
}