using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("tnhs1")]
    public partial class Tnhs1
    {
        [Key]
        [StringLength(8)]
        public string HsCode { get; set; } = null!;
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CustomDutyRate { get; set; }
        [StringLength(50)]
        public string? CustomDutyUomCode { get; set; }
        [StringLength(255)]
        public string? Description { get; set; }
        [StringLength(300)]
        public string? DutyRateDescription { get; set; }
        [StringLength(1)]
        public string? DutyType { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ExciseDutyRate { get; set; }
        [StringLength(50)]
        public string? ExciseDutyUomCode { get; set; }
        [StringLength(1)]
        public string? ExportInd { get; set; }
        [StringLength(1)]
        public string? HsType { get; set; }
        [StringLength(1)]
        public string? ImportInd { get; set; }
        [StringLength(1)]
        public string? TransInd { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
        [StringLength(3)]
        public string Statuscode { get; set; } = null!;
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
