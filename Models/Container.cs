using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BW5.Models
{
    public class Container
    {
        [Key]
        public int id { get; set; }
        public string CodiceArmadietto { get; set; }
    }
}