using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sapa1")]
    [Index("PrintDateTime", Name = "INDEX_sapa1_Date")]
    [Index("TableName", "PrimaryKeyName", "PrimaryKeyValue", Name = "INDEX_sapa1_PrimaryKeyName")]
    [Index("PrintBy", Name = "INDEX_sapa1_PrintBy")]
    [Index("PrintSelection", Name = "INDEX_sapa1_PrintSelection")]
    [Index("PrintType", Name = "INDEX_sapa1_PrintType")]
    [Index("ReportName", Name = "INDEX_sapa1_ReportName")]
    [Index("PrintType", Name = "INDEX_sapa1_SelectionLog")]
    [Index("Workstation", Name = "INDEX_sapa1_WorkStation")]
    [Index("PrimaryKeyValue", Name = "IX_sapa1_PrimaryKeyValue")]
    [Index("TableName", Name = "IX_sapa1_TableName")]
    public partial class Sapa1
    {
        [Key]
        public int TrxNo { get; set; }
        public int? LineItemNo { get; set; }
        [StringLength(50)]
        public string? PrimaryKeyName { get; set; }
        [StringLength(50)]
        public string? PrimaryKeyValue { get; set; }
        [StringLength(50)]
        public string? PrintBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PrintDateTime { get; set; }
        [StringLength(1)]
        public string? PrintSelection { get; set; }
        [StringLength(20)]
        public string? PrintType { get; set; }
        [StringLength(200)]
        public string? ReportName { get; set; }
        [StringLength(1000)]
        public string? SelectionLog { get; set; }
        [StringLength(50)]
        public string? TableName { get; set; }
        [StringLength(50)]
        public string? Workstation { get; set; }
    }
}
