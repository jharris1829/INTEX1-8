using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NWCustomer.Models
{
    [Table("CustomerAccount")]
    public class CustomerAccount
    {
        [Key]
        public int accID { get; set; }
        public int custID { get; set; }
    }
}