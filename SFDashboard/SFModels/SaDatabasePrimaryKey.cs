using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class SaDatabasePrimaryKey
    {
        [Column("CONSTRAINT_CATALOG")]
        [StringLength(128)]
        public string? ConstraintCatalog { get; set; }
        [Column("CONSTRAINT_SCHEMA")]
        [StringLength(128)]
        public string? ConstraintSchema { get; set; }
        [Column("CONSTRAINT_NAME")]
        [StringLength(128)]
        public string ConstraintName { get; set; } = null!;
        [Column("TABLE_CATALOG")]
        [StringLength(128)]
        public string? TableCatalog { get; set; }
        [Column("TABLE_SCHEMA")]
        [StringLength(128)]
        public string? TableSchema { get; set; }
        [Column("TABLE_NAME")]
        [StringLength(128)]
        public string TableName { get; set; } = null!;
        [Column("COLUMN_NAME")]
        [StringLength(128)]
        public string ColumnName { get; set; } = null!;
        [Column("ORDINAL_POSITION")]
        public int? OrdinalPosition { get; set; }
        [Column("Column Name")]
        [StringLength(30)]
        public string? ColumnName1 { get; set; }
        [Column("Table ID")]
        [StringLength(30)]
        public string? TableId { get; set; }
    }
}
