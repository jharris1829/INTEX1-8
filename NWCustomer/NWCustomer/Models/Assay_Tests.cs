using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NWCustomer.Models
{
    [Table("Assay_Tests")]
    public class Assay_Tests
    {
        [Key]
        public int testID { get; set; }
        [Key]
        public int assayID { get; set; }
        public string RequiredOptional { get; set; }
    }
}