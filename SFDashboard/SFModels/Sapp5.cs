using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sapp5")]
    public partial class Sapp5
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(1)]
        public string? AlertBlockPrintFlag { get; set; }
        [StringLength(1)]
        public string? AlertBlockPrintFlag2 { get; set; }
        [StringLength(300)]
        public string? AlertCondition { get; set; }
        [StringLength(300)]
        public string? AlertCondition2 { get; set; }
        [StringLength(500)]
        public string? AlertMessage { get; set; }
        [StringLength(500)]
        public string? AlertMessage2 { get; set; }
    }
}
