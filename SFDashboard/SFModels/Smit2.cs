using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("smit2")]
    public partial class Smit2
    {
        [Key]
        [StringLength(5)]
        public string QuotationTableNo { get; set; } = null!;
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(1)]
        public string? ChargeType1 { get; set; }
        [StringLength(1)]
        public string? ChargeType2 { get; set; }
        [StringLength(1)]
        public string? ChargeType3 { get; set; }
        [StringLength(1)]
        public string? ChargeType4 { get; set; }
        [StringLength(1)]
        public string? ChargeType5 { get; set; }
        [StringLength(1)]
        public string? ChargeType6 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? CostUnitRate1 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? CostUnitRate2 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? CostUnitRate3 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? CostUnitRate4 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? CostUnitRate5 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? CostUnitRate6 { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? MinAmt1 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? MinAmt2 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? MinAmt3 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? MinAmt4 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? MinAmt5 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? MinAmt6 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? MinCostAmt1 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? MinCostAmt2 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? MinCostAmt3 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? MinCostAmt4 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? MinCostAmt5 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? MinCostAmt6 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MinQty1 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MinQty2 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MinQty3 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MinQty4 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MinQty5 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MinQty6 { get; set; }
        [StringLength(30)]
        public string? SalesItemCode { get; set; }
        [StringLength(50)]
        public string? SalesItemDescription { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? UnitRate1 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? UnitRate2 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? UnitRate3 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? UnitRate4 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? UnitRate5 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? UnitRate6 { get; set; }

        [ForeignKey("QuotationTableNo")]
        [InverseProperty("Smit2s")]
        public virtual Smit1 QuotationTableNoNavigation { get; set; } = null!;
        [ForeignKey("SalesItemCode")]
        [InverseProperty("Smit2s")]
        public virtual Acit1? SalesItemCodeNavigation { get; set; }
        [ForeignKey("UomCode")]
        [InverseProperty("Smit2s")]
        public virtual Rcum1? UomCodeNavigation { get; set; }
    }
}
