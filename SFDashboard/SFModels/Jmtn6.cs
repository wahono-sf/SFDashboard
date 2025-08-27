using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmtn6")]
    public partial class Jmtn6
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        public short? UpdateSeqNo { get; set; }
        [StringLength(12)]
        public string? UpdateSummaryCode1 { get; set; }
        [StringLength(2)]
        public string? UpdateSummaryType1 { get; set; }
        [StringLength(12)]
        public string? UpdateSummaryCode2 { get; set; }
        [StringLength(2)]
        public string? UpdateSummaryType2 { get; set; }
        [StringLength(12)]
        public string? UpdateSummaryCode3 { get; set; }
        [StringLength(2)]
        public string? UpdateSummaryType3 { get; set; }
        [StringLength(12)]
        public string? UpdateSummaryCode4 { get; set; }
        [StringLength(2)]
        public string? UpdateSummaryType4 { get; set; }
        [StringLength(12)]
        public string? UpdateSummaryCode5 { get; set; }
        [StringLength(2)]
        public string? UpdateSummaryType5 { get; set; }
    }
}
