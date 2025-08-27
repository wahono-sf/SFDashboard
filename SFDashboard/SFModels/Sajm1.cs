using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sajm1")]
    public partial class Sajm1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(1)]
        public string? PromptUserFlag { get; set; }
        [StringLength(100)]
        public string? SourceJobType { get; set; }
        [StringLength(100)]
        public string? TargetJobType { get; set; }
    }
}
