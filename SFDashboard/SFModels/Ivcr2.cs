using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("ivcr2")]
    [Index("AccCode", Name = "INDEX_Ivcr2_AccCode")]
    [Index("ItemCode", Name = "INDEX_Ivcr2_ItemCode")]
    [Index("JobItemTrxNo", Name = "INDEX_Ivcr2_JobItemTrxNo")]
    [Index("JobNo", Name = "INDEX_Ivcr2_JobNo")]
    public partial class Ivcr2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? Amt { get; set; }
        [StringLength(1)]
        public string? BillTypeFlag { get; set; }
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [StringLength(5)]
        public string? ChargeType { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
        [StringLength(10)]
        public string? CommissionCode { get; set; }
        [StringLength(20)]
        public string? ContractCode { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? CostAmt { get; set; }
        [StringLength(255)]
        public string? CostRemark { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CurrDate { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(40)]
        public string? DeliveryOrderNo { get; set; }
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? Factor { get; set; }
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        public int ItemTrxNo { get; set; }
        public int? JobItemTrxNo { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? LocalAmt { get; set; }
        [StringLength(1)]
        public string? LockFlag { get; set; }
        [StringLength(15)]
        public string? MainAccCode { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? MarkupRate { get; set; }
        [StringLength(1)]
        public string? MinAmtFlag { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? OriginalCurrRate { get; set; }
        public int? Pcs { get; set; }
        public int? PurchaseItemTrxNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Qty { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [Column(TypeName = "decimal(17, 5)")]
        public decimal? UnitRate { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? VatAmt { get; set; }
        [StringLength(10)]
        public string? VatCode { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? VatExchg { get; set; }
        [Column("WHoldTaxCode")]
        [StringLength(3)]
        public string? WholdTaxCode { get; set; }
        [StringLength(50)]
        public string? WorkStation { get; set; }
        [StringLength(50)]
        public string? CreateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDateTime { get; set; }
        [StringLength(50)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDateTime { get; set; }

        [ForeignKey("AccCode")]
        [InverseProperty("Ivcr2s")]
        public virtual Glch1? AccCodeNavigation { get; set; }
        [ForeignKey("CurrCode")]
        [InverseProperty("Ivcr2s")]
        public virtual Glex1? CurrCodeNavigation { get; set; }
        [ForeignKey("ItemCode")]
        [InverseProperty("Ivcr2s")]
        public virtual Acit1? ItemCodeNavigation { get; set; }
        [ForeignKey("TrxNo")]
        [InverseProperty("Ivcr2s")]
        public virtual Ivcr1 TrxNoNavigation { get; set; } = null!;
        [ForeignKey("UomCode")]
        [InverseProperty("Ivcr2s")]
        public virtual Rcum1? UomCodeNavigation { get; set; }
        [ForeignKey("VatCode")]
        [InverseProperty("Ivcr2s")]
        public virtual Acva1? VatCodeNavigation { get; set; }
    }
}
