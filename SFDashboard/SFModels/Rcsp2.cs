using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("rcsp2")]
    public partial class Rcsp2
    {
        [Key]
        [StringLength(5)]
        public string PortCode { get; set; } = null!;
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(3)]
        public string? DestCode { get; set; }
        [StringLength(2)]
        public string? DestCountryCode { get; set; }
        public int? NoOfDay { get; set; }
    }
}
