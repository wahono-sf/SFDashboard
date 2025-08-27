using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSarl1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public int? LineItemNo { get; set; }
        [Column("Table Name")]
        [StringLength(10)]
        public string TableName { get; set; } = null!;
        [Column("Primary Key Name")]
        [StringLength(50)]
        public string? PrimaryKeyName { get; set; }
        [Column("Primary Key Value")]
        [StringLength(50)]
        public string? PrimaryKeyValue { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string? WorkStation { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string CreatedBy { get; set; } = null!;
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
    }
}
