using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwWmbt2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amt { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Audit By")]
        [StringLength(50)]
        public string? AuditBy { get; set; }
        [Column("Audit Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? AuditDateTime { get; set; }
        [Column("Batch No")]
        [StringLength(20)]
        public string? BatchNo { get; set; }
        [Column("Billing Line Item No")]
        public short? BillingLineItemNo { get; set; }
        [Column("Billing Period")]
        [StringLength(8)]
        public string? BillingPeriod { get; set; }
        [Column("Billing Type")]
        [StringLength(25)]
        public string? BillingType { get; set; }
        [Column("Charge Unit")]
        [StringLength(3)]
        public string? ChargeUnit { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Ref No")]
        [StringLength(4000)]
        public string? CustomerRefNo { get; set; }
        [Column("Cycle Unit")]
        [StringLength(5)]
        public string? CycleUnit { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column("Inv Trx No")]
        public int? InvTrxNo { get; set; }
        [Column("Issue Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? IssueDate { get; set; }
        [Column("Issue Movement Trx No")]
        public int? IssueMovementTrxNo { get; set; }
        [Column("Issue Note No")]
        [StringLength(20)]
        public string? IssueNoteNo { get; set; }
        [Column("Last Bill Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastBillDate { get; set; }
        [Column("Loose Qty")]
        public int? LooseQty { get; set; }
        [Column("No Of Cycle")]
        public int? NoOfCycle { get; set; }
        [Column("No Of Day")]
        public int? NoOfDay { get; set; }
        [Column("Packing Qty")]
        public int? PackingQty { get; set; }
        [Column("Product Code")]
        [StringLength(50)]
        public string? ProductCode { get; set; }
        [Column("Product Trx No")]
        public int? ProductTrxNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Qty { get; set; }
        [Column("Receipt Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ReceiptDate { get; set; }
        [Column("Receipt Movement Trx No")]
        public int? ReceiptMovementTrxNo { get; set; }
        [Column("Receipt Note No")]
        [StringLength(20)]
        public string? ReceiptNoteNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Sales Item Code")]
        [StringLength(30)]
        public string? SalesItemCode { get; set; }
        [Column("Sales Line Item No")]
        public short? SalesLineItemNo { get; set; }
        [Column("Table No")]
        [StringLength(10)]
        public string? TableNo { get; set; }
        [Column("Table Trx No")]
        public int? TableTrxNo { get; set; }
        [Column("Trx Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? TrxDate { get; set; }
        [Column("Unit Rate", TypeName = "decimal(13, 4)")]
        public decimal? UnitRate { get; set; }
        [StringLength(3)]
        public string? Uom { get; set; }
        [Column("User Define 1")]
        [StringLength(50)]
        public string? UserDefine1 { get; set; }
        [Column("User Define 2")]
        [StringLength(50)]
        public string? UserDefine2 { get; set; }
        [Column("User Define 3")]
        [StringLength(50)]
        public string? UserDefine3 { get; set; }
        [Column("User Define 4")]
        [StringLength(50)]
        public string? UserDefine4 { get; set; }
        [Column("User Define 5")]
        [StringLength(50)]
        public string? UserDefine5 { get; set; }
        [Column("User Define 6")]
        [StringLength(50)]
        public string? UserDefine6 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [Column("Warehouse Code")]
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }
        [Column("Whole Qty")]
        public int? WholeQty { get; set; }
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
