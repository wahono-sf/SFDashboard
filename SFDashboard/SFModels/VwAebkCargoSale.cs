using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAebkCargoSale
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Awb No")]
        [StringLength(20)]
        public string? AwbNo { get; set; }
        [Column("Fsc Amt", TypeName = "decimal(38, 2)")]
        public decimal? FscAmt { get; set; }
        [Column("Iss Amt", TypeName = "decimal(38, 2)")]
        public decimal? IssAmt { get; set; }
    }
}
