using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("ancf1")]
    public partial class Ancf1
    {
        [Key]
        [StringLength(1)]
        public string AwbCode { get; set; } = null!;
        [StringLength(50)]
        public string? AwbName { get; set; }
        [StringLength(1)]
        public string? CheckDigit { get; set; }
        public int? LastYrAwbUse { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYrReceiveDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastYrUseDate { get; set; }
        public int? MtdAwbUse { get; set; }
        public int? QtyOnHand { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        public int? ReOrderQty { get; set; }
        public int? YtdAwbUse { get; set; }
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
