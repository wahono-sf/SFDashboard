using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSarm1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Table Name")]
        [StringLength(20)]
        public string? TableName { get; set; }
        [Column("Field Name")]
        [StringLength(50)]
        public string? FieldName { get; set; }
        [Column("Field Name Int")]
        public long? FieldNameInt { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string CreatedBy { get; set; } = null!;
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
    }
}
