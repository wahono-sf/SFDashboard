using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSapp5
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Alert Block Print Flag")]
        [StringLength(1)]
        public string? AlertBlockPrintFlag { get; set; }
        [Column("Alert BLock Print Flag 2")]
        [StringLength(1)]
        public string? AlertBlockPrintFlag2 { get; set; }
        [Column("Alert Condition")]
        [StringLength(300)]
        public string? AlertCondition { get; set; }
        [Column("Alert Condition 2")]
        [StringLength(300)]
        public string? AlertCondition2 { get; set; }
        [Column("Alert Message")]
        [StringLength(500)]
        public string? AlertMessage { get; set; }
        [Column("Alert Message 2")]
        [StringLength(500)]
        public string? AlertMessage2 { get; set; }
    }
}
