using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSlcr2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Acc Code")]
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column("Apply To Invoice")]
        [StringLength(20)]
        public string? ApplyToInvoice { get; set; }
        [Column("Awb Bl No")]
        [StringLength(30)]
        public string? AwbBlNo { get; set; }
        [Column("Branch Code")]
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [Column("Contra Party Code")]
        [StringLength(10)]
        public string? ContraPartyCode { get; set; }
        [Column("Credit Amt", TypeName = "decimal(17, 2)")]
        public decimal? CreditAmt { get; set; }
        [Column("Credit Local Amt", TypeName = "decimal(17, 2)")]
        public decimal? CreditLocalAmt { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Debit Discount Amt", TypeName = "decimal(17, 2)")]
        public decimal? DebitDiscountAmt { get; set; }
        [Column("Department Code")]
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column("Discoun Locat Amt", TypeName = "decimal(17, 2)")]
        public decimal? DiscounLocatAmt { get; set; }
        [Column("Job No")]
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column("Paid Invoice Flag")]
        [StringLength(1)]
        public string? PaidInvoiceFlag { get; set; }
        [Column("Paid Invoice No")]
        [StringLength(20)]
        public string? PaidInvoiceNo { get; set; }
        [Column("Paid Invoice Trx No")]
        public int? PaidInvoiceTrxNo { get; set; }
        [StringLength(2)]
        public string? Prefix { get; set; }
        [Column("Receipt Amt", TypeName = "decimal(17, 2)")]
        public decimal? ReceiptAmt { get; set; }
        [Column("Receipt Local Amt", TypeName = "decimal(17, 2)")]
        public decimal? ReceiptLocalAmt { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string? CreatedBy { get; set; }
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string? UpdatedBy { get; set; }
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
    }
}
