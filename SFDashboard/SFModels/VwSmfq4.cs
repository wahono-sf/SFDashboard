using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSmfq4
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Quote Line Item No")]
        public int? QuoteLineItemNo { get; set; }
        [Column("Item Code")]
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [Column("Actual Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? ActualCostAmt { get; set; }
        [Column("Actual Flag")]
        [StringLength(1)]
        public string? ActualFlag { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amt { get; set; }
        [Column("BL Flag")]
        [StringLength(1)]
        public string? BlFlag { get; set; }
        [Column("Charge Unit")]
        [StringLength(1)]
        public string? ChargeUnit { get; set; }
        [Column("Cost Adjust Amt", TypeName = "decimal(13, 2)")]
        public decimal? CostAdjustAmt { get; set; }
        [Column("Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? CostAmt { get; set; }
        [Column("Cost Approve Flag")]
        [StringLength(1)]
        public string? CostApproveFlag { get; set; }
        [Column("Cost Charge Unit")]
        [StringLength(1)]
        public string? CostChargeUnit { get; set; }
        [Column("Cost Curr Code")]
        [StringLength(3)]
        public string? CostCurrCode { get; set; }
        [Column("Cost Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CostCurrRate { get; set; }
        [Column("Cost Qty", TypeName = "decimal(18, 4)")]
        public decimal? CostQty { get; set; }
        [Column("Cost Remark")]
        [StringLength(255)]
        public string? CostRemark { get; set; }
        [Column("Cost Table Trx No")]
        public int? CostTableTrxNo { get; set; }
        [Column("Cost Unit Rate", TypeName = "decimal(15, 5)")]
        public decimal? CostUnitRate { get; set; }
        [Column("Cost Vat Code")]
        [StringLength(3)]
        public string? CostVatCode { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column("Curr Rate Remark")]
        [StringLength(50)]
        public string? CurrRateRemark { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column("Internal Flag")]
        [StringLength(1)]
        public string? InternalFlag { get; set; }
        [Column("Internal Job No")]
        [StringLength(20)]
        public string? InternalJobNo { get; set; }
        [Column("Job Costing Remark")]
        [StringLength(255)]
        public string? JobCostingRemark { get; set; }
        [Column("Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? LocalAmt { get; set; }
        [Column("Pp Cc Flag")]
        [StringLength(1)]
        public string? PpCcFlag { get; set; }
        [Column("Print Flag")]
        [StringLength(1)]
        public string? PrintFlag { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Qty { get; set; }
        [Column("Our Ref")]
        [StringLength(4000)]
        public string? OurRef { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [Column("Sales Approve Flag")]
        [StringLength(1)]
        public string? SalesApproveFlag { get; set; }
        [Column("Salesman Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? SalesmanCostAmt { get; set; }
        [Column("Unit Rate", TypeName = "decimal(15, 5)")]
        public decimal? UnitRate { get; set; }
        [Column("Uom Code")]
        [StringLength(3)]
        public string? UomCode { get; set; }
        [Column("Vat Code")]
        [StringLength(3)]
        public string? VatCode { get; set; }
        [Column("Vendor Code")]
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [Column("Vendor Name")]
        [StringLength(80)]
        public string? VendorName { get; set; }
        [Column("Create By")]
        [StringLength(50)]
        public string? CreateBy { get; set; }
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Update By")]
        [StringLength(50)]
        public string? UpdateBy { get; set; }
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
    }
}
