using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("rcsp1")]
    [Index("PortName", Name = "INDEX_Rcsp1_PortName")]
    [Index("StatusCode", Name = "INDEX_Rcsp1_StatusCode")]
    public partial class Rcsp1
    {
        [Key]
        [StringLength(5)]
        public string PortCode { get; set; } = null!;
        [StringLength(45)]
        public string? PortName { get; set; }
        public int? CombineFreeDay { get; set; }
        [StringLength(2)]
        public string? CountryCode { get; set; }
        public int? DemurrageFreeDay { get; set; }
        public int? DetentionFreeDay { get; set; }
        [StringLength(1)]
        public string? DgCargoFlag { get; set; }
        [StringLength(50)]
        public string? GroupCode { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(10)]
        public string? Symbol { get; set; }
        [StringLength(5)]
        public string? ViaPort { get; set; }
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
