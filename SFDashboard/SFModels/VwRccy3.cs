using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwRccy3
    {
        [Column("Country Code")]
        [StringLength(2)]
        public string CountryCode { get; set; } = null!;
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [StringLength(10)]
        public string? Symbol { get; set; }
        [Column("Handling Instruction")]
        [StringLength(4000)]
        public string? HandlingInstruction { get; set; }
    }
}
