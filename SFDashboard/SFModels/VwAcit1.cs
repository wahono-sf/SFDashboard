using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAcit1
    {
        [Column("Item Code")]
        [StringLength(30)]
        public string ItemCode { get; set; } = null!;
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Charge Type")]
        [StringLength(5)]
        public string? ChargeType { get; set; }
        [Column("Charge Unit")]
        [StringLength(1)]
        public string? ChargeUnit { get; set; }
        [Column("Consol Item Code")]
        [StringLength(30)]
        public string? ConsolItemCode { get; set; }
        [Column("Cost Acc Code")]
        [StringLength(15)]
        public string? CostAccCode { get; set; }
        [Column("Cost Acc Description")]
        [StringLength(50)]
        public string? CostAccDescription { get; set; }
        [Column("Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? CostAmt { get; set; }
        [Column("Cost Analysis Code")]
        [StringLength(10)]
        public string? CostAnalysisCode { get; set; }
        [Column("Cost Center Code")]
        [StringLength(10)]
        public string? CostCenterCode { get; set; }
        [Column("Cost Percent", TypeName = "decimal(13, 2)")]
        public decimal? CostPercent { get; set; }
        [Column("Cost Vat Code")]
        [StringLength(3)]
        public string? CostVatCode { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Department Code")]
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
        [Column("Item Description")]
        [StringLength(50)]
        public string? ItemDescription { get; set; }
        [Column("Item Short Code")]
        [StringLength(10)]
        public string? ItemShortCode { get; set; }
        [Column("Job Type")]
        [StringLength(10)]
        public string? JobType { get; set; }
        [Column("Local Name")]
        [StringLength(255)]
        public string? LocalName { get; set; }
        [Column("Lock Vat Flag")]
        [StringLength(1)]
        public string? LockVatFlag { get; set; }
        [Column("Provision Acc Code")]
        [StringLength(15)]
        public string? ProvisionAccCode { get; set; }
        [Column("Recoverable Flag")]
        [StringLength(1)]
        public string? RecoverableFlag { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Sales Acc Code")]
        [StringLength(15)]
        public string? SalesAccCode { get; set; }
        [Column("Sales Acc Description")]
        [StringLength(50)]
        public string? SalesAccDescription { get; set; }
        [Column("Sales Analysis Code")]
        [StringLength(10)]
        public string? SalesAnalysisCode { get; set; }
        [Column("Sales Cost Flag")]
        [StringLength(1)]
        public string? SalesCostFlag { get; set; }
        [Column("Sales Provision Acc Code")]
        [StringLength(15)]
        public string? SalesProvisionAccCode { get; set; }
        [Column("Site Code")]
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [Column("Split By Method")]
        [StringLength(1)]
        public string? SplitByMethod { get; set; }
        [Column("Uom Code")]
        [StringLength(3)]
        public string? UomCode { get; set; }
        [Column("Vat Code")]
        [StringLength(3)]
        public string? VatCode { get; set; }
        [Column("WHold Tax Code")]
        [StringLength(3)]
        public string? WholdTaxCode { get; set; }
        [Column("WHold Tax Description")]
        [StringLength(20)]
        public string? WholdTaxDescription { get; set; }
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
