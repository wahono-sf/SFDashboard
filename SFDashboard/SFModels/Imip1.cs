using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("imip1")]
    public partial class Imip1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(24)]
        public string? InProductCode { get; set; }
        public int? InQty { get; set; }
        public int? InQty1 { get; set; }
        [StringLength(6)]
        public string? InWarehouseCode { get; set; }
        [StringLength(24)]
        public string? OutProductCode { get; set; }
        public int? OutQty { get; set; }
        public int? OutQty1 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? OutSpace { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? OutVolume { get; set; }
        [StringLength(6)]
        public string? OutWarehouseCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? OutWeight { get; set; }
        [StringLength(6)]
        public string? ReferenceNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TransferDate { get; set; }
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
