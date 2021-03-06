﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Product id is required")]
        public int ProductId { get; set; }


        [Required(ErrorMessage = "Customer id is required")]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Store id is required")]
        public int StoreId { get; set; }


        [Required(ErrorMessage = "Sale date is required")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateSold { get; set; }

        public Customer customer { get; set; }
        public Product product { get; set; }
        public Store store { get; set; }
    }
}