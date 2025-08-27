using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmtn2")]
    public partial class Jmtn2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(2)]
        public string? AgencyCode { get; set; }
        public int? AgencySeqNo { get; set; }
        [StringLength(4)]
        public string? Condition1 { get; set; }
        [StringLength(4)]
        public string? Condition2 { get; set; }
        [StringLength(4)]
        public string? Condition3 { get; set; }
        [StringLength(4)]
        public string? Condition4 { get; set; }
        [StringLength(4)]
        public string? ConditionCode { get; set; }
    }
}
