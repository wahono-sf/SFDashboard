using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmdt1
    {
        [Column("Job No")]
        [StringLength(20)]
        public string JobNo { get; set; } = null!;
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Gross Profit", TypeName = "decimal(13, 2)")]
        public decimal? GrossProfit { get; set; }
        [Column("HAwb Or HBl No")]
        [StringLength(20)]
        public string? HawbOrHblNo { get; set; }
        [Column("MAwb Or OBl No")]
        [StringLength(20)]
        public string? MawbOrOblNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Sales Or Cost Item Code")]
        [StringLength(30)]
        public string? SalesOrCostItemCode { get; set; }
        [Column("Sell Total Amt", TypeName = "decimal(13, 2)")]
        public decimal? SellTotalAmt { get; set; }
        [Column("Total Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalCostAmt { get; set; }
        [Column("Total Provision Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalProvisionCostAmt { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string? CreatedBy { get; set; }
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string? UpdatedBy { get; set; }
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
        [StringLength(3)]
        public string? Status { get; set; }
    }
}
