using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("aepv1")]
    public partial class Aepv1
    {
        public Aepv1()
        {
            Aepv2s = new HashSet<Aepv2>();
        }

        [Key]
        public int TrxNo { get; set; }
        [StringLength(20)]
        public string? ApplyToInvoice { get; set; }
        [StringLength(15)]
        public string? BankAccCode { get; set; }
        [StringLength(10)]
        public string? BankCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ChequeDate { get; set; }
        [StringLength(20)]
        public string? ChequeNo { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
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
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DiscountAmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DiscountDate { get; set; }
        public short? DiscountDay { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DiscountDueDate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DiscountLocalAmt { get; set; }
        [Column(TypeName = "decimal(6, 3)")]
        public decimal? DiscountPercent { get; set; }
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        public byte? EdiCount { get; set; }
        [Column("HAwbNo")]
        [StringLength(20)]
        public string? HawbNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InvoiceAmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InvoiceDate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InvoiceLocalAmt { get; set; }
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column("MAwbNo")]
        [StringLength(20)]
        public string? MawbNo { get; set; }
        public short? NetDay { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NetOfDate { get; set; }
        [StringLength(1)]
        public string? PayCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PostDate { get; set; }
        [StringLength(1)]
        public string PostFlag { get; set; } = null!;
        [StringLength(6)]
        public string? PostMth { get; set; }
        public byte PrintCount { get; set; }
        [StringLength(20)]
        public string? PurchaseOrderNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [StringLength(1)]
        public string? SourceCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? SubTotalAmt { get; set; }
        [StringLength(1)]
        public string? TaxableFlag { get; set; }
        [StringLength(1)]
        public string? TrxType { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? VatAmt { get; set; }
        [StringLength(10)]
        public string? VatCode { get; set; }
        [StringLength(20)]
        public string? VatRegistrationNo { get; set; }
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [StringLength(50)]
        public string? VendorName { get; set; }
        [StringLength(20)]
        public string? VoucherNo { get; set; }
        [StringLength(2)]
        public string? VoucherType { get; set; }
        [StringLength(5)]
        public string? WarehouseNo { get; set; }
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

        [InverseProperty("TrxNoNavigation")]
        public virtual ICollection<Aepv2> Aepv2s { get; set; }
    }
}
