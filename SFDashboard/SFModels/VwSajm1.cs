using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSajm1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Prompt User Flag")]
        [StringLength(1)]
        public string? PromptUserFlag { get; set; }
        [Column("Source Job Type")]
        [StringLength(100)]
        public string? SourceJobType { get; set; }
        [Column("Target Job Type")]
        [StringLength(100)]
        public string? TargetJobType { get; set; }
    }
}
