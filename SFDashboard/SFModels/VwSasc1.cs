using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSasc1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Button Name")]
        [StringLength(100)]
        public string? ButtonName { get; set; }
        [Column("Form Name")]
        [StringLength(50)]
        public string FormName { get; set; } = null!;
        [StringLength(50)]
        public string? Parameter { get; set; }
        [Column("Program Name")]
        [StringLength(50)]
        public string? ProgramName { get; set; }
        [Column("Program Path")]
        [StringLength(300)]
        public string? ProgramPath { get; set; }
        [StringLength(5)]
        public string? Version { get; set; }
    }
}
