using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("pltx1")]
    [Index("InvoiceOrChequeNo", Name = "INDEX_Pltx1_InvoiceOrCheuqeNo")]
    [Index("JobNo", Name = "INDEX_Pltx1_JobNo")]
    [Index("PostDate", Name = "INDEX_Pltx1_PostDate")]
    [Index("RefNo", Name = "INDEX_Pltx1_RefNo")]
    [Index("StatusCode", Name = "INDEX_Pltx1_StatusCode")]
    [Index("TrxDate", Name = "INDEX_Pltx1_TrxDate")]
    [Index("TrxType", Name = "INDEX_Pltx1_TrxType")]
    [Index("VendorCode", Name = "INDEX_Pltx1_VendorCode")]
    [Index("VendorCode", "InvoiceOrChequeNo", Name = "INDEX_Pltx1_VendorCode_InvoiceOrCheuqeNo")]
    [Index("VendorName", Name = "INDEX_Pltx1_VendorName")]
    public partial class Pltx1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AgeingDate { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? Amt { get; set; }
        [StringLength(20)]
        public string? ApplyToInvoice { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? Balance { get; set; }
        [StringLength(20)]
        public string? ChequeNo { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        [Column("HawbOrHBlNo")]
        [StringLength(30)]
        public string? HawbOrHblNo { get; set; }
        [StringLength(20)]
        public string? InvoiceOrChequeNo { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? LocalAmt { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? LocalBalanceAmt { get; set; }
        [StringLength(1)]
        public string? MarkInvoiceFlag { get; set; }
        [Column("MawbOrOBlNo")]
        [StringLength(30)]
        public string? MawbOrOblNo { get; set; }
        [StringLength(1)]
        public string? PaymentFlag { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PostDate { get; set; }
        [StringLength(6)]
        public string? PostMth { get; set; }
        [StringLength(10)]
        public string? Prefix { get; set; }
        [StringLength(20)]
        public string? PurchaseOrderNo { get; set; }
        [StringLength(10)]
        public string? RefNo { get; set; }
        [StringLength(255)]
        public string? Remarks { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? RevaluateCurrRate { get; set; }
        public int? SequenceNo { get; set; }
        [StringLength(1)]
        public string? StatementFlag { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TrxDate { get; set; }
        [StringLength(1)]
        public string? TrxType { get; set; }
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [StringLength(80)]
        public string? VendorName { get; set; }
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

        [ForeignKey("CurrCode")]
        [InverseProperty("Pltx1s")]
        public virtual Glex1? CurrCodeNavigation { get; set; }
    }
}
