using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwIvch2Vat
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Vat Code")]
        [StringLength(3)]
        public string? VatCode { get; set; }
        [Column("Vat Rate", TypeName = "decimal(6, 3)")]
        public decimal? VatRate { get; set; }
    }
}
