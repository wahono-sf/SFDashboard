using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTestGlex1
    {
        [StringLength(3)]
        public string Label1 { get; set; } = null!;
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Value1 { get; set; }
        [StringLength(3)]
        public string Label2 { get; set; } = null!;
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Value2 { get; set; }
        [StringLength(3)]
        public string Label3 { get; set; } = null!;
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Value3 { get; set; }
        [StringLength(3)]
        public string Label4 { get; set; } = null!;
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Value4 { get; set; }
    }
}
