using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("imia1")]
    public partial class Imia1
    {
        [Key]
        public int TrxNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AdjustDate { get; set; }
        [StringLength(12)]
        public string? BatchNo { get; set; }
        [StringLength(10)]
        public string CustomerCode { get; set; } = null!;
        public int? LooseQty { get; set; }
        [StringLength(1)]
        public string? PostFlag { get; set; }
        [StringLength(24)]
        public string ProductCode { get; set; } = null!;
        [StringLength(20)]
        public string? RefNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? SpaceArea { get; set; }
        [StringLength(50)]
        public string? StoreLocation { get; set; }
        [StringLength(14)]
        public string? StoreNo { get; set; }
        [StringLength(1)]
        public string? TrxType { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }
        public int? WholeQty { get; set; }
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
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
