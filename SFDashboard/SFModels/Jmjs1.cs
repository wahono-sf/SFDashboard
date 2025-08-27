using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmjs1")]
    [Index("StatusCode", Name = "INDEX_Jmjs1_StatusCode")]
    public partial class Jmjs1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(10)]
        public string JobStatusCode { get; set; } = null!;
        [StringLength(10)]
        public string? JobType { get; set; }
        [StringLength(50)]
        public string? JobDescription { get; set; }
        [StringLength(2)]
        public string? ModuleCode { get; set; }
        [StringLength(20)]
        public string? Bcolor { get; set; }
        [Column("Bcolor_A")]
        public int? BcolorA { get; set; }
        [Column("Bcolor_B")]
        public int? BcolorB { get; set; }
        [Column("Bcolor_G")]
        public int? BcolorG { get; set; }
        [Column("Bcolor_R")]
        public int? BcolorR { get; set; }
        public int? JobTrackOrder { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
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
