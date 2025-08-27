using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class GlAccCodeYear
    {
        [Column("Acc Code")]
        [StringLength(15)]
        public string AccCode { get; set; } = null!;
        [Column("Financial Year")]
        public short FinancialYear { get; set; }
    }
}
