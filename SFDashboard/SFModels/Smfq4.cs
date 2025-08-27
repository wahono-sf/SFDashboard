using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("smfq4")]
    public partial class Smfq4
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        public int? QuoteLineItemNo { get; set; }
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ActualCostAmt { get; set; }
        [StringLength(1)]
        public string? ActualFlag { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amt { get; set; }
        [Column("BLFlag")]
        [StringLength(1)]
        public string? Blflag { get; set; }
        [StringLength(1)]
        public string? ChargeUnit { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CostAdjustAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CostAmt { get; set; }
        [StringLength(1)]
        public string? CostApproveFlag { get; set; }
        [StringLength(1)]
        public string? CostChargeUnit { get; set; }
        [StringLength(3)]
        public string? CostCurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CostCurrRate { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? CostQty { get; set; }
        [StringLength(255)]
        public string? CostRemark { get; set; }
        public int? CostTableTrxNo { get; set; }
        [Column(TypeName = "decimal(15, 5)")]
        public decimal? CostUnitRate { get; set; }
        [StringLength(10)]
        public string? CostVatCode { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(50)]
        public string? CurrRateRemark { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [StringLength(1)]
        public string? InternalFlag { get; set; }
        [StringLength(30)]
        public string? InternalJobNo { get; set; }
        [StringLength(255)]
        public string? JobCostingRemark { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LocalAmt { get; set; }
        [StringLength(1)]
        public string? PpCcFlag { get; set; }
        [StringLength(1)]
        public string? PrintFlag { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Qty { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [StringLength(1)]
        public string? SalesApproveFlag { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? SalesmanCostAmt { get; set; }
        [Column(TypeName = "decimal(15, 5)")]
        public decimal? UnitRate { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
        [StringLength(10)]
        public string? VatCode { get; set; }
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [StringLength(80)]
        public string? VendorName { get; set; }
        [StringLength(50)]
        public string? CreateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDateTime { get; set; }
        [StringLength(50)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDateTime { get; set; }
    }
}
