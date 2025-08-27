using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwGlbl1Pl
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Acc Code")]
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column("Acc Description")]
        [StringLength(50)]
        public string? AccDescription { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Branch Code")]
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [Column("Department Code")]
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
        [Column("Financial Year")]
        [StringLength(4)]
        public string? FinancialYear { get; set; }
        [Column("Mth 00 Balance", TypeName = "decimal(22, 2)")]
        public decimal? Mth00Balance { get; set; }
        [Column("Mth 01 Balance", TypeName = "decimal(22, 2)")]
        public decimal? Mth01Balance { get; set; }
        [Column("Mth 02 Balance", TypeName = "decimal(22, 2)")]
        public decimal? Mth02Balance { get; set; }
        [Column("Mth 03 Balance", TypeName = "decimal(22, 2)")]
        public decimal? Mth03Balance { get; set; }
        [Column("Mth 04 Balance", TypeName = "decimal(22, 2)")]
        public decimal? Mth04Balance { get; set; }
        [Column("Mth 05 Balance", TypeName = "decimal(22, 2)")]
        public decimal? Mth05Balance { get; set; }
        [Column("Mth 06 Balance", TypeName = "decimal(22, 2)")]
        public decimal? Mth06Balance { get; set; }
        [Column("Mth 07 Balance", TypeName = "decimal(22, 2)")]
        public decimal? Mth07Balance { get; set; }
        [Column("Mth 08 Balance", TypeName = "decimal(22, 2)")]
        public decimal? Mth08Balance { get; set; }
        [Column("Mth 09 Balance", TypeName = "decimal(22, 2)")]
        public decimal? Mth09Balance { get; set; }
        [Column("Mth 10 Balance", TypeName = "decimal(22, 2)")]
        public decimal? Mth10Balance { get; set; }
        [Column("Mth 11 Balance", TypeName = "decimal(22, 2)")]
        public decimal? Mth11Balance { get; set; }
        [Column("Mth 12 Balance", TypeName = "decimal(22, 2)")]
        public decimal? Mth12Balance { get; set; }
        [Column("Mth 13 Balance", TypeName = "decimal(22, 2)")]
        public decimal? Mth13Balance { get; set; }
        [Column("Mth 14 Balance", TypeName = "decimal(22, 2)")]
        public decimal? Mth14Balance { get; set; }
        [Column("Mth 15 Balance", TypeName = "decimal(22, 2)")]
        public decimal? Mth15Balance { get; set; }
        [Column("Mth 16 Balance", TypeName = "decimal(22, 2)")]
        public decimal? Mth16Balance { get; set; }
        [Column("Mth 17 Balance", TypeName = "decimal(22, 2)")]
        public decimal? Mth17Balance { get; set; }
        [Column("Mth 18 Balance", TypeName = "decimal(22, 2)")]
        public decimal? Mth18Balance { get; set; }
        [Column("Mth 01 Budget", TypeName = "decimal(22, 2)")]
        public decimal? Mth01Budget { get; set; }
        [Column("Mth 02 Budget", TypeName = "decimal(22, 2)")]
        public decimal? Mth02Budget { get; set; }
        [Column("Mth 03 Budget", TypeName = "decimal(22, 2)")]
        public decimal? Mth03Budget { get; set; }
        [Column("Mth 04 Budget", TypeName = "decimal(22, 2)")]
        public decimal? Mth04Budget { get; set; }
        [Column("Mth 05 Budget", TypeName = "decimal(22, 2)")]
        public decimal? Mth05Budget { get; set; }
        [Column("Mth 06 Budget", TypeName = "decimal(22, 2)")]
        public decimal? Mth06Budget { get; set; }
        [Column("Mth 07 Budget", TypeName = "decimal(22, 2)")]
        public decimal? Mth07Budget { get; set; }
        [Column("Mth 08 Budget", TypeName = "decimal(22, 2)")]
        public decimal? Mth08Budget { get; set; }
        [Column("Mth 09 Budget", TypeName = "decimal(22, 2)")]
        public decimal? Mth09Budget { get; set; }
        [Column("Mth 10 Budget", TypeName = "decimal(22, 2)")]
        public decimal? Mth10Budget { get; set; }
        [Column("Mth 11 Budget", TypeName = "decimal(22, 2)")]
        public decimal? Mth11Budget { get; set; }
        [Column("Mth 12 Budget", TypeName = "decimal(22, 2)")]
        public decimal? Mth12Budget { get; set; }
        [Column("Mth 13 Budget", TypeName = "decimal(22, 2)")]
        public decimal? Mth13Budget { get; set; }
        [Column("Mth 14 Budget", TypeName = "decimal(22, 2)")]
        public decimal? Mth14Budget { get; set; }
        [Column("Mth 15 Budget", TypeName = "decimal(22, 2)")]
        public decimal? Mth15Budget { get; set; }
        [Column("Mth 16 Budget", TypeName = "decimal(22, 2)")]
        public decimal? Mth16Budget { get; set; }
        [Column("Mth 17 Budget", TypeName = "decimal(22, 2)")]
        public decimal? Mth17Budget { get; set; }
        [Column("Mth 18 Budget", TypeName = "decimal(22, 2)")]
        public decimal? Mth18Budget { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string CreatedBy { get; set; } = null!;
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string UpdatedBy { get; set; } = null!;
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
