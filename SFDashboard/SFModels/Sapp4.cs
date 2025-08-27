using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sapp4")]
    public partial class Sapp4
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        [StringLength(50)]
        public string PrimaryKeyName { get; set; } = null!;
        [Key]
        [StringLength(50)]
        public string PrimaryKeyValue { get; set; } = null!;
        [StringLength(254)]
        public string? ParameterValue01 { get; set; }
        [StringLength(254)]
        public string? ParameterValue02 { get; set; }
        [StringLength(254)]
        public string? ParameterValue03 { get; set; }
        [StringLength(254)]
        public string? ParameterValue04 { get; set; }
        [StringLength(254)]
        public string? ParameterValue05 { get; set; }
        [StringLength(254)]
        public string? ParameterValue06 { get; set; }
        [StringLength(254)]
        public string? ParameterValue07 { get; set; }
        [StringLength(254)]
        public string? ParameterValue08 { get; set; }
        [StringLength(254)]
        public string? ParameterValue09 { get; set; }
        [StringLength(254)]
        public string? ParameterValue10 { get; set; }
        public int? PrintCount { get; set; }
    }
}
