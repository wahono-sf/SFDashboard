using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("Rcbp12")]
    public partial class Rcbp12
    {
        [Key]
        [StringLength(10)]
        public string BusinessPartyCode { get; set; } = null!;
        [Key]
        public int LineItemNo { get; set; }
        [Key]
        [StringLength(4)]
        public string Year { get; set; } = null!;
        [StringLength(10)]
        public string? Mth01NextNo { get; set; }
        [StringLength(10)]
        public string? Mth02NextNo { get; set; }
        [StringLength(10)]
        public string? Mth03NextNo { get; set; }
        [StringLength(10)]
        public string? Mth04NextNo { get; set; }
        [StringLength(10)]
        public string? Mth05NextNo { get; set; }
        [StringLength(10)]
        public string? Mth06NextNo { get; set; }
        [StringLength(10)]
        public string? Mth07NextNo { get; set; }
        [StringLength(10)]
        public string? Mth08NextNo { get; set; }
        [StringLength(10)]
        public string? Mth09NextNo { get; set; }
        [StringLength(10)]
        public string? Mth10NextNo { get; set; }
        [StringLength(10)]
        public string? Mth11NextNo { get; set; }
        [StringLength(10)]
        public string? Mth12NextNo { get; set; }
        [StringLength(10)]
        public string? YearNextNo { get; set; }
    }
}
