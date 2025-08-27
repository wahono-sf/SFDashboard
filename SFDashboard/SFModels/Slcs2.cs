using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("slcs2")]
    [Index("RefNo", Name = "INDEX_slcs2_RefNo")]
    public partial class Slcs2
    {
        [Key]
        [Column("KeyID")]
        public int KeyId { get; set; }
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amt { get; set; }
        [StringLength(50)]
        public string AuditBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime AuditDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BankSlipDate { get; set; }
        [StringLength(10)]
        public string? BankSlipNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ChequeDate { get; set; }
        [StringLength(20)]
        public string? ChequeNo { get; set; }
        [StringLength(50)]
        public string? CreateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDateTime { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
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
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LocalAmt { get; set; }
        [Column("MAwbOrOBlNo")]
        [StringLength(30)]
        public string? MawbOrOblNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PostDate { get; set; }
        [StringLength(6)]
        public string? PostMth { get; set; }
        [StringLength(20)]
        public string? ReceiptNo { get; set; }
        [StringLength(10)]
        public string? RefNo { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [StringLength(20)]
        public string? SaleOrderNo { get; set; }
        [StringLength(3)]
        public string? StatusCode { get; set; }
        [StringLength(10)]
        public string? TransitNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TrxDate { get; set; }
        [StringLength(1)]
        public string? TrxType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDateTime { get; set; }
        [StringLength(50)]
        public string? UpdateBy { get; set; }
        [StringLength(20)]
        public string? VoucherNo { get; set; }
    }
}
