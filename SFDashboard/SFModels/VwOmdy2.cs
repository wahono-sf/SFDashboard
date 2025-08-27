using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwOmdy2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Clear Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ClearDate { get; set; }
        [Column("Job No")]
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column(TypeName = "decimal(11, 3)")]
        public decimal? Qty { get; set; }
        [StringLength(100)]
        public string? Remark { get; set; }
        [Column("Survey Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? SurveyDate { get; set; }
        [StringLength(20)]
        public string? Type { get; set; }
    }
}
