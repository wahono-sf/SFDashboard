using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("jmrk1")]
    public partial class Jmrk1
    {
        [StringLength(30)]
        public string JobNo { get; set; } = null!;
        public int LineItemNo { get; set; }
        [StringLength(1)]
        public string? RemarkIndicator { get; set; }
        [StringLength(500)]
        public string? Remark { get; set; }
        [StringLength(50)]
        public string? CreateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDateTime { get; set; }
        [StringLength(50)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDateTime { get; set; }
    }
}
