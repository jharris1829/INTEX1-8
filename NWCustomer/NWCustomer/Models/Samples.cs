using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NWCustomer.Models
{
    [Table("Samples")]
    public class Samples
    {
        [Key]
        public int sampleID { get; set; }

        public int LTNum { get; set; }

        public int assayID { get; set; }
    }
}