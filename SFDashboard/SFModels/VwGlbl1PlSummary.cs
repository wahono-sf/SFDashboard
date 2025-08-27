using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwGlbl1PlSummary
    {
        [Column("Financial Year")]
        [StringLength(4)]
        public string? FinancialYear { get; set; }
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [Column("Department Code")]
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
        [Column("Mth 00 Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth00Balance { get; set; }
        [Column("Mth 01 Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth01Balance { get; set; }
        [Column("Mth 02 Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth02Balance { get; set; }
        [Column("Mth 03 Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth03Balance { get; set; }
        [Column("Mth 04 Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth04Balance { get; set; }
        [Column("Mth 05 Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth05Balance { get; set; }
        [Column("Mth 06 Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth06Balance { get; set; }
        [Column("Mth 07 Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth07Balance { get; set; }
        [Column("Mth 08 Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth08Balance { get; set; }
        [Column("Mth 09 Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth09Balance { get; set; }
        [Column("Mth 10 Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth10Balance { get; set; }
        [Column("Mth 11 Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth11Balance { get; set; }
        [Column("Mth 12 Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth12Balance { get; set; }
        [Column("Mth 13 Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth13Balance { get; set; }
        [Column("Mth 14 Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth14Balance { get; set; }
        [Column("Mth 15 Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth15Balance { get; set; }
        [Column("Mth 16 Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth16Balance { get; set; }
        [Column("Mth 17 Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth17Balance { get; set; }
        [Column("Mth 18 Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth18Balance { get; set; }
    }
}
