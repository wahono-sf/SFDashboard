using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSatb1
    {
        [Column("Table ID")]
        [StringLength(50)]
        public string TableId { get; set; } = null!;
        [Column("Old Table ID")]
        [StringLength(50)]
        public string? OldTableId { get; set; }
        [Column("Table Code")]
        [StringLength(2)]
        public string? TableCode { get; set; }
        [Column("Table Name")]
        [StringLength(50)]
        public string? TableName { get; set; }
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
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
