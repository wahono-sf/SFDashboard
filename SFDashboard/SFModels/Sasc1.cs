using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sasc1")]
    public partial class Sasc1
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(100)]
        public string? ButtonName { get; set; }
        [StringLength(1000)]
        public string? CrossDatabase { get; set; }
        [StringLength(50)]
        public string FormName { get; set; } = null!;
        [StringLength(50)]
        public string? Parameter { get; set; }
        [StringLength(50)]
        public string? ProgramName { get; set; }
        [StringLength(300)]
        public string? ProgramPath { get; set; }
        [StringLength(5)]
        public string? Version { get; set; }
    }
}
