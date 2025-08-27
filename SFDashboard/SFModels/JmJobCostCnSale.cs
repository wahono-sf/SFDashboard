using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmJobCostCnSale
    {
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Vendor Name")]
        [StringLength(80)]
        public string? VendorName { get; set; }
        [Column("Voucher No")]
        [StringLength(20)]
        public string? VoucherNo { get; set; }
        [Column("Cost Description")]
        [StringLength(50)]
        public string? CostDescription { get; set; }
        [Column("Cost Invoice Date", TypeName = "datetime")]
        public DateTime? CostInvoiceDate { get; set; }
        [Column("Cash Advance Local Amt", TypeName = "decimal(38, 2)")]
        public decimal CashAdvanceLocalAmt { get; set; }
        [Column("Cost Local Amt", TypeName = "decimal(38, 2)")]
        public decimal CostLocalAmt { get; set; }
        [Column("Cost Acc Code")]
        [StringLength(15)]
        public string? CostAccCode { get; set; }
        [Column("Sales Invoice Date", TypeName = "datetime")]
        public DateTime? SalesInvoiceDate { get; set; }
        [Column("Invoice No")]
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column("Sales Local Amt", TypeName = "decimal(38, 2)")]
        public decimal SalesLocalAmt { get; set; }
        [Column("10% Vat AMt", TypeName = "decimal(38, 2)")]
        public decimal _10VatAmt { get; set; }
        [Column("1% Vat Amt", TypeName = "decimal(38, 2)")]
        public decimal _1VatAmt { get; set; }
        [Column("Term Code")]
        [StringLength(3)]
        public string? TermCode { get; set; }
        [Column("Payment Date", TypeName = "datetime")]
        public DateTime? PaymentDate { get; set; }
        [Column("Payment Amt", TypeName = "decimal(38, 2)")]
        public decimal? PaymentAmt { get; set; }
        [Column("Sales Acc Code")]
        [StringLength(15)]
        public string? SalesAccCode { get; set; }
        [Column("Outstanding Amt", TypeName = "decimal(38, 2)")]
        public decimal? OutstandingAmt { get; set; }
        [Column("Due Date", TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
    }
}
