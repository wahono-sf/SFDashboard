using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("glbl1")]
    [Index("AccCode", Name = "INDEX_Glbl1_AccCode")]
    [Index("FinancialYear", Name = "INDEX_Glbl1_FinancialYear")]
    [Index("FinancialYear", "AccCode", Name = "INDEX_Glbl1_FinancialYear_AccCode")]
    public partial class Glbl1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(4)]
        public string? FinancialYear { get; set; }
        [StringLength(15)]
        public string? AccCode { get; set; }
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth00Balance { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth01Balance { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth02Balance { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth03Balance { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth04Balance { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth05Balance { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth06Balance { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth07Balance { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth08Balance { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth09Balance { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth10Balance { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth11Balance { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth12Balance { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth13Balance { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth14Balance { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth15Balance { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth16Balance { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth17Balance { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth18Balance { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth01Budget { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth02Budget { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth03Budget { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth04Budget { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth05Budget { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth06Budget { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth07Budget { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth08Budget { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth09Budget { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth10Budget { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth11Budget { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth12Budget { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth13Budget { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth14Budget { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth15Budget { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth16Budget { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth17Budget { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Mth18Budget { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
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
    }
}
