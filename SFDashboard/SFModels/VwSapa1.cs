using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSapa1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public int? LineItemNo { get; set; }
        [Column("Ref No")]
        [StringLength(101)]
        public string? RefNo { get; set; }
        [Column("Primary Key Name")]
        [StringLength(50)]
        public string? PrimaryKeyName { get; set; }
        [Column("Primary Key Value")]
        [StringLength(50)]
        public string? PrimaryKeyValue { get; set; }
        [Column("Printed By")]
        [StringLength(50)]
        public string? PrintedBy { get; set; }
        [Column("Printed At")]
        [StringLength(19)]
        [Unicode(false)]
        public string? PrintedAt { get; set; }
        [Column("Print Selection")]
        [StringLength(1)]
        public string? PrintSelection { get; set; }
        [Column("Print Type")]
        [StringLength(20)]
        public string? PrintType { get; set; }
        [Column("Report Name")]
        [StringLength(200)]
        public string? ReportName { get; set; }
        [Column("Selection Log")]
        [StringLength(1000)]
        public string? SelectionLog { get; set; }
        [Column("Table Name")]
        [StringLength(50)]
        public string? TableName { get; set; }
        [StringLength(50)]
        public string? Workstation { get; set; }
    }
}
