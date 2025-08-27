using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmMasterJobActualSalesByItem3
    {
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Item Code")]
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [Column("Local Amt", TypeName = "decimal(38, 2)")]
        public decimal? LocalAmt { get; set; }
        [Column("Vat Amt", TypeName = "decimal(38, 2)")]
        public decimal? VatAmt { get; set; }
        [Column("Vat Local Amt", TypeName = "decimal(38, 8)")]
        public decimal? VatLocalAmt { get; set; }
    }
}
