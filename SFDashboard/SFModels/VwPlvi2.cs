using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwPlvi2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Item Trx No")]
        public int ItemTrxNo { get; set; }
        [Column("Item Code")]
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [Column("Acc Code")]
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? Amt { get; set; }
        [Column("Awb Bl No")]
        [StringLength(30)]
        public string? AwbBlNo { get; set; }
        [Column("Bill Type")]
        [StringLength(2)]
        public string? BillType { get; set; }
        [Column("Branch Code")]
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [Column("Cash Advance Voucher No")]
        [StringLength(20)]
        public string? CashAdvanceVoucherNo { get; set; }
        [Column("Contract Code")]
        [StringLength(20)]
        public string? ContractCode { get; set; }
        [Column("Cost Amt", TypeName = "decimal(18, 0)")]
        public decimal? CostAmt { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column("Department Code")]
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column("Invoice Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? InvoiceDate { get; set; }
        [Column("Invoice No")]
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column("Invoice Ref No")]
        [StringLength(20)]
        public string? InvoiceRefNo { get; set; }
        [Column("Job Item Trx No")]
        public int? JobItemTrxNo { get; set; }
        [Column("Job Line Item No")]
        public int? JobLineItemNo { get; set; }
        [Column("Job No")]
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column("Local Amt", TypeName = "decimal(17, 2)")]
        public decimal? LocalAmt { get; set; }
        [Column("Main Acc Code")]
        [StringLength(15)]
        public string? MainAccCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Qty { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [Column("Sales Item Trx No")]
        public int? SalesItemTrxNo { get; set; }
        [Column("Source Ref No")]
        [StringLength(10)]
        public string? SourceRefNo { get; set; }
        [Column("Split Flag")]
        [StringLength(1)]
        public string? SplitFlag { get; set; }
        [Column("Tax Invoice Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? TaxInvoiceDate { get; set; }
        [Column("Tax Invoice No")]
        [StringLength(30)]
        public string? TaxInvoiceNo { get; set; }
        [Column("Tax Invoice Receipt Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? TaxInvoiceReceiptDate { get; set; }
        [Column("Unit Rate", TypeName = "decimal(15, 5)")]
        public decimal? UnitRate { get; set; }
        [Column("Uom Code")]
        [StringLength(50)]
        public string? UomCode { get; set; }
        [Column("Vat Amt", TypeName = "decimal(17, 2)")]
        public decimal? VatAmt { get; set; }
        [Column("Vat Code")]
        [StringLength(10)]
        public string? VatCode { get; set; }
        [Column("Vat Refund Done")]
        [StringLength(1)]
        public string? VatRefundDone { get; set; }
        [Column("Vat Refund Flag")]
        [StringLength(1)]
        public string? VatRefundFlag { get; set; }
        [Column("With Hold Tax Code")]
        [StringLength(3)]
        public string? WithHoldTaxCode { get; set; }
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
