using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("plhp1")]
    [Index("HirePurchaseCode", Name = "IX_plhp1", IsUnique = true)]
    public partial class Plhp1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(15)]
        public string? AccCode { get; set; }
        [StringLength(10)]
        public string? BankCode { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [StringLength(20)]
        public string? HirePurchaseAgreementNo { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? HirePurchaseAmt { get; set; }
        [StringLength(10)]
        public string HirePurchaseCode { get; set; } = null!;
        [StringLength(10)]
        public string? HirePurchaseCompanyCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HirePurchaseDate { get; set; }
        [StringLength(50)]
        public string? HirePurchaseName { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? InitialOutstandingBalance { get; set; }
        [StringLength(15)]
        public string? InterestAccCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? InterestRate { get; set; }
        [StringLength(15)]
        public string? InterestSuspenseAccCode { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? LastInterestAmt { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? MonthlyInterestAmt { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? MonthlyPaymentAmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NextDueDate { get; set; }
        public int? NoOfInstallment { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        [StringLength(5)]
        public string? PayMode { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? PurchaseAmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PurchaseDate { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        public int? UnpaidInstallment { get; set; }
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [StringLength(2)]
        public string? VoucherType { get; set; }
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
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
