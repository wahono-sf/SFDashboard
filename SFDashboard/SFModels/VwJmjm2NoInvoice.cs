using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmjm2NoInvoice
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Job No")]
        [StringLength(30)]
        public string JobNo { get; set; } = null!;
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Item Code")]
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [Column("Actual Cost Amt", TypeName = "decimal(17, 2)")]
        public decimal? ActualCostAmt { get; set; }
        [Column("Actual Flag")]
        [StringLength(1)]
        public string? ActualFlag { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? Amt { get; set; }
        [Column("BL Flag")]
        [StringLength(1)]
        public string? BlFlag { get; set; }
        [Column("Charge Unit")]
        [StringLength(1)]
        public string? ChargeUnit { get; set; }
        [Column("Close Flag")]
        [StringLength(1)]
        public string? CloseFlag { get; set; }
        [Column("Commission Code")]
        [StringLength(10)]
        public string? CommissionCode { get; set; }
        [Column("Container No")]
        [StringLength(1000)]
        public string? ContainerNo { get; set; }
        [Column("Contract Code")]
        [StringLength(20)]
        public string? ContractCode { get; set; }
        [Column("Cost Acc Code")]
        [StringLength(15)]
        public string? CostAccCode { get; set; }
        [Column("Cost Adjust Amt", TypeName = "decimal(17, 2)")]
        public decimal? CostAdjustAmt { get; set; }
        [Column("Cost Amt", TypeName = "decimal(17, 2)")]
        public decimal? CostAmt { get; set; }
        [Column("Cost Approve Flag")]
        [StringLength(1)]
        public string? CostApproveFlag { get; set; }
        [Column("Cost Back Flag")]
        [StringLength(1)]
        public string? CostBackFlag { get; set; }
        [Column("Cost Charge Unit")]
        [StringLength(1)]
        public string? CostChargeUnit { get; set; }
        [Column("Cost Curr Code")]
        [StringLength(3)]
        public string? CostCurrCode { get; set; }
        [Column("Cost Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CostCurrRate { get; set; }
        [Column("Cost Pp Cc Flag")]
        [StringLength(1)]
        public string? CostPpCcFlag { get; set; }
        [Column("Cost Qty", TypeName = "decimal(18, 4)")]
        public decimal? CostQty { get; set; }
        [Column("Cost Remark")]
        [StringLength(1000)]
        public string? CostRemark { get; set; }
        [Column("Cost Table Trx No")]
        public int? CostTableTrxNo { get; set; }
        [Column("Cost Unit Rate", TypeName = "decimal(15, 5)")]
        public decimal? CostUnitRate { get; set; }
        [Column("Cost Vat Code")]
        [StringLength(10)]
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
        [StringLength(30)]
        public string? InternalJobNo { get; set; }
        [Column("Job Costing Remark")]
        [StringLength(1000)]
        public string? JobCostingRemark { get; set; }
        [Column("Job Item Trx No")]
        public int? JobItemTrxNo { get; set; }
        [Column("Local Amt", TypeName = "decimal(17, 2)")]
        public decimal? LocalAmt { get; set; }
        [Column("Original Cost Amt", TypeName = "decimal(17, 2)")]
        public decimal? OriginalCostAmt { get; set; }
        [Column("Original Sales Amt", TypeName = "decimal(17, 2)")]
        public decimal? OriginalSalesAmt { get; set; }
        [Column("Post Flag")]
        [StringLength(1)]
        public string? PostFlag { get; set; }
        [Column("Pp Cc Flag")]
        [StringLength(1)]
        public string? PpCcFlag { get; set; }
        [Column("Print Flag")]
        [StringLength(1)]
        public string? PrintFlag { get; set; }
        [Column("Provision Acc Code")]
        [StringLength(15)]
        public string? ProvisionAccCode { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Qty { get; set; }
        [Column("Our Ref")]
        [StringLength(4000)]
        public string? OurRef { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [Column("Sales Acc Code")]
        [StringLength(15)]
        public string? SalesAccCode { get; set; }
        [Column("Sales Approve Flag")]
        [StringLength(1)]
        public string? SalesApproveFlag { get; set; }
        [Column("Salesman Cost Amt", TypeName = "decimal(17, 2)")]
        public decimal? SalesmanCostAmt { get; set; }
        [Column("Sales Provision Acc Code")]
        [StringLength(15)]
        public string? SalesProvisionAccCode { get; set; }
        [Column("Unit Rate", TypeName = "decimal(15, 5)")]
        public decimal? UnitRate { get; set; }
        [Column("Uom Code")]
        [StringLength(50)]
        public string? UomCode { get; set; }
        [Column("Vat Code")]
        [StringLength(10)]
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
