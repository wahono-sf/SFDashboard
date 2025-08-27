using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("satb2")]
    public partial class Satb2
    {
        [Key]
        [Column("TableID")]
        [StringLength(5)]
        public string TableId { get; set; } = null!;
        [Key]
        [StringLength(50)]
        public string FieldName { get; set; } = null!;
        [StringLength(1)]
        public string? AuditFlag { get; set; }
        [StringLength(50)]
        public string? AutoGenerate { get; set; }
        [StringLength(50)]
        public string? Component { get; set; }
        [StringLength(30)]
        public string? DataType { get; set; }
        [StringLength(1)]
        public string? DefaultFlag { get; set; }
        [StringLength(255)]
        public string? DefaultValue { get; set; }
        [StringLength(1)]
        public string? DisplayFlag { get; set; }
        [StringLength(50)]
        public string? DisplayLength { get; set; }
        public short? FormSeqNo { get; set; }
        [StringLength(50)]
        public string? LabelName { get; set; }
        public short? Length { get; set; }
        [StringLength(1)]
        public string? LockFlag { get; set; }
        [StringLength(1)]
        public string? MandatoryFlag { get; set; }
        public short? MaxLength { get; set; }
        [StringLength(1)]
        public string? NullFlag { get; set; }
        public byte? NumericPrecision { get; set; }
        public byte? NumericScale { get; set; }
        [StringLength(50)]
        public string? OldFieldName { get; set; }
        public short? Position { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(1)]
        public string? SearchFlag { get; set; }
        [StringLength(255)]
        public string? SearchReturnColumn { get; set; }
        [StringLength(255)]
        public string? SearchTableColumn { get; set; }
        [Column("SearchTableID")]
        [StringLength(5)]
        public string? SearchTableId { get; set; }
        [StringLength(255)]
        public string? SearchTableKey { get; set; }
        [StringLength(255)]
        public string? ToolTip { get; set; }
        [StringLength(1)]
        public string? ValidityFlag { get; set; }
        [StringLength(255)]
        public string? ValidValue { get; set; }
        [StringLength(1)]
        public string? VisibleFlag { get; set; }
        [StringLength(50)]
        public string? CreateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDateTime { get; set; }
        [StringLength(50)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDateTime { get; set; }
    }
}
