using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("GridSet")]
    public partial class GridSet
    {
        [Column("sTableName")]
        [StringLength(50)]
        public string STableName { get; set; } = null!;
        [Column("sFieldName")]
        [StringLength(50)]
        public string? SFieldName { get; set; }
        [Column("sSortField")]
        [StringLength(50)]
        public string? SSortField { get; set; }
        [Column("sFieldType")]
        [StringLength(20)]
        public string? SFieldType { get; set; }
        [Column("bSetting")]
        public bool? BSetting { get; set; }
        [Column("bFieldVisible")]
        public bool? BFieldVisible { get; set; }
        [Column("lFieldOrder")]
        public int? LFieldOrder { get; set; }
        [Column("lFieldWidth", TypeName = "decimal(6, 2)")]
        public decimal? LFieldWidth { get; set; }
        [Column("sChineseTitle")]
        [StringLength(100)]
        public string? SChineseTitle { get; set; }
        [Column("sEnglishTitle")]
        [StringLength(100)]
        public string? SEnglishTitle { get; set; }
        [Column("sChineseFormat")]
        [StringLength(50)]
        public string? SChineseFormat { get; set; }
        [Column("sEnglishFormat")]
        [StringLength(50)]
        public string? SEnglishFormat { get; set; }
        [Column("sHeaderImageUrl")]
        [StringLength(100)]
        public string? SHeaderImageUrl { get; set; }
        [Column("bFieldVisibleByUser")]
        public bool? BFieldVisibleByUser { get; set; }
    }
}
