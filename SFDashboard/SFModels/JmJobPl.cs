using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmJobPl
    {
        [Column("Job No")]
        [StringLength(20)]
        public string JobNo { get; set; } = null!;
        [Column("Master Job No")]
        [StringLength(20)]
        public string? MasterJobNo { get; set; }
        [Column("Provision Sales", TypeName = "decimal(38, 2)")]
        public decimal? ProvisionSales { get; set; }
        [Column("Provision Cost", TypeName = "decimal(38, 2)")]
        public decimal? ProvisionCost { get; set; }
        [Column("Actual Sales", TypeName = "decimal(38, 2)")]
        public decimal? ActualSales { get; set; }
        [Column("Actual Cost", TypeName = "decimal(38, 2)")]
        public decimal? ActualCost { get; set; }
        [Column("Accrual Sales", TypeName = "decimal(38, 2)")]
        public decimal? AccrualSales { get; set; }
        [Column("Accrual Cost", TypeName = "decimal(38, 2)")]
        public decimal? AccrualCost { get; set; }
        [Column("Distribute Sales", TypeName = "numeric(13, 2)")]
        public decimal? DistributeSales { get; set; }
        [Column("Distribute Cost", TypeName = "numeric(13, 2)")]
        public decimal? DistributeCost { get; set; }
        [Column("Distribute Accrual Sales", TypeName = "numeric(13, 2)")]
        public decimal? DistributeAccrualSales { get; set; }
        [Column("Distribute Accrual Cost", TypeName = "numeric(13, 2)")]
        public decimal? DistributeAccrualCost { get; set; }
        [Column("Distribute Provision Sales", TypeName = "numeric(13, 2)")]
        public decimal? DistributeProvisionSales { get; set; }
        [Column("Distribute Provision Cost", TypeName = "numeric(13, 2)")]
        public decimal? DistributeProvisionCost { get; set; }
        [Column("Internal Sales", TypeName = "decimal(38, 2)")]
        public decimal? InternalSales { get; set; }
        [Column("Internal Cost", TypeName = "decimal(38, 2)")]
        public decimal? InternalCost { get; set; }
        [Column("Invoice Sales", TypeName = "decimal(38, 2)")]
        public decimal? InvoiceSales { get; set; }
        [Column("Cash Sales", TypeName = "decimal(38, 2)")]
        public decimal? CashSales { get; set; }
        [Column("Receipt Sales", TypeName = "decimal(38, 2)")]
        public decimal? ReceiptSales { get; set; }
        [Column("Credit Note Sales", TypeName = "decimal(38, 2)")]
        public decimal? CreditNoteSales { get; set; }
        [Column("Vendor Provision Cost", TypeName = "decimal(38, 2)")]
        public decimal? VendorProvisionCost { get; set; }
        [Column("Invoice Cost", TypeName = "decimal(38, 2)")]
        public decimal? InvoiceCost { get; set; }
        [Column("Credit Note Cost", TypeName = "decimal(38, 2)")]
        public decimal? CreditNoteCost { get; set; }
        [Column("Cash Cost", TypeName = "decimal(38, 2)")]
        public decimal? CashCost { get; set; }
    }
}
