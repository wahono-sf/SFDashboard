using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("imsl1")]
    public partial class Imsl1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(50)]
        public string DocNo { get; set; } = null!;
        [StringLength(2)]
        public string? DocType { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StatusLogDateTime { get; set; }
        [StringLength(50)]
        public string? UserId { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
    }
}
