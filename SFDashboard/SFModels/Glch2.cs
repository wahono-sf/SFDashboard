using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("glch2")]
    public partial class Glch2
    {
        [Key]
        [StringLength(15)]
        public string AccCode { get; set; } = null!;
        [Key]
        public short FinancialYear { get; set; }
        [Column(TypeName = "numeric(13, 2)")]
        public decimal? Mth01Budget { get; set; }
        [Column(TypeName = "numeric(13, 2)")]
        public decimal? Mth02Budget { get; set; }
        [Column(TypeName = "numeric(13, 2)")]
        public decimal? Mth03Budget { get; set; }
        [Column(TypeName = "numeric(13, 2)")]
        public decimal? Mth04Budget { get; set; }
        [Column(TypeName = "numeric(13, 2)")]
        public decimal? Mth05Budget { get; set; }
        [Column(TypeName = "numeric(13, 2)")]
        public decimal? Mth06Budget { get; set; }
        [Column(TypeName = "numeric(13, 2)")]
        public decimal? Mth07Budget { get; set; }
        [Column(TypeName = "numeric(13, 2)")]
        public decimal? Mth08Budget { get; set; }
        [Column(TypeName = "numeric(13, 2)")]
        public decimal? Mth09Budget { get; set; }
        [Column(TypeName = "numeric(13, 2)")]
        public decimal? Mth10Budget { get; set; }
        [Column(TypeName = "numeric(13, 2)")]
        public decimal? Mth11Budget { get; set; }
        [Column(TypeName = "numeric(13, 2)")]
        public decimal? Mth12Budget { get; set; }
        [Column(TypeName = "numeric(13, 2)")]
        public decimal? Mth13Budget { get; set; }
        [Column(TypeName = "numeric(13, 2)")]
        public decimal? Mth14Budget { get; set; }
        [Column(TypeName = "numeric(13, 2)")]
        public decimal? Mth15Budget { get; set; }
        [Column(TypeName = "numeric(13, 2)")]
        public decimal? Mth16Budget { get; set; }
        [Column(TypeName = "numeric(13, 2)")]
        public decimal? Mth17Budget { get; set; }
        [Column(TypeName = "numeric(13, 2)")]
        public decimal? Mth18Budget { get; set; }
    }
}
