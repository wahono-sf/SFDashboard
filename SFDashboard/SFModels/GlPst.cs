using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("GlPst")]
    public partial class GlPst
    {
        [StringLength(50)]
        public string? TableName { get; set; }
        public int? TrxNo { get; set; }
    }
}
