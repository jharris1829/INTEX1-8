using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NWCustomer.Models
{
    [Table("WorkOrders")]
    public class WorkOrders
    {
        [Key]
        public int workOrderID { get; set; }
    }
}