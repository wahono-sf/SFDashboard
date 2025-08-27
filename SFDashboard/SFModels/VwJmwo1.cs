using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmwo1
    {
        [Column("Job No")]
        [StringLength(50)]
        public string JobNo { get; set; } = null!;
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Contr Client Code")]
        [StringLength(8)]
        public string? ContrClientCode { get; set; }
        [Column("Custom Val", TypeName = "decimal(13, 2)")]
        public decimal? CustomVal { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Qty { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Supplier Val", TypeName = "decimal(13, 2)")]
        public decimal? SupplierVal { get; set; }
        [Column("Vote No")]
        [StringLength(10)]
        public string? VoteNo { get; set; }
        [Column("Work Order No")]
        [StringLength(20)]
        public string? WorkOrderNo { get; set; }
    }
}
