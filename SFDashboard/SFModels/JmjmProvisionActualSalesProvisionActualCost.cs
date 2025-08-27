using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmjmProvisionActualSalesProvisionActualCost
    {
        [Column("Job No")]
        [StringLength(30)]
        public string JobNo { get; set; } = null!;
        [Column("Item Code")]
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [Column("Item Description")]
        [StringLength(50)]
        public string? ItemDescription { get; set; }
        [Column("Sales Qty", TypeName = "decimal(18, 4)")]
        public decimal? SalesQty { get; set; }
        [Column("Sales Curr Code")]
        [StringLength(3)]
        public string? SalesCurrCode { get; set; }
        [Column("Sales Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? SalesCurrRate { get; set; }
        [Column("Provision Sales", TypeName = "decimal(17, 2)")]
        public decimal? ProvisionSales { get; set; }
        [Column("USD Sales", TypeName = "decimal(31, 9)")]
        public decimal UsdSales { get; set; }
        [Column("IDR Sales", TypeName = "decimal(31, 9)")]
        public decimal IdrSales { get; set; }
        [Column("Local Amt Sales", TypeName = "decimal(38, 8)")]
        public decimal LocalAmtSales { get; set; }
        [Column("Cost Qty", TypeName = "decimal(18, 4)")]
        public decimal? CostQty { get; set; }
        [Column("Cost Curr Code")]
        [StringLength(3)]
        public string? CostCurrCode { get; set; }
        [Column("Cost Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CostCurrRate { get; set; }
        [Column("Provision Cost", TypeName = "decimal(34, 9)")]
        public decimal ProvisionCost { get; set; }
        [Column("USD Cost", TypeName = "decimal(31, 9)")]
        public decimal UsdCost { get; set; }
        [Column("IDR Cost", TypeName = "decimal(31, 9)")]
        public decimal IdrCost { get; set; }
        [Column("Local Amt Cost", TypeName = "decimal(38, 8)")]
        public decimal LocalAmtCost { get; set; }
    }
}
