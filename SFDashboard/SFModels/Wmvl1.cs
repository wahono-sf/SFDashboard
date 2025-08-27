using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("wmvl1")]
    public partial class Wmvl1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(10)]
        public string Code { get; set; } = null!;
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [StringLength(20)]
        public string? Type { get; set; }
        public int? SortOrder { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
    }
}
