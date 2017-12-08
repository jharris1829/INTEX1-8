using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NWCustomer.Models
{
    [Table("Invoices")]
    public class Invoices
    {
        [Key]
        public int invoiceNo { get; set; }
        public int workOrderID { get; set; }
        public int accID { get; set; }
    }
}