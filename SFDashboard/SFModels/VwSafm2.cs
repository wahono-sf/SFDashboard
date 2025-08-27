using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSafm2
    {
        [Column("Form Name")]
        [StringLength(50)]
        public string? FormName { get; set; }
        [Column("Auto Value")]
        [StringLength(50)]
        public string? AutoValue { get; set; }
        [StringLength(50)]
        public string? Caption { get; set; }
        [Column("Control Name")]
        [StringLength(50)]
        public string? ControlName { get; set; }
        [Column("Data Field")]
        [StringLength(50)]
        public string? DataField { get; set; }
        [Column("Default Value")]
        [StringLength(255)]
        public string? DefaultValue { get; set; }
        [Column("Display Length")]
        public double? DisplayLength { get; set; }
        [Column("F4 Flag")]
        [StringLength(50)]
        public string? F4Flag { get; set; }
        [Column("Form Sequence No")]
        public double? FormSequenceNo { get; set; }
        [Column("Label Index")]
        public double? LabelIndex { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(255)]
        public string? Tag { get; set; }
        [Column("Tool Tip")]
        [StringLength(255)]
        public string? ToolTip { get; set; }
        [Column("Valid Value")]
        [StringLength(50)]
        public string? ValidValue { get; set; }
        [Column("View Name")]
        [StringLength(50)]
        public string? ViewName { get; set; }
    }
}
