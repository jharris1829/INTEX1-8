using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NWCustomer.Models
{
    public class PotentialsViewModel
    {
        [Required]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Required]
        [Display(Name = "Name of Contact")]
        public string ContactName { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone")]
        public string ContactPhone { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string ContactEmail { get; set; }

        [StringLength(300)]
        [Display(Name = "Comments")]
        public string Notes { get; set; }
    }
}