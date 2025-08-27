using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTnem1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Description 1")]
        [StringLength(4000)]
        public string? Description1 { get; set; }
        [Column("Description 2")]
        [StringLength(70)]
        public string? Description2 { get; set; }
        [Column("Description 3")]
        [StringLength(70)]
        public string? Description3 { get; set; }
        [Column("Description 4")]
        [StringLength(70)]
        public string? Description4 { get; set; }
        [Column("Description 5")]
        [StringLength(70)]
        public string? Description5 { get; set; }
        [Column("Error Code 1")]
        [StringLength(20)]
        public string? ErrorCode1 { get; set; }
        [Column("Error Code 2")]
        [StringLength(20)]
        public string? ErrorCode2 { get; set; }
        [Column("Error Code 3")]
        [StringLength(20)]
        public string? ErrorCode3 { get; set; }
        [Column("Error Code 4")]
        [StringLength(20)]
        public string? ErrorCode4 { get; set; }
        [Column("Error Code 5")]
        [StringLength(20)]
        public string? ErrorCode5 { get; set; }
        [Column("File Name")]
        [StringLength(70)]
        public string? FileName { get; set; }
        [StringLength(20)]
        public string? Msg { get; set; }
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
