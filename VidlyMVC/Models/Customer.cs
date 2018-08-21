using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VidlyMVC.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Customer Name")]
        public string Name{ get; set; }

        //[Required]
        [DisplayName("Customer Address")]
        public string Address { get; set; }
    }
}