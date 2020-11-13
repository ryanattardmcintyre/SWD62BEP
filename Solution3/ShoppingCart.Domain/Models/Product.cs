﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


//Code first approach

namespace ShoppingCart.Domain.Models
{
    //once you have updated your product with new columns >>>>>>>> ctrl + shift + b

    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; } // C581B912-DF44-434B-8AD4-5343FC087507

        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }

        [Required]
        public string Description { get; set; }
        [Required]
        public Category Category { get; set; }

        public string ImageUrl { get; set; }


    }
}
