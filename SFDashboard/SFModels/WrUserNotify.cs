using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("wrUserNotify")]
    public partial class WrUserNotify
    {
        [Key]
        [Column("UserID")]
        [StringLength(20)]
        public string UserId { get; set; } = null!;
        [Key]
        [Column(TypeName = "datetime")]
        public DateTime DateTime { get; set; }
        [StringLength(50)]
        public string FileName { get; set; } = null!;
        [StringLength(2000)]
        public string? FileText { get; set; }
        [StringLength(1)]
        public string? Displaywhenlogonon { get; set; }
    }
}
