using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmpt1")]
    [Index("JobNo", "ItemCode", Name = "IX_jmpt1")]
    [Index("JobNo", Name = "IX_jmpt1_1")]
    [Index("ItemCode", Name = "IX_jmpt1_2")]
    [Index("JobCostingTrxNo", Name = "IX_jmpt1_3")]
    public partial class Jmpt1
    {
        [Key]
        public int TrxNo { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? Amt { get; set; }
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [StringLength(20)]
        public string? ContractCode { get; set; }
        [StringLength(15)]
        public string? CostAccCode { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
        [StringLength(30)]
        public string? ItemCode { get; set; }
        public int? JobCostingTrxNo { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? LocalAmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PostDate { get; set; }
        [StringLength(1)]
        public string? PostFlag { get; set; }
        [StringLength(6)]
        public string? PostMth { get; set; }
        [StringLength(15)]
        public string? ProvisionAccCode { get; set; }
        [StringLength(10)]
        public string? RefNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(15)]
        public string? SalesAccCode { get; set; }
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
    }
}
