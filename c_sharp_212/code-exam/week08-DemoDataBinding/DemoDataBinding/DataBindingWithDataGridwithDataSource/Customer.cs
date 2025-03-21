﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingWithDataGridwithDataSource
{
   public class Customer
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; }
        public int StatusId { get; set; }
        public string? Status { get; set; }
    
}
}
