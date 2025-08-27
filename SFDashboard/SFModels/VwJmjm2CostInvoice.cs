using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmjm2CostInvoice
    {
        [Column("Job No")]
        [StringLength(30)]
        public string JobNo { get; set; } = null!;
        [Column("Job Costing Remark")]
        [StringLength(1000)]
        public string? JobCostingRemark { get; set; }
        [Column("Item Code")]
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column("Container No")]
        [StringLength(1000)]
        public string? ContainerNo { get; set; }
        [Column("Cost Curr Code")]
        [StringLength(3)]
        public string? CostCurrCode { get; set; }
        [Column("Cost Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CostCurrRate { get; set; }
        [Column("Cost Qty", TypeName = "decimal(18, 4)")]
        public decimal? CostQty { get; set; }
        [Column("Cost Unit Rate", TypeName = "decimal(15, 5)")]
        public decimal? CostUnitRate { get; set; }
        [Column("Cost F Amt", TypeName = "decimal(34, 9)")]
        public decimal? CostFAmt { get; set; }
        [Column("Cost Amt", TypeName = "decimal(17, 2)")]
        public decimal? CostAmt { get; set; }
        [Column("Commission Code")]
        [StringLength(10)]
        public string? CommissionCode { get; set; }
        [Column("Cost Charge Unit")]
        [StringLength(1)]
        public string? CostChargeUnit { get; set; }
        [Column("Cost Remark")]
        [StringLength(1000)]
        public string? CostRemark { get; set; }
        [Column("Cost Vat Code")]
        [StringLength(10)]
        public string? CostVatCode { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column("Vendor Code")]
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [Column("Vendor Name")]
        [StringLength(80)]
        public string? VendorName { get; set; }
    }
}
