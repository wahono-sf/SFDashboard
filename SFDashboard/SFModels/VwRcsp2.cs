using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwRcsp2
    {
        [Column("Port Code")]
        [StringLength(5)]
        public string PortCode { get; set; } = null!;
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Dest Code")]
        [StringLength(3)]
        public string? DestCode { get; set; }
        [Column("Dest Country Code")]
        [StringLength(2)]
        public string? DestCountryCode { get; set; }
        [Column("No Of Day")]
        public int? NoOfDay { get; set; }
    }
}
