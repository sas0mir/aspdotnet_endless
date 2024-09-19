using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace aspdonet_endless.Models
{
    public class Expense
    {
        public int Id {get; set;}
        public decimal Value {get; set;}
        [Required]
        public string? Description {get; set;}
    }
}