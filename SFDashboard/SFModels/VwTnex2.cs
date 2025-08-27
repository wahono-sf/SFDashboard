using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTnex2
    {
        [Column("Cost Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CostCurrRate { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string CurrCode { get; set; } = null!;
        [Column("Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column("Effective Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EffectiveDate { get; set; }
        [Column("Markup Rate", TypeName = "decimal(13, 6)")]
        public decimal? MarkupRate { get; set; }
        [Column("Org Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? OrgCurrRate { get; set; }
    }
}
