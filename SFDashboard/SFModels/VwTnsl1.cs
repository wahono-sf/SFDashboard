using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTnsl1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Seq No")]
        public int? SeqNo { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Submit Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? SubmitDateTime { get; set; }
        [Column("Submit File Name")]
        [StringLength(255)]
        public string? SubmitFileName { get; set; }
        [Column("Submit User")]
        [StringLength(50)]
        public string? SubmitUser { get; set; }
        [Column("Tn Table Name")]
        [StringLength(10)]
        public string? TnTableName { get; set; }
        [Column("Tn Trx No")]
        public int? TnTrxNo { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
        [Column("Created By")]
        [StringLength(50)]
        public string CreatedBy { get; set; } = null!;
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string UpdatedBy { get; set; } = null!;
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
    }
}
