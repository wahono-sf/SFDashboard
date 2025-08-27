using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("rccy3")]
    public partial class Rccy3
    {
        [Key]
        [StringLength(2)]
        public string CountryCode { get; set; } = null!;
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(10)]
        public string? Symbol { get; set; }
        [StringLength(4000)]
        public string? HandlingInstruction { get; set; }
    }
}
