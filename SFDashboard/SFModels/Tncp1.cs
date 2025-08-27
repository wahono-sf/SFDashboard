using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("tncp1")]
    public partial class Tncp1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(35)]
        public string? ProductCode { get; set; }
        [StringLength(4000)]
        public string? Description1 { get; set; }
        [StringLength(35)]
        public string? Description2 { get; set; }
        [StringLength(35)]
        public string? Description3 { get; set; }
        [StringLength(35)]
        public string? Description4 { get; set; }
        [StringLength(35)]
        public string? Description5 { get; set; }
        [Column("HSCode")]
        [StringLength(8)]
        public string? Hscode { get; set; }
        [StringLength(50)]
        public string? ReferenceId { get; set; }
        [StringLength(3)]
        public string? UnitCode { get; set; }
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
