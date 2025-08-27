using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class PlAdvancePayment
    {
        [Column("Paid Invoice No")]
        [StringLength(20)]
        public string? PaidInvoiceNo { get; set; }
        [Column("Ref No")]
        [StringLength(10)]
        public string? RefNo { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column("Pay Amt", TypeName = "decimal(13, 2)")]
        public decimal? PayAmt { get; set; }
        [Column("Pay Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? PayLocalAmt { get; set; }
    }
}
