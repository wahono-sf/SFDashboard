using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwGlbt1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Database Name")]
        [StringLength(50)]
        public string? DatabaseName { get; set; }
        [Column("Login ID")]
        [StringLength(50)]
        public string? LoginId { get; set; }
        [Column("New Table Name")]
        [StringLength(50)]
        public string? NewTableName { get; set; }
        [StringLength(50)]
        public string? Password { get; set; }
        [StringLength(80)]
        public string? Remark { get; set; }
        [Column("Table Name")]
        [StringLength(50)]
        public string? TableName { get; set; }
        [StringLength(80)]
        public string? Website { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
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
