using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class SiTranshipmentRateByJob
    {
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? Amt { get; set; }
        [Column("Local Amt", TypeName = "decimal(38, 9)")]
        public decimal? LocalAmt { get; set; }
        [Column("Transhipment Amt", TypeName = "decimal(38, 2)")]
        public decimal? TranshipmentAmt { get; set; }
        [Column("Transhipment Local Amt", TypeName = "decimal(38, 8)")]
        public decimal? TranshipmentLocalAmt { get; set; }
    }
}
