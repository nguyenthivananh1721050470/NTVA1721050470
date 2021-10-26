﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NTVA1721050470.Models
{
    public class Student:Person
    {
        [StringLength(50)]
        [Display(Name = "Trường đại học")]

        public string University { get; set; }

        [StringLength(50)]
        [Display(Name = "Địa chỉ")]

        public string Address { get; set; }
    }
}