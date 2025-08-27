using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("acit1")]
    [Index("CostAccCode", Name = "INDEX_Acit1_CostAccCode")]
    [Index("ItemDescription", Name = "INDEX_Acit1_ItemDescription")]
    [Index("JobType", Name = "INDEX_Acit1_JobType")]
    [Index("SalesAccCode", Name = "INDEX_Acit1_SalesAccCode")]
    [Index("StatusCode", Name = "INDEX_Acit1_StatusCode")]
    public partial class Acit1
    {
        public Acit1()
        {
            Amdc1s = new HashSet<Amdc1>();
            Amid2s = new HashSet<Amid2>();
            Amio2s = new HashSet<Amio2>();
            Ivch2s = new HashSet<Ivch2>();
            Ivcr2s = new HashSet<Ivcr2>();
            Sepi2s = new HashSet<Sepi2>();
            Slaj1s = new HashSet<Slaj1>();
            Smhq2s = new HashSet<Smhq2>();
            Smht2s = new HashSet<Smht2>();
            Smiq2s = new HashSet<Smiq2>();
            Smit2s = new HashSet<Smit2>();
            Smpa1BafItemCodeNavigations = new HashSet<Smpa1>();
            Smpa1DdcItemCodeNavigations = new HashSet<Smpa1>();
            Ssjd1s = new HashSet<Ssjd1>();
            Torc1s = new HashSet<Torc1>();
            Whbt2s = new HashSet<Whbt2>();
        }

        [Key]
        [StringLength(30)]
        public string ItemCode { get; set; } = null!;
        [StringLength(50)]
        public string? ItemDescription { get; set; }
        [StringLength(5)]
        public string? ChargeType { get; set; }
        [StringLength(1)]
        public string? ChargeUnit { get; set; }
        [StringLength(30)]
        public string? ConsolItemCode { get; set; }
        [StringLength(15)]
        public string? CostAccCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CostAmt { get; set; }
        [StringLength(10)]
        public string? CostAnalysisCode { get; set; }
        [StringLength(10)]
        public string? CostCenterCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CostPercent { get; set; }
        [StringLength(10)]
        public string? CostVatCode { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
        [StringLength(10)]
        public string? ItemShortCode { get; set; }
        [StringLength(10)]
        public string? JobType { get; set; }
        [StringLength(255)]
        public string? LocalName { get; set; }
        [StringLength(1)]
        public string? LockVatFlag { get; set; }
        [StringLength(15)]
        public string? ProvisionAccCode { get; set; }
        [StringLength(1)]
        public string? RecoverableFlag { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(15)]
        public string? SalesAccCode { get; set; }
        [StringLength(10)]
        public string? SalesAnalysisCode { get; set; }
        [StringLength(1)]
        public string? SalesCostFlag { get; set; }
        [StringLength(15)]
        public string? SalesProvisionAccCode { get; set; }
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [StringLength(1)]
        public string? SplitByMethod { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
        [StringLength(10)]
        public string? VatCode { get; set; }
        [Column("WHoldTaxCode")]
        [StringLength(3)]
        public string? WholdTaxCode { get; set; }
        [Column("WHoldTaxDescription")]
        [StringLength(20)]
        public string? WholdTaxDescription { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }

        [InverseProperty("SalesItemCodeNavigation")]
        public virtual ICollection<Amdc1> Amdc1s { get; set; }
        [InverseProperty("SalesItemCodeNavigation")]
        public virtual ICollection<Amid2> Amid2s { get; set; }
        [InverseProperty("SalesItemCodeNavigation")]
        public virtual ICollection<Amio2> Amio2s { get; set; }
        [InverseProperty("ItemCodeNavigation")]
        public virtual ICollection<Ivch2> Ivch2s { get; set; }
        [InverseProperty("ItemCodeNavigation")]
        public virtual ICollection<Ivcr2> Ivcr2s { get; set; }
        [InverseProperty("ItemCodeNavigation")]
        public virtual ICollection<Sepi2> Sepi2s { get; set; }
        [InverseProperty("SalesItemCodeNavigation")]
        public virtual ICollection<Slaj1> Slaj1s { get; set; }
        [InverseProperty("SalesItemCodeNavigation")]
        public virtual ICollection<Smhq2> Smhq2s { get; set; }
        [InverseProperty("SalesItemCodeNavigation")]
        public virtual ICollection<Smht2> Smht2s { get; set; }
        [InverseProperty("SalesItemCodeNavigation")]
        public virtual ICollection<Smiq2> Smiq2s { get; set; }
        [InverseProperty("SalesItemCodeNavigation")]
        public virtual ICollection<Smit2> Smit2s { get; set; }
        [InverseProperty("BafItemCodeNavigation")]
        public virtual ICollection<Smpa1> Smpa1BafItemCodeNavigations { get; set; }
        [InverseProperty("DdcItemCodeNavigation")]
        public virtual ICollection<Smpa1> Smpa1DdcItemCodeNavigations { get; set; }
        [InverseProperty("ItemCodeNavigation")]
        public virtual ICollection<Ssjd1> Ssjd1s { get; set; }
        [InverseProperty("SalesItemCodeNavigation")]
        public virtual ICollection<Torc1> Torc1s { get; set; }
        [InverseProperty("SalesItemCodeNavigation")]
        public virtual ICollection<Whbt2> Whbt2s { get; set; }
    }
}
