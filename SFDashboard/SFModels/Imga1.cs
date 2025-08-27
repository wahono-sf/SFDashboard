using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("imga1")]
    [Index("AdjustDateTime", Name = "INDEX_Imga1_AdjustDateTime")]
    [Index("CustomerCode", Name = "INDEX_Imga1_CustomerCode")]
    [Index("GoodsAdjustmentNoteNo", Name = "INDEX_Imga1_GoodsAdjustmentNoteNo")]
    [Index("RefNo", Name = "INDEX_Imga1_RefNo")]
    public partial class Imga1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(50)]
        public string? AdjustBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AdjustDateTime { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(50)]
        public string? Description1 { get; set; }
        [StringLength(50)]
        public string? Description2 { get; set; }
        public int? EdiCount { get; set; }
        [StringLength(11)]
        public string GoodsAdjustmentNoteNo { get; set; } = null!;
        [StringLength(50)]
        public string? RefNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
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
