using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwImpm1Batch
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Batch Line Item No")]
        public int? BatchLineItemNo { get; set; }
        [Column("Batch No")]
        [StringLength(12)]
        public string? BatchNo { get; set; }
        [Column("Billing Start Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? BillingStartDate { get; set; }
        [Column("CIF Value", TypeName = "decimal(13, 2)")]
        public decimal? CifValue { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column("Balance Qty")]
        public int BalanceQty { get; set; }
        [Column("Goods Receive OrIssue No")]
        [StringLength(20)]
        public string? GoodsReceiveOrIssueNo { get; set; }
        [Column("Last Bill Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastBillDate { get; set; }
        [Column("Mark No")]
        [StringLength(2000)]
        public string? MarkNo { get; set; }
        [Column("Movement Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MovementDate { get; set; }
        [Column("Rate Class Code")]
        [StringLength(1)]
        public string? RateClassCode { get; set; }
        [Column("Receipt Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ReceiptDate { get; set; }
        [Column("Ref No")]
        [StringLength(50)]
        public string? RefNo { get; set; }
        [Column("Trx Type")]
        [StringLength(1)]
        public string? TrxType { get; set; }
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
