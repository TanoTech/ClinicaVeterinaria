
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BW5.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipologia { get; set; }
        public int Quantità { get; set; }

        [ForeignKey("CompanyId")]
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
