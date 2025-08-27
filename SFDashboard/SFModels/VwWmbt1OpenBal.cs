using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwWmbt1OpenBal
    {
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(8)]
        public string? BillingPeriod { get; set; }
        public int? ReceiptMovementTrxNo { get; set; }
        public int? OpenPackQtyBal { get; set; }
        public int? OpenWholeQtyBal { get; set; }
        public int? OpenLooseQtyBal { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? OpenVolumeBal { get; set; }
    }
}
