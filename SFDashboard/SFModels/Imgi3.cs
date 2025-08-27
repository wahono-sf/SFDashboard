using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("imgi3")]
    [Index("PackingNo", Name = "INDEX_Imgi3_PackingNo")]
    [Index("ProductTrxNo", Name = "INDEX_Imgi3_ProductTrxNo")]
    public partial class Imgi3
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(80)]
        public string? Dimension { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Height { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Length { get; set; }
        public int? LooseQty { get; set; }
        [StringLength(50)]
        public string? LooseUomCode { get; set; }
        [StringLength(25)]
        public string? PackingNo { get; set; }
        public int? PackingQty { get; set; }
        [StringLength(50)]
        public string? PackingUomCode { get; set; }
        [StringLength(255)]
        public string? ProductDescription { get; set; }
        public int? ProductTrxNo { get; set; }
        [StringLength(255)]
        public string? UserDefine1 { get; set; }
        [StringLength(255)]
        public string? UserDefine2 { get; set; }
        [StringLength(255)]
        public string? UserDefine3 { get; set; }
        [Column(TypeName = "decimal(15, 6)")]
        public decimal? Volume { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }
        public int? WholePackageSize { get; set; }
        public int? WholeQty { get; set; }
        [StringLength(50)]
        public string? WholeUomCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Width { get; set; }
    }
}
