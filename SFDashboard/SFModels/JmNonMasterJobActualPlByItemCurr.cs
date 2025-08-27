using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmNonMasterJobActualPlByItemCurr
    {
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Item Code")]
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [StringLength(2)]
        [Unicode(false)]
        public string Type { get; set; } = null!;
        [Column("Item Curr Code")]
        [StringLength(3)]
        public string? ItemCurrCode { get; set; }
        [Column("Item Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? ItemCurrRate { get; set; }
        [Column(TypeName = "decimal(38, 2)")]
        public decimal? Amt { get; set; }
        [Column("Local Amt", TypeName = "decimal(38, 2)")]
        public decimal? LocalAmt { get; set; }
        [Column("Vat Amt", TypeName = "decimal(38, 2)")]
        public decimal? VatAmt { get; set; }
        [Column("Vat Local Amt", TypeName = "decimal(38, 12)")]
        public decimal? VatLocalAmt { get; set; }
    }
}
