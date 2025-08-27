using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("saal1")]
    [Index("TableName", Name = "INDEX_Saal1_TableName")]
    [Index("PrimaryKeyName", Name = "IX_saal1_1")]
    [Index("TableName", "LineItemNo", Name = "IX_saal1_2")]
    [Index("UpdateBy", Name = "IX_saal1_3")]
    [Index("UpdateDateTime", Name = "IX_saal1_4")]
    public partial class Saal1
    {
        [Key]
        public int TrxNo { get; set; }
        public int LineItemNo { get; set; }
        [StringLength(10)]
        public string TableName { get; set; } = null!;
        [StringLength(50)]
        public string? FieldName { get; set; }
        [StringLength(1)]
        public string? InternalFlag { get; set; }
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [StringLength(255)]
        public string? NewValue { get; set; }
        [StringLength(255)]
        public string? OldValue { get; set; }
        public int? PrimaryKeyLineItemNo { get; set; }
        [StringLength(50)]
        public string? PrimaryKeyName { get; set; }
        [StringLength(50)]
        public string? PrimaryKeyValue { get; set; }
        public int? QuoteLineItemNo { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
    }
}
