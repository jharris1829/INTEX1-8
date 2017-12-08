using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NWCustomer.Models
{
    [Table("testTube")]
    public class testTube
    {
        [Key]
        public int testTubeID { get; set; }
        public int serialID { get; set; }
        public int sampleID { get; set; }
    }
}