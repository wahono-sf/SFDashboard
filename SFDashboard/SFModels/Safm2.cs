using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("safm2")]
    public partial class Safm2
    {
        [StringLength(50)]
        public string? FormName { get; set; }
        [StringLength(50)]
        public string? AutoValue { get; set; }
        [StringLength(50)]
        public string? Caption { get; set; }
        [StringLength(50)]
        public string? ControlName { get; set; }
        [StringLength(50)]
        public string? DataField { get; set; }
        [StringLength(255)]
        public string? DefaultValue { get; set; }
        public double? DisplayLength { get; set; }
        [Column("F4Flag")]
        [StringLength(50)]
        public string? F4flag { get; set; }
        public double? FormSequenceNo { get; set; }
        public double? LabelIndex { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(255)]
        public string? Tag { get; set; }
        [StringLength(255)]
        public string? ToolTip { get; set; }
        [StringLength(50)]
        public string? ValidValue { get; set; }
        [StringLength(50)]
        public string? ViewName { get; set; }
    }
}
