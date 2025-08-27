using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTjms1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Approved Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ApprovedDate { get; set; }
        [Column("Approved Flag")]
        [StringLength(2)]
        public string? ApprovedFlag { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Permit No")]
        [StringLength(8)]
        public string PermitNo { get; set; } = null!;
        [StringLength(255)]
        public string? Remark { get; set; }
    }
}
