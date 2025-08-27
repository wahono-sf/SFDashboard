using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sael1")]
    [Index("TableName", "PrimaryKeyName", "PrimaryKeyValue", Name = "INDEX__sael1_PrimaryKey")]
    [Index("TableName", Name = "INDEX__sael1_TableName")]
    public partial class Sael1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(1)]
        public string? AllowSkipFlag { get; set; }
        [StringLength(1)]
        public string? AutoFlag { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateTime { get; set; }
        [StringLength(255)]
        public string? Description { get; set; }
        public int? EmailCount { get; set; }
        [StringLength(10)]
        public string? EventCode { get; set; }
        public int? LineItemNo { get; set; }
        [StringLength(50)]
        public string? PrimaryKeyName { get; set; }
        [StringLength(50)]
        public string? PrimaryKeyValue { get; set; }
        [StringLength(50)]
        public string? RefNo { get; set; }
        [StringLength(80)]
        public string? Remark { get; set; }
        [Column("ShowETrackFlag")]
        [StringLength(1)]
        public string? ShowEtrackFlag { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDateTime { get; set; }
        [StringLength(10)]
        public string? TableName { get; set; }
        [StringLength(50)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDateTime { get; set; }
        [StringLength(10)]
        public string? StatusCode { get; set; }
    }
}
