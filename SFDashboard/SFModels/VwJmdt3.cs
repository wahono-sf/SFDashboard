using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmdt3
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string JobNo { get; set; } = null!;
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? CostAmt { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? InvoiceDate { get; set; }
        [Column("Invoice No")]
        [StringLength(10)]
        public string? InvoiceNo { get; set; }
        [Column("Sales Or Cost Item Code")]
        [StringLength(30)]
        public string? SalesOrCostItemCode { get; set; }
        [StringLength(10)]
        public string? Source { get; set; }
        [Column("Vendor Code")]
        [StringLength(10)]
        public string? VendorCode { get; set; }
    }
}
