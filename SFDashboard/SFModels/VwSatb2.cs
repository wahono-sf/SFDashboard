using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSatb2
    {
        [Column("Table I D")]
        [StringLength(5)]
        public string TableID { get; set; } = null!;
        [Column("Field Name")]
        [StringLength(50)]
        public string FieldName { get; set; } = null!;
        [Column("Audit Flag")]
        [StringLength(1)]
        public string? AuditFlag { get; set; }
        [Column("Auto Generate")]
        [StringLength(50)]
        public string? AutoGenerate { get; set; }
        [StringLength(50)]
        public string? Component { get; set; }
        [Column("Data Type")]
        [StringLength(30)]
        public string? DataType { get; set; }
        [Column("Default Flag")]
        [StringLength(1)]
        public string? DefaultFlag { get; set; }
        [Column("Default Value")]
        [StringLength(255)]
        public string? DefaultValue { get; set; }
        [Column("Display Flag")]
        [StringLength(1)]
        public string? DisplayFlag { get; set; }
        [Column("Display Length")]
        [StringLength(50)]
        public string? DisplayLength { get; set; }
        [Column("Form Seq No")]
        public short? FormSeqNo { get; set; }
        [Column("Label Name")]
        [StringLength(50)]
        public string? LabelName { get; set; }
        public short? Length { get; set; }
        [Column("Lock Flag")]
        [StringLength(1)]
        public string? LockFlag { get; set; }
        [Column("Mandatory Flag")]
        [StringLength(1)]
        public string? MandatoryFlag { get; set; }
        [Column("Max Length")]
        public short? MaxLength { get; set; }
        [Column("Null Flag")]
        [StringLength(1)]
        public string? NullFlag { get; set; }
        [Column("Numeric Precision")]
        public byte? NumericPrecision { get; set; }
        [Column("Numeric Scale")]
        public byte? NumericScale { get; set; }
        [Column("Old Field Name")]
        [StringLength(50)]
        public string? OldFieldName { get; set; }
        public short? Position { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Search Flag")]
        [StringLength(1)]
        public string? SearchFlag { get; set; }
        [Column("Search Return Column")]
        [StringLength(255)]
        public string? SearchReturnColumn { get; set; }
        [Column("Search Table Column")]
        [StringLength(255)]
        public string? SearchTableColumn { get; set; }
        [Column("Search Table I D")]
        [StringLength(5)]
        public string? SearchTableID { get; set; }
        [Column("Search Table Key")]
        [StringLength(255)]
        public string? SearchTableKey { get; set; }
        [Column("Tool Tip")]
        [StringLength(255)]
        public string? ToolTip { get; set; }
        [Column("Validity Flag")]
        [StringLength(1)]
        public string? ValidityFlag { get; set; }
        [Column("Valid Value")]
        [StringLength(255)]
        public string? ValidValue { get; set; }
        [Column("Visible Flag")]
        [StringLength(1)]
        public string? VisibleFlag { get; set; }
        [Column("Create By")]
        [StringLength(50)]
        public string? CreateBy { get; set; }
        [Column("Create At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreateAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string? UpdatedBy { get; set; }
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
    }
}
