﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICOnboardingP1.Models
{
    public class ProductSold
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int CustomerId { get; set; }

        public int StoreId { get; set; }

        public DateTime DateSold { get; set; }

        public Customer Customer { get; set; }

        public Product Product { get; set; }

        public Store Store { get; set; }
    }
}