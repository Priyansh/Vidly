﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VidlyMVC.Models
{
    public class Customer : DbContext
    {
        public int Id { get; set; }
        public string Name{ get; set; }
    }
}