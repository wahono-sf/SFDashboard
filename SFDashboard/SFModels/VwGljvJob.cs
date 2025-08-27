using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwGljvJob
    {
        [Column("Debit Local Amt", TypeName = "decimal(38, 2)")]
        public decimal? DebitLocalAmt { get; set; }
        [Column("Credit Local Amt", TypeName = "decimal(38, 2)")]
        public decimal? CreditLocalAmt { get; set; }
        [StringLength(20)]
        public string? JobNo { get; set; }
    }
}
