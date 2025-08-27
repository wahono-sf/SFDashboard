using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAeaw5
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Awb No")]
        [StringLength(20)]
        public string? AwbNo { get; set; }
        [Column("Dest Code")]
        [StringLength(3)]
        public string? DestCode { get; set; }
        [Column("Freight Amt", TypeName = "decimal(13, 2)")]
        public decimal? FreightAmt { get; set; }
        [Column("Other Amt", TypeName = "decimal(13, 2)")]
        public decimal? OtherAmt { get; set; }
        [Column("Reforwarding Amt", TypeName = "decimal(13, 2)")]
        public decimal? ReforwardingAmt { get; set; }
        [Column("Total Collect Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalCollectAmt { get; set; }
    }
}
