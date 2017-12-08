using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NWCustomer.Models
{
    [Table("Compounds")]
    public class Compounds
    {
        [Key]
        public int LTNum { get; set; }

        public int workOrderID { get; set; }

        public int compoundFinID { get; set; }
    }
}