using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("slcr1")]
    [Index("ChequeNo", Name = "INDEX_Slcr1_ChequeNo")]
    [Index("CustomerName", Name = "INDEX_Slcr1_CustomerName")]
    [Index("PostDate", Name = "INDEX_Slcr1_PostDate")]
    [Index("PostFlag", Name = "INDEX_Slcr1_PostFlag")]
    [Index("ReceiptDate", Name = "INDEX_Slcr1_ReceiptDate")]
    [Index("StatusCode", Name = "INDEX_Slcr1_StatusCode")]
    [Index("TrxType", Name = "INDEX_Slcr1_TrxType")]
    [Index("UpdateDateTime", Name = "INDEX_Slcr1_UpdateDateTime")]
    [Index("WorkStation", Name = "INDEX_Slcr1_WorkStation")]
    public partial class Slcr1
    {
        public Slcr1()
        {
            Slcr2s = new HashSet<Slcr2>();
        }

        [Key]
        public int TrxNo { get; set; }
        [StringLength(10)]
        public string? RefNo { get; set; }
        [StringLength(50)]
        public string? Address1 { get; set; }
        [StringLength(50)]
        public string? Address2 { get; set; }
        [StringLength(50)]
        public string? Address3 { get; set; }
        [StringLength(50)]
        public string? Address4 { get; set; }
        [StringLength(1)]
        public string? AutoHandFlag { get; set; }
        [StringLength(15)]
        public string? BankAccCode { get; set; }
        [StringLength(15)]
        public string? BankCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BankSlipDate { get; set; }
        [StringLength(10)]
        public string? BankSlipNo { get; set; }
        [StringLength(10)]
        public string? BillCollectorCode { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? CashAmt { get; set; }
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
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? ChequeAmt { get; set; }
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
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
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
        [Column(TypeName = "datetime")]
        public DateTime? DueDateFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DueDateTo { get; set; }
        public byte? EdiCount { get; set; }
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
        [StringLength(12)]
        public string? JournalNo { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? LocalSubTotalAmt { get; set; }
        [StringLength(50)]
        public string? LockBy { get; set; }
        [StringLength(1)]
        public string? LockFlag { get; set; }
        [StringLength(20)]
        public string? NonTaxReceiptNo { get; set; }
        [StringLength(3)]
        public string? PayCode { get; set; }
        [StringLength(50)]
        public string? PaymentBy { get; set; }
        [StringLength(5)]
        public string? PayMode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PlanCollectionDate { get; set; }
        [StringLength(50)]
        public string? PostBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PostDate { get; set; }
        [StringLength(1)]
        public string? PostFlag { get; set; }
        [StringLength(6)]
        public string? PostMth { get; set; }
        public byte? PrintCount { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? ReceiptAmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceiptDate { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? ReceiptLocalAmt { get; set; }
        [StringLength(20)]
        public string? ReceiptNo { get; set; }
        [StringLength(2)]
        public string? ReceiptType { get; set; }
        [StringLength(1)]
        public string? ReconcilFlag { get; set; }
        [StringLength(50)]
        public string? Reference { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? SubTotalAmt { get; set; }
        [StringLength(20)]
        public string? TaxReceiptNo { get; set; }
        [StringLength(10)]
        public string? TransitNo { get; set; }
        [StringLength(1)]
        public string? TrxType { get; set; }
        [StringLength(1)]
        public string? VatTaxableFlag { get; set; }
        [StringLength(10)]
        public string? VendorCode { get; set; }
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

        [InverseProperty("TrxNoNavigation")]
        public virtual ICollection<Slcr2> Slcr2s { get; set; }
    }
}
