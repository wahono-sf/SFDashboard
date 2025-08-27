using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("glyl1")]
    [Index("RefNo", Name = "INDEX_glyl1_RefNo")]
    [Index("AccCode", "PostMth", "RefNo", Name = "IX_glyl1")]
    [Index("RefNo", Name = "IX_glyl1_1")]
    [Index("AccCode", Name = "IX_glyl1_2")]
    [Index("PostMth", Name = "IX_glyl1_3")]
    [Index("TrxNo", "AccCode", "ReconcilFlag", Name = "IX_glyl1_4")]
    [Index("ReconcilFlag", Name = "IX_glyl1_5")]
    [Index("BankSlipNo", Name = "IX_glyl1_6")]
    [Index("JobNo", Name = "IX_glyl1_7")]
    [Index("ItemCode", Name = "IX_glyl1_8")]
    public partial class Glyl1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Amt { get; set; }
        [StringLength(1)]
        public string? AutoClearFlag { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BankSlipDate { get; set; }
        [StringLength(10)]
        public string? BankSlipNo { get; set; }
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ChequeDate { get; set; }
        [StringLength(20)]
        public string? ChequeNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ClearDate { get; set; }
        [StringLength(20)]
        public string? ContractCode { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(10)]
        public string? CustomerOrVendorCode { get; set; }
        [StringLength(80)]
        public string? CustomerOrVendorName { get; set; }
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
        [StringLength(255)]
        public string? Description { get; set; }
        public short? FinancialYear { get; set; }
        [Column("HAwbOrHBlNo")]
        [StringLength(30)]
        public string? HawbOrHblNo { get; set; }
        [StringLength(20)]
        public string? InvoiceChequeNo { get; set; }
        [StringLength(30)]
        public string? ItemCode { get; set; }
        public int? JobItemTrxNo { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [StringLength(10)]
        public string? JobType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? JournalDate { get; set; }
        [StringLength(20)]
        public string? JournalNo { get; set; }
        [StringLength(3)]
        public string? JournalType { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? LocalAmt { get; set; }
        public int? LineItemNo { get; set; }
        [Column("MAwbOrOBlNo")]
        [StringLength(30)]
        public string? MawbOrOblNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PostDate { get; set; }
        [StringLength(6)]
        public string? PostMth { get; set; }
        [StringLength(20)]
        public string? ReceiptOrVoucherNo { get; set; }
        [StringLength(1)]
        public string? ReconcilFlag { get; set; }
        [StringLength(20)]
        public string? Reference { get; set; }
        [StringLength(10)]
        public string? RefNo { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TrxDate { get; set; }
        [StringLength(1)]
        public string? TrxType { get; set; }
        [StringLength(10)]
        public string? UserGroup { get; set; }
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
