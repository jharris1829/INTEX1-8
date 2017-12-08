using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NWCustomer.Models
{
    [Table("Serialized_Tests")]
    public class Serialized_Tests
    {
        [Key]
        public int SerialTestID { get; set; }
        public string testName { get; set; }
        public int testID { get; set; }
    }
}