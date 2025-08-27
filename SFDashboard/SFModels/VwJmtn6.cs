using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmtn6
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Update Seq No")]
        public short? UpdateSeqNo { get; set; }
        [Column("Update Summary Code 1")]
        [StringLength(12)]
        public string? UpdateSummaryCode1 { get; set; }
        [Column("Update Summary Type 1")]
        [StringLength(2)]
        public string? UpdateSummaryType1 { get; set; }
        [Column("Update Summary Code 2")]
        [StringLength(12)]
        public string? UpdateSummaryCode2 { get; set; }
        [Column("Update Summary Type 2")]
        [StringLength(2)]
        public string? UpdateSummaryType2 { get; set; }
        [Column("Update Summary Code 3")]
        [StringLength(12)]
        public string? UpdateSummaryCode3 { get; set; }
        [Column("Update Summary Type 3")]
        [StringLength(2)]
        public string? UpdateSummaryType3 { get; set; }
        [Column("Update Summary Code 4")]
        [StringLength(12)]
        public string? UpdateSummaryCode4 { get; set; }
        [Column("Update Summary Type 4")]
        [StringLength(2)]
        public string? UpdateSummaryType4 { get; set; }
        [Column("Update Summary Code 5")]
        [StringLength(12)]
        public string? UpdateSummaryCode5 { get; set; }
        [Column("Update Summary Type 5")]
        [StringLength(2)]
        public string? UpdateSummaryType5 { get; set; }
    }
}
