using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("plpm1")]
    [Index("BankCode", Name = "INDEX_Plpm1_BankCode")]
    [Index("ChequeNo", Name = "INDEX_Plpm1_ChequeNo")]
    [Index("PaymentDate", Name = "INDEX_Plpm1_PaymentDate")]
    [Index("PostDate", Name = "INDEX_Plpm1_PostDate")]
    [Index("PostFlag", Name = "INDEX_Plpm1_PostFlag")]
    [Index("StatusCode", Name = "INDEX_Plpm1_StatusCode")]
    [Index("TrxType", Name = "INDEX_Plpm1_TrxType")]
    [Index("UpdateDateTime", Name = "INDEX_Plpm1_UpdateDateTime")]
    [Index("VendorName", Name = "INDEX_Plpm1_VendorName")]
    [Index("VoucherNo", Name = "INDEX_Plpm1_VoucherNo")]
    [Index("WorkStation", Name = "INDEX_Plpm1_WorkStation")]
    public partial class Plpm1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(50)]
        public string? Address1 { get; set; }
        [StringLength(50)]
        public string? Address2 { get; set; }
        [StringLength(50)]
        public string? Address3 { get; set; }
        [StringLength(50)]
        public string? Address4 { get; set; }
        [StringLength(50)]
        public string? ApproveBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ApproveDate { get; set; }
        [StringLength(1)]
        public string? AutoHandFlag { get; set; }
        [StringLength(15)]
        public string? BankAccCode { get; set; }
        [StringLength(10)]
        public string? BankCode { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? ChargeAmt1 { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? ChargeAmt2 { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? ChargeAmt3 { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? ChargeAmt4 { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? ChargeAmt5 { get; set; }
        [StringLength(50)]
        public string? CheckBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CheckDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ChequeDate { get; set; }
        [StringLength(20)]
        public string? ChequeNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ClearDate { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(50)]
        public string? Description1 { get; set; }
        [StringLength(50)]
        public string? Description2 { get; set; }
        [StringLength(50)]
        public string? Description3 { get; set; }
        [StringLength(50)]
        public string? Description4 { get; set; }
        [StringLength(50)]
        public string? Description5 { get; set; }
        [StringLength(20)]
        public string? DocNo { get; set; }
        [StringLength(50)]
        public string? EventTemplateName { get; set; }
        [StringLength(15)]
        public string? GlAccCode1 { get; set; }
        [StringLength(15)]
        public string? GlAccCode2 { get; set; }
        [StringLength(15)]
        public string? GlAccCode3 { get; set; }
        [StringLength(15)]
        public string? GlAccCode4 { get; set; }
        [StringLength(15)]
        public string? GlAccCode5 { get; set; }
        [StringLength(50)]
        public string? LockBy { get; set; }
        [StringLength(1)]
        public string? LockFlag { get; set; }
        [StringLength(3)]
        public string? PayCode { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? PaymentAmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PaymentDate { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? PaymentLocalAmt { get; set; }
        [StringLength(5)]
        public string? PayMode { get; set; }
        [StringLength(50)]
        public string? PostBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PostDate { get; set; }
        [StringLength(1)]
        public string? PostFlag { get; set; }
        [StringLength(6)]
        public string? PostMth { get; set; }
        public byte? PrintCount { get; set; }
        [StringLength(1)]
        public string? ReconcilFlag { get; set; }
        [StringLength(10)]
        public string? RefNo { get; set; }
        [StringLength(50)]
        public string? Reference { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(50)]
        public string? RequestBy { get; set; }
        [StringLength(250)]
        public string? RequestTo { get; set; }
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [StringLength(1)]
        public string? TrxType { get; set; }
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [StringLength(80)]
        public string? VendorName { get; set; }
        [StringLength(20)]
        public string? VoucherNo { get; set; }
        [StringLength(2)]
        public string? VoucherType { get; set; }
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
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
