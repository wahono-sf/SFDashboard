using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwGlch2
    {
        [Column("Acc Code")]
        [StringLength(15)]
        public string AccCode { get; set; } = null!;
        [Column("Financial Year")]
        public short FinancialYear { get; set; }
        [Column("Mth 01 Budget", TypeName = "numeric(13, 2)")]
        public decimal? Mth01Budget { get; set; }
        [Column("Mth 02 Budget", TypeName = "numeric(13, 2)")]
        public decimal? Mth02Budget { get; set; }
        [Column("Mth 03 Budget", TypeName = "numeric(13, 2)")]
        public decimal? Mth03Budget { get; set; }
        [Column("Mth 04 Budget", TypeName = "numeric(13, 2)")]
        public decimal? Mth04Budget { get; set; }
        [Column("Mth 05 Budget", TypeName = "numeric(13, 2)")]
        public decimal? Mth05Budget { get; set; }
        [Column("Mth 06 Budget", TypeName = "numeric(13, 2)")]
        public decimal? Mth06Budget { get; set; }
        [Column("Mth 07 Budget", TypeName = "numeric(13, 2)")]
        public decimal? Mth07Budget { get; set; }
        [Column("Mth 08 Budget", TypeName = "numeric(13, 2)")]
        public decimal? Mth08Budget { get; set; }
        [Column("Mth 09 Budget", TypeName = "numeric(13, 2)")]
        public decimal? Mth09Budget { get; set; }
        [Column("Mth 10 Budget", TypeName = "numeric(13, 2)")]
        public decimal? Mth10Budget { get; set; }
        [Column("Mth 11 Budget", TypeName = "numeric(13, 2)")]
        public decimal? Mth11Budget { get; set; }
        [Column("Mth 12 Budget", TypeName = "numeric(13, 2)")]
        public decimal? Mth12Budget { get; set; }
        [Column("Mth 13 Budget", TypeName = "numeric(13, 2)")]
        public decimal? Mth13Budget { get; set; }
        [Column("Mth 14 Budget", TypeName = "numeric(13, 2)")]
        public decimal? Mth14Budget { get; set; }
        [Column("Mth 15 Budget", TypeName = "numeric(13, 2)")]
        public decimal? Mth15Budget { get; set; }
        [Column("Mth 16 Budget", TypeName = "numeric(13, 2)")]
        public decimal? Mth16Budget { get; set; }
        [Column("Mth 17 Budget", TypeName = "numeric(13, 2)")]
        public decimal? Mth17Budget { get; set; }
        [Column("Mth 18 Budget", TypeName = "numeric(13, 2)")]
        public decimal? Mth18Budget { get; set; }
    }
}
