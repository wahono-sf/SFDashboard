using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSaal1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Table Name")]
        [StringLength(10)]
        public string TableName { get; set; } = null!;
        [Column("Field Name")]
        [StringLength(50)]
        public string? FieldName { get; set; }
        [Column("Internal Flag")]
        [StringLength(1)]
        public string? InternalFlag { get; set; }
        [Column("Item Code")]
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [Column("New Value")]
        [StringLength(255)]
        public string? NewValue { get; set; }
        [Column("Old Value")]
        [StringLength(255)]
        public string? OldValue { get; set; }
        [Column("Primary Key Line Item No")]
        public int? PrimaryKeyLineItemNo { get; set; }
        [Column("Primary Key Name")]
        [StringLength(50)]
        public string? PrimaryKeyName { get; set; }
        [Column("Primary Key Value")]
        [StringLength(50)]
        public string? PrimaryKeyValue { get; set; }
        [Column("Primary Key Int")]
        public long? PrimaryKeyInt { get; set; }
        [Column("Quote Line Item No")]
        public int? QuoteLineItemNo { get; set; }
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
