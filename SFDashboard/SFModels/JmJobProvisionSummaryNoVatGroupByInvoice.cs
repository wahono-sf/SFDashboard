using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmJobProvisionSummaryNoVatGroupByInvoice
    {
        [Column("Sales Amt", TypeName = "decimal(38, 2)")]
        public decimal? SalesAmt { get; set; }
        [Column("Cost Amt", TypeName = "decimal(38, 6)")]
        public decimal? CostAmt { get; set; }
        [Column("Invoice No")]
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
    }
}
