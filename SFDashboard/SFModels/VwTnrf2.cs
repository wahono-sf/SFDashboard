using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTnrf2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Customs Refund Amt", TypeName = "decimal(16, 2)")]
        public decimal? CustomsRefundAmt { get; set; }
        [Column("Excise Refund Amt", TypeName = "decimal(16, 2)")]
        public decimal? ExciseRefundAmt { get; set; }
        [Column("Gst Refund Amt", TypeName = "decimal(16, 2)")]
        public decimal? GstRefundAmt { get; set; }
        [Column("HS Code")]
        [StringLength(10)]
        public string? HsCode { get; set; }
        [Column("Other Refund Amt", TypeName = "decimal(16, 2)")]
        public decimal? OtherRefundAmt { get; set; }
    }
}
