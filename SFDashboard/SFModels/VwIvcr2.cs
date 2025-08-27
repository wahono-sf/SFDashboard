using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwIvcr2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Item Code")]
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [Column("Acc Code")]
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? Amt { get; set; }
        [Column("Bill Type Flag")]
        [StringLength(1)]
        public string? BillTypeFlag { get; set; }
        [Column("Branch Code")]
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [Column("Charge Type")]
        [StringLength(5)]
        public string? ChargeType { get; set; }
        [Column("Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
        [Column("Commission Code")]
        [StringLength(10)]
        public string? CommissionCode { get; set; }
        [Column("Contract Code")]
        [StringLength(20)]
        public string? ContractCode { get; set; }
        [Column("Cost Amt", TypeName = "decimal(17, 2)")]
        public decimal? CostAmt { get; set; }
        [Column("Cost Remark")]
        [StringLength(255)]
        public string? CostRemark { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? CurrDate { get; set; }
        [Column("Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column("Delivery Order No")]
        [StringLength(40)]
        public string? DeliveryOrderNo { get; set; }
        [Column("Department Code")]
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? Factor { get; set; }
        [Column("Invoice No")]
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column("Item Trx No")]
        public int ItemTrxNo { get; set; }
        [Column("Job Item Trx No")]
        public int? JobItemTrxNo { get; set; }
        [Column("Job No")]
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column("Local Amt", TypeName = "decimal(17, 2)")]
        public decimal? LocalAmt { get; set; }
        [Column("Lock Flag")]
        [StringLength(1)]
        public string? LockFlag { get; set; }
        [Column("Main Acc Code")]
        [StringLength(15)]
        public string? MainAccCode { get; set; }
        [Column("Markup Rate", TypeName = "decimal(17, 2)")]
        public decimal? MarkupRate { get; set; }
        [Column("MinAmt Flag")]
        [StringLength(1)]
        public string? MinAmtFlag { get; set; }
        [Column("Original Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? OriginalCurrRate { get; set; }
        public int? Pcs { get; set; }
        [Column("Purchase Item Trx No")]
        public int? PurchaseItemTrxNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Qty { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [Column("Short Remark")]
        [StringLength(255)]
        public string? ShortRemark { get; set; }
        [Column("Unit Rate", TypeName = "decimal(17, 5)")]
        public decimal? UnitRate { get; set; }
        [Column("Uom Code")]
        [StringLength(50)]
        public string? UomCode { get; set; }
        [Column("Vat Amt", TypeName = "decimal(17, 2)")]
        public decimal? VatAmt { get; set; }
        [Column("Vat Code")]
        [StringLength(10)]
        public string? VatCode { get; set; }
        [Column("Vat Exchg", TypeName = "decimal(17, 2)")]
        public decimal? VatExchg { get; set; }
        [Column("W Hold Tax Code")]
        [StringLength(3)]
        public string? WHoldTaxCode { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string? WorkStation { get; set; }
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
