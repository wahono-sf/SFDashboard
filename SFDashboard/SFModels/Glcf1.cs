using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("glcf1")]
    public partial class Glcf1
    {
        [Key]
        [StringLength(15)]
        public string CashFlowAnalysisCode { get; set; } = null!;
        [StringLength(1)]
        public string? BoldFlag { get; set; }
        [StringLength(50)]
        public string? CashFlowAnalysisName { get; set; }
        [StringLength(1)]
        public string? DepreciationFlag { get; set; }
        [StringLength(1)]
        public string? HideGroupFlag { get; set; }
        [StringLength(1)]
        public string? ReverseSignFlag { get; set; }
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
