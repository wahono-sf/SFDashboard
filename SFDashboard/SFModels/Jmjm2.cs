using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmjm2")]
    [Index("JobNo", "LineItemNo", Name = "CK_Jmjm2", IsUnique = true)]
    [Index("InternalFlag", Name = "INDEX_Jmjm2_InternalFlag")]
    [Index("ItemCode", Name = "INDEX_Jmjm2_ItemCode")]
    [Index("JobNo", Name = "INDEX_Jmjm2_JobNo")]
    [Index("TrxNo", Name = "INDEX_Jmjm2_TrxNo")]
    [Index("JobNo", "LineItemNo", Name = "Unique_JobNo_LineItemNo", IsUnique = true)]
    public partial class Jmjm2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        [StringLength(30)]
        public string JobNo { get; set; } = null!;
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? ActualCostAmt { get; set; }
        [StringLength(1)]
        public string? ActualFlag { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? Amt { get; set; }
        [Column("BLFlag")]
        [StringLength(1)]
        public string? Blflag { get; set; }
        [StringLength(1)]
        public string? ChargeUnit { get; set; }
        [StringLength(1)]
        public string? CloseFlag { get; set; }
        [StringLength(10)]
        public string? CommissionCode { get; set; }
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [StringLength(1000)]
        public string? ContainerNo { get; set; }
        [StringLength(20)]
        public string? ContractCode { get; set; }
        [StringLength(15)]
        public string? CostAccCode { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? CostAdjustAmt { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? CostAmt { get; set; }
        [StringLength(1)]
        public string? CostApproveFlag { get; set; }
        [StringLength(1)]
        public string? CostBackFlag { get; set; }
        [StringLength(1)]
        public string? CostChargeUnit { get; set; }
        [StringLength(3)]
        public string? CostCurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CostCurrRate { get; set; }
        [StringLength(1)]
        public string? CostPpCcFlag { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? CostQty { get; set; }
        [StringLength(1000)]
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
        [StringLength(1000)]
        public string? JobCostingRemark { get; set; }
        public int? JobItemTrxNo { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? LocalAmt { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? OriginalCostAmt { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? OriginalSalesAmt { get; set; }
        [StringLength(1)]
        public string? PostFlag { get; set; }
        [StringLength(1)]
        public string? PpCcFlag { get; set; }
        [StringLength(1)]
        public string? PrintFlag { get; set; }
        [StringLength(15)]
        public string? ProvisionAccCode { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Qty { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [StringLength(15)]
        public string? SalesAccCode { get; set; }
        [StringLength(1)]
        public string? SalesApproveFlag { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? SalesmanCostAmt { get; set; }
        [StringLength(15)]
        public string? SalesProvisionAccCode { get; set; }
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
