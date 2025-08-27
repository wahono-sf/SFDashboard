using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmpt1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amt { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Branch Code")]
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [Column("Contract Code")]
        [StringLength(20)]
        public string? ContractCode { get; set; }
        [Column("Cost Acc Code")]
        [StringLength(15)]
        public string? CostAccCode { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column("Department Code")]
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
        [Column("Item Code")]
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [Column("Job Costing Trx No")]
        public int? JobCostingTrxNo { get; set; }
        [Column("Job No")]
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column("Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? LocalAmt { get; set; }
        [Column("Post Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PostDate { get; set; }
        [Column("Post Flag")]
        [StringLength(1)]
        public string? PostFlag { get; set; }
        [Column("Post Mth")]
        [StringLength(6)]
        public string? PostMth { get; set; }
        [Column("Provision Acc Code")]
        [StringLength(15)]
        public string? ProvisionAccCode { get; set; }
        [Column("Ref No")]
        [StringLength(10)]
        public string? RefNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Sales Acc Code")]
        [StringLength(15)]
        public string? SalesAccCode { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
        [Column("Created By")]
        [StringLength(50)]
        public string CreatedBy { get; set; } = null!;
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string UpdatedBy { get; set; } = null!;
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
