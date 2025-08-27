using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwGlrv1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Cost Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CostCurrRate { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column("Revaluate Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? RevaluateDate { get; set; }
    }
}
