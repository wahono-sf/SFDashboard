using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSmhq2
    {
        [Column("Charge Type 1")]
        [StringLength(1)]
        public string? ChargeType1 { get; set; }
        [Column("Charge Type 2")]
        [StringLength(1)]
        public string? ChargeType2 { get; set; }
        [Column("Charge Type 3")]
        [StringLength(1)]
        public string? ChargeType3 { get; set; }
        [Column("Charge Type 4")]
        [StringLength(1)]
        public string? ChargeType4 { get; set; }
        [Column("Charge Type 5")]
        [StringLength(1)]
        public string? ChargeType5 { get; set; }
        [Column("Charge Type 6")]
        [StringLength(1)]
        public string? ChargeType6 { get; set; }
        [Column("Cost Unit Rate 1", TypeName = "decimal(13, 3)")]
        public decimal? CostUnitRate1 { get; set; }
        [Column("Cost Unit Rate 2", TypeName = "decimal(13, 3)")]
        public decimal? CostUnitRate2 { get; set; }
        [Column("Cost Unit Rate 3", TypeName = "decimal(13, 3)")]
        public decimal? CostUnitRate3 { get; set; }
        [Column("Cost Unit Rate 4", TypeName = "decimal(13, 3)")]
        public decimal? CostUnitRate4 { get; set; }
        [Column("Cost Unit Rate 5", TypeName = "decimal(13, 3)")]
        public decimal? CostUnitRate5 { get; set; }
        [Column("Cost Unit Rate 6", TypeName = "decimal(13, 3)")]
        public decimal? CostUnitRate6 { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string CustomerCode { get; set; } = null!;
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Min Amt 1", TypeName = "decimal(13, 2)")]
        public decimal? MinAmt1 { get; set; }
        [Column("Min Amt 2", TypeName = "decimal(13, 2)")]
        public decimal? MinAmt2 { get; set; }
        [Column("Min Amt 3", TypeName = "decimal(13, 2)")]
        public decimal? MinAmt3 { get; set; }
        [Column("Min Amt 4", TypeName = "decimal(13, 2)")]
        public decimal? MinAmt4 { get; set; }
        [Column("Min Amt 5", TypeName = "decimal(13, 2)")]
        public decimal? MinAmt5 { get; set; }
        [Column("Min Amt 6", TypeName = "decimal(13, 2)")]
        public decimal? MinAmt6 { get; set; }
        [Column("Min Cost Amt 1", TypeName = "decimal(13, 2)")]
        public decimal? MinCostAmt1 { get; set; }
        [Column("Min Cost Amt 2", TypeName = "decimal(13, 2)")]
        public decimal? MinCostAmt2 { get; set; }
        [Column("Min Cost Amt 3", TypeName = "decimal(13, 2)")]
        public decimal? MinCostAmt3 { get; set; }
        [Column("Min Cost Amt 4", TypeName = "decimal(13, 2)")]
        public decimal? MinCostAmt4 { get; set; }
        [Column("Min Cost Amt 5", TypeName = "decimal(13, 2)")]
        public decimal? MinCostAmt5 { get; set; }
        [Column("Min Cost Amt 6", TypeName = "decimal(13, 2)")]
        public decimal? MinCostAmt6 { get; set; }
        [Column("Min Qty 1", TypeName = "decimal(13, 4)")]
        public decimal? MinQty1 { get; set; }
        [Column("Min Qty 2", TypeName = "decimal(13, 4)")]
        public decimal? MinQty2 { get; set; }
        [Column("Min Qty 3", TypeName = "decimal(13, 4)")]
        public decimal? MinQty3 { get; set; }
        [Column("Min Qty 4", TypeName = "decimal(13, 4)")]
        public decimal? MinQty4 { get; set; }
        [Column("Min Qty 5", TypeName = "decimal(13, 4)")]
        public decimal? MinQty5 { get; set; }
        [Column("Min Qty 6", TypeName = "decimal(13, 4)")]
        public decimal? MinQty6 { get; set; }
        [Column("Sales Item Code")]
        [StringLength(30)]
        public string? SalesItemCode { get; set; }
        [Column("Sales Item Description")]
        [StringLength(50)]
        public string? SalesItemDescription { get; set; }
        [Column("Unit Rate 1", TypeName = "decimal(13, 3)")]
        public decimal? UnitRate1 { get; set; }
        [Column("Unit Rate 2", TypeName = "decimal(13, 3)")]
        public decimal? UnitRate2 { get; set; }
        [Column("Unit Rate 3", TypeName = "decimal(13, 3)")]
        public decimal? UnitRate3 { get; set; }
        [Column("Unit Rate 4", TypeName = "decimal(13, 3)")]
        public decimal? UnitRate4 { get; set; }
        [Column("Unit Rate 5", TypeName = "decimal(13, 3)")]
        public decimal? UnitRate5 { get; set; }
        [Column("Unit Rate 6", TypeName = "decimal(13, 3)")]
        public decimal? UnitRate6 { get; set; }
        [Column("Uom Code")]
        [StringLength(3)]
        public string? UomCode { get; set; }
        [StringLength(3)]
        [Unicode(false)]
        public string Status { get; set; } = null!;
    }
}
