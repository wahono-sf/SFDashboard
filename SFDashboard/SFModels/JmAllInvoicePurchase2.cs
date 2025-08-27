using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmAllInvoicePurchase2
    {
        [Column("Acc Code")]
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column("Apply To Invoice")]
        [StringLength(20)]
        public string? ApplyToInvoice { get; set; }
        [Column("Bank Code")]
        [StringLength(10)]
        public string? BankCode { get; set; }
        [Column("Cheque Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ChequeDate { get; set; }
        [Column("Cheque No")]
        [StringLength(20)]
        public string? ChequeNo { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column("Due Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DueDate { get; set; }
        [Column("Goods Description 1")]
        [StringLength(80)]
        public string? GoodsDescription1 { get; set; }
        [Column("Goods Description 2")]
        [StringLength(80)]
        public string? GoodsDescription2 { get; set; }
        [Column("Goods Description 3")]
        [StringLength(80)]
        public string? GoodsDescription3 { get; set; }
        [Column("Goods Description 4")]
        [StringLength(80)]
        public string? GoodsDescription4 { get; set; }
        [Column("Goods Description 5")]
        [StringLength(80)]
        public string? GoodsDescription5 { get; set; }
        [Column("Invoice And Vat Amt", TypeName = "decimal(13, 2)")]
        public decimal? InvoiceAndVatAmt { get; set; }
        [Column("Invoice And Vat Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? InvoiceAndVatLocalAmt { get; set; }
        [Column("Invoice Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? InvoiceDate { get; set; }
        [Column("Invoice No")]
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Our Ref")]
        [StringLength(24)]
        public string? OurRef { get; set; }
        [Column("Post Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PostDate { get; set; }
        [Column("Post Flag")]
        [StringLength(1)]
        public string? PostFlag { get; set; }
        [Column("Post Mth")]
        [StringLength(6)]
        public string? PostMth { get; set; }
        [Column("Ref No")]
        [StringLength(10)]
        public string? RefNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Site Code")]
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [Column("Total Vat Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalVatAmt { get; set; }
        [Column("Trx Type")]
        [StringLength(1)]
        public string? TrxType { get; set; }
        [Column("Receipt No")]
        [StringLength(20)]
        public string? ReceiptNo { get; set; }
        [Column("Receipt Type")]
        [StringLength(2)]
        public string? ReceiptType { get; set; }
        [Column("Your Ref")]
        [StringLength(24)]
        public string? YourRef { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
        [Column("Created By")]
        [StringLength(50)]
        public string CreatedBy { get; set; } = null!;
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string UpdatedBy { get; set; } = null!;
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
        [Column("Line Item No")]
        public short? LineItemNo { get; set; }
        [Column("Item Acc Code")]
        [StringLength(15)]
        public string? ItemAccCode { get; set; }
        [Column("Item Amt", TypeName = "decimal(13, 2)")]
        public decimal? ItemAmt { get; set; }
        [Column("Item Code")]
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [Column("Item Description")]
        [StringLength(50)]
        public string? ItemDescription { get; set; }
        [Column("Item Curr Code")]
        [StringLength(3)]
        public string? ItemCurrCode { get; set; }
        [Column("Item Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? ItemCurrRate { get; set; }
        [Column("Job Item Trx No")]
        public int? JobItemTrxNo { get; set; }
        [Column("Item Job No")]
        [StringLength(20)]
        public string? ItemJobNo { get; set; }
        [Column("Item Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? ItemLocalAmt { get; set; }
        [Column("Item Qty", TypeName = "decimal(13, 4)")]
        public decimal? ItemQty { get; set; }
        [Column("Item Remark")]
        [StringLength(1000)]
        public string? ItemRemark { get; set; }
        [Column("Item Unit Rate", TypeName = "decimal(15, 5)")]
        public decimal? ItemUnitRate { get; set; }
        [Column("Item Uom Code")]
        [StringLength(3)]
        public string? ItemUomCode { get; set; }
        [Column("Item Vat Amt", TypeName = "decimal(13, 2)")]
        public decimal? ItemVatAmt { get; set; }
        [Column("Item Vat Local Amt", TypeName = "decimal(31, 12)")]
        public decimal? ItemVatLocalAmt { get; set; }
        [Column("Item Vat Code")]
        [StringLength(3)]
        public string? ItemVatCode { get; set; }
        [StringLength(2)]
        [Unicode(false)]
        public string Type { get; set; } = null!;
    }
}
