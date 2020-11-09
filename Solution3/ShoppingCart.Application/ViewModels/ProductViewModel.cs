﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Application.ViewModels
{
    public class ProductViewModel
    {
        public Guid Id { get; set; } // C581B912-DF44-434B-8AD4-5343FC087507
            
        public string Name { get; set; }
     
        public double Price { get; set; }

        public string Description { get; set; }
      
        public CategoryViewModel Category { get; set; }

        //stock
        //supplier

    }
}
