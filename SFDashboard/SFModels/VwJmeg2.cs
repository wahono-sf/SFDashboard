using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmeg2
    {
        [Column("Group Code")]
        [StringLength(20)]
        public string GroupCode { get; set; } = null!;
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Event Code")]
        [StringLength(10)]
        public string? EventCode { get; set; }
    }
}
