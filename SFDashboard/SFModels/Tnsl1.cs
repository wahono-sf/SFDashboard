using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("tnsl1")]
    public partial class Tnsl1
    {
        [Key]
        public int TrxNo { get; set; }
        public int? SeqNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SubmitDateTime { get; set; }
        [StringLength(255)]
        public string? SubmitFileName { get; set; }
        [StringLength(50)]
        public string? SubmitUser { get; set; }
        [StringLength(10)]
        public string? TnTableName { get; set; }
        public int? TnTrxNo { get; set; }
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
