using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSapp4
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Primary Key Name")]
        [StringLength(50)]
        public string PrimaryKeyName { get; set; } = null!;
        [Column("Primary Key Value")]
        [StringLength(50)]
        public string PrimaryKeyValue { get; set; } = null!;
        [Column("Parameter Value 01")]
        [StringLength(254)]
        public string? ParameterValue01 { get; set; }
        [Column("Parameter Value 02")]
        [StringLength(254)]
        public string? ParameterValue02 { get; set; }
        [Column("Parameter Value 03")]
        [StringLength(254)]
        public string? ParameterValue03 { get; set; }
        [Column("Parameter Value 04")]
        [StringLength(254)]
        public string? ParameterValue04 { get; set; }
        [Column("Parameter Value 05")]
        [StringLength(254)]
        public string? ParameterValue05 { get; set; }
        [Column("Parameter Value 06")]
        [StringLength(254)]
        public string? ParameterValue06 { get; set; }
        [Column("Parameter Value 07")]
        [StringLength(254)]
        public string? ParameterValue07 { get; set; }
        [Column("Parameter Value 08")]
        [StringLength(254)]
        public string? ParameterValue08 { get; set; }
        [Column("Parameter Value 09")]
        [StringLength(254)]
        public string? ParameterValue09 { get; set; }
        [Column("Parameter Value 10")]
        [StringLength(254)]
        public string? ParameterValue10 { get; set; }
        [Column("Print Count")]
        public int? PrintCount { get; set; }
    }
}
