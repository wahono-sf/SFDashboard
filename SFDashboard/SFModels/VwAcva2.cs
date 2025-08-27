using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAcva2
    {
        [Column("Vat Code")]
        [StringLength(3)]
        public string VatCode { get; set; } = null!;
        [Column("Effective Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EffectiveDate { get; set; }
        [Column("Vat Rate", TypeName = "decimal(9, 3)")]
        public decimal? VatRate { get; set; }
    }
}
