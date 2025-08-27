using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("glyl2")]
    [Index("RefNo", Name = "INDEX_glyl2_RefNo")]
    [Index("AccCode", "PostMth", "RefNo", Name = "IX_glyl2")]
    [Index("RefNo", Name = "IX_glyl2_1")]
    [Index("AccCode", Name = "IX_glyl2_2")]
    [Index("PostMth", Name = "IX_glyl2_3")]
    [Index("AccCode", "PostMth", "RefNo", Name = "IX_glyl2_4")]
    [Index("RefNo", Name = "IX_glyl2_5")]
    public partial class Glyl2
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Amt { get; set; }
        [StringLength(50)]
        public string AuditBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime AuditDateTime { get; set; }
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
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? JournalDate { get; set; }
        [StringLength(20)]
        public string? JournalNo { get; set; }
        public int? LineItemNo { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? LocalAmt { get; set; }
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
    }
}
