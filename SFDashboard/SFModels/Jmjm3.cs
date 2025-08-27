using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmjm3")]
    [Index("StatusCode", Name = "INDEX_Jmjm3_StatusCode")]
    public partial class Jmjm3
    {
        [Key]
        [StringLength(30)]
        public string JobNo { get; set; } = null!;
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(1)]
        public string? AllowSkipFlag { get; set; }
        [StringLength(1)]
        public string? AutoFlag { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateTime { get; set; }
        [StringLength(255)]
        public string? Description { get; set; }
        public int? EdiCount { get; set; }
        public int? EmailCount { get; set; }
        [StringLength(10)]
        public string? EventCode { get; set; }
        [StringLength(50)]
        public string? RefNo { get; set; }
        [StringLength(80)]
        public string? Remark { get; set; }
        [Column("ShowETrackFlag")]
        [StringLength(1)]
        public string? ShowEtrackFlag { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDateTime { get; set; }
        [StringLength(10)]
        public string? StatusCode { get; set; }
        [StringLength(50)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDateTime { get; set; }
    }
}
