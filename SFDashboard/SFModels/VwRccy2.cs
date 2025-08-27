using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwRccy2
    {
        [Column("Country Code")]
        [StringLength(2)]
        public string CountryCode { get; set; } = null!;
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Port Code")]
        [StringLength(5)]
        public string? PortCode { get; set; }
        [Column("Handling Instruction")]
        [StringLength(4000)]
        public string? HandlingInstruction { get; set; }
    }
}
