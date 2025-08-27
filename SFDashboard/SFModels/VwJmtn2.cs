using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmtn2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Agency Seq No")]
        public int? AgencySeqNo { get; set; }
        [Column("Agency Code")]
        [StringLength(2)]
        public string? AgencyCode { get; set; }
        [Column("Condition 1")]
        [StringLength(4)]
        public string? Condition1 { get; set; }
        [Column("Condition 2")]
        [StringLength(4)]
        public string? Condition2 { get; set; }
        [Column("Condition 3")]
        [StringLength(4)]
        public string? Condition3 { get; set; }
        [Column("Condition 4")]
        [StringLength(4)]
        public string? Condition4 { get; set; }
        [Column("Condition Code")]
        [StringLength(4)]
        public string? ConditionCode { get; set; }
    }
}
