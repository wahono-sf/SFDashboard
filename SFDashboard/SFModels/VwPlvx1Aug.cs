using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwPlvx1Aug
    {
        [Column("Invoice No")]
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column("Post Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PostDate { get; set; }
        [Column("Invoice Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? InvoiceDate { get; set; }
        [Column("Post Mth")]
        [StringLength(6)]
        public string? PostMth { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Vendor Name")]
        [StringLength(80)]
        public string? VendorName { get; set; }
        [Column("Vendor Code")]
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [Column("Vat Code")]
        [StringLength(3)]
        public string? VatCode { get; set; }
        [Column("Total Zero Amt", TypeName = "decimal(38, 2)")]
        public decimal? TotalZeroAmt { get; set; }
        [Column("Total Std Amt", TypeName = "decimal(38, 2)")]
        public decimal? TotalStdAmt { get; set; }
        [Column("Total Out Amt", TypeName = "decimal(38, 2)")]
        public decimal? TotalOutAmt { get; set; }
        [Column("Total Exm Amt", TypeName = "decimal(38, 2)")]
        public decimal? TotalExmAmt { get; set; }
        [Column("Total Zero Foreign Amt", TypeName = "decimal(38, 2)")]
        public decimal? TotalZeroForeignAmt { get; set; }
        [Column("Total Std Foreign Amt", TypeName = "decimal(38, 2)")]
        public decimal? TotalStdForeignAmt { get; set; }
        [Column("Total Out Foreign Amt", TypeName = "decimal(38, 2)")]
        public decimal? TotalOutForeignAmt { get; set; }
        [Column("Total Exm Foreign Amt", TypeName = "decimal(38, 2)")]
        public decimal? TotalExmForeignAmt { get; set; }
        [Column("Ref No")]
        [StringLength(10)]
        public string? RefNo { get; set; }
        [Column("Invoice And Vat Amt", TypeName = "decimal(38, 2)")]
        public decimal? InvoiceAndVatAmt { get; set; }
        [Column("Invoice And Vat Foreign Amt", TypeName = "decimal(13, 2)")]
        public decimal? InvoiceAndVatForeignAmt { get; set; }
        [Column("Total Vat Amt", TypeName = "decimal(31, 12)")]
        public decimal? TotalVatAmt { get; set; }
        [Column("Total Vat Foreign Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalVatForeignAmt { get; set; }
        [Column("Vendor Vat Receipt No")]
        [StringLength(20)]
        public string? VendorVatReceiptNo { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
