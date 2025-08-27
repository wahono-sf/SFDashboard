using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("plvx1")]
    [Index("RefNo", Name = "INDEX_plvx1_RefNo")]
    public partial class Plvx1
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
        [StringLength(20)]
        public string? ChequeNo { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? InvoiceAndVatAmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InvoiceDate { get; set; }
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? LastPaidAmt { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? PaidAmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PaidDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PostDate { get; set; }
        [StringLength(6)]
        public string? PostMth { get; set; }
        [StringLength(2)]
        public string? Prefix { get; set; }
        [StringLength(10)]
        public string? RefNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? TotalExmAmt { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? TotalStdAmt { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? TotalVatAmt { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? TotalZeroAmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? VatReceiptDate { get; set; }
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [StringLength(80)]
        public string? VendorName { get; set; }
        [StringLength(20)]
        public string? VendorVatReceiptNo { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }

        [ForeignKey("CurrCode")]
        [InverseProperty("Plvx1s")]
        public virtual Glex1? CurrCodeNavigation { get; set; }
    }
}
