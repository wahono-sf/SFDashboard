using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmJobActualCostCurrTypeGroupByJob
    {
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Invoice USD Local Amt", TypeName = "decimal(38, 2)")]
        public decimal? InvoiceUsdLocalAmt { get; set; }
        [Column("Invoice Non USD Local Amt", TypeName = "decimal(38, 2)")]
        public decimal? InvoiceNonUsdLocalAmt { get; set; }
    }
}
