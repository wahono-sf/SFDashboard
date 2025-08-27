using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("tjms1")]
    public partial class Tjms1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(8)]
        public string PermitNo { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? ApprovedDate { get; set; }
        [StringLength(2)]
        public string? ApprovedFlag { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
    }
}
