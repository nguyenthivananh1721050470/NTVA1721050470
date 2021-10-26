using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NTVA1721050470.Models
{
    public class Person
    {
        [StringLength(20)]
        [Display(Name = "ID")]
        [Key]
        public string perSonID { get; set; }

        [StringLength(50)]
        [Display(Name = "Họ Và Tên")]

        public string perSonName { get; set; }
    }
}