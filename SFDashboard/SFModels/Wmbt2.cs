using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("wmbt2")]
    [Index("BatchNo", Name = "INDEX_Wmbt2_BatchNo")]
    [Index("BillingLineItemNo", Name = "INDEX_Wmbt2_BillingLineItemNo")]
    [Index("CustomerCode", Name = "INDEX_Wmbt2_CustomerCode")]
    [Index("InvTrxNo", Name = "INDEX_Wmbt2_InvTrxNo")]
    [Index("IssueNoteNo", Name = "INDEX_Wmbt2_IssueNoteNo")]
    [Index("LastBillDate", Name = "INDEX_Wmbt2_LastBillDate")]
    [Index("ProductCode", Name = "INDEX_Wmbt2_ProductCode")]
    [Index("ProductTrxNo", Name = "INDEX_Wmbt2_ProductTrxNo")]
    [Index("ReceiptDate", Name = "INDEX_Wmbt2_ReceiptDate")]
    [Index("ReceiptMovementTrxNo", Name = "INDEX_Wmbt2_ReceiptMovementTrxNo")]
    [Index("ReceiptNoteNo", Name = "INDEX_Wmbt2_ReceiptNoteNo")]
    [Index("SalesItemCode", Name = "INDEX_Wmbt2_SalesItemCode")]
    [Index("SalesLineItemNo", Name = "INDEX_Wmbt2_SalesLineItemNo")]
    [Index("TableNo", Name = "INDEX_Wmbt2_TableNo")]
    [Index("TableTrxNo", Name = "INDEX_Wmbt2_TableTrxNo")]
    [Index("TrxDate", Name = "INDEX_Wmbt2_TrxDate")]
    [Index("UserDefine1", Name = "INDEX_Wmbt2_UserDefine1")]
    [Index("UserDefine2", Name = "INDEX_Wmbt2_UserDefine2")]
    [Index("UserDefine3", Name = "INDEX_Wmbt2_UserDefine3")]
    [Index("WarehouseCode", Name = "INDEX_Wmbt2_WarehouseCode")]
    public partial class Wmbt2
    {
        [Key]
        public int TrxNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amt { get; set; }
        [StringLength(50)]
        public string? AuditBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AuditDatetime { get; set; }
        [StringLength(20)]
        public string? BatchNo { get; set; }
        public short? BillingLineItemNo { get; set; }
        [StringLength(8)]
        public string? BillingPeriod { get; set; }
        [StringLength(25)]
        public string? BillingType { get; set; }
        [StringLength(3)]
        public string? ChgUnit { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(4000)]
        public string? CustomerRefNo { get; set; }
        [StringLength(5)]
        public string? CycleUnit { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        public int? InvTrxNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? IssueDate { get; set; }
        public int? IssueMovementTrxNo { get; set; }
        [StringLength(20)]
        public string? IssueNoteNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastBillDate { get; set; }
        public int? LooseQty { get; set; }
        public int? NoOfCycle { get; set; }
        public int? NoOfDay { get; set; }
        public int? PackingQty { get; set; }
        [StringLength(50)]
        public string? ProductCode { get; set; }
        public int? ProductTrxNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Qty { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceiptDate { get; set; }
        public int? ReceiptMovementTrxNo { get; set; }
        [StringLength(20)]
        public string? ReceiptNoteNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(30)]
        public string? SalesItemCode { get; set; }
        public short? SalesLineItemNo { get; set; }
        [StringLength(10)]
        public string? TableNo { get; set; }
        public int? TableTrxNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TrxDate { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? UnitRate { get; set; }
        [StringLength(3)]
        public string? Uom { get; set; }
        [StringLength(50)]
        public string? UserDefine1 { get; set; }
        [StringLength(50)]
        public string? UserDefine2 { get; set; }
        [StringLength(50)]
        public string? UserDefine3 { get; set; }
        [StringLength(50)]
        public string? UserDefine4 { get; set; }
        [StringLength(50)]
        public string? UserDefine5 { get; set; }
        [StringLength(50)]
        public string? UserDefine6 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }
        public int? WholeQty { get; set; }
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
