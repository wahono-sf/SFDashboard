using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmJobInvoiceCashCostCn
    {
        [StringLength(20)]
        public string? JobNo { get; set; }
        [StringLength(80)]
        public string? VendorName { get; set; }
        [StringLength(20)]
        public string? VoucherNo { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InvoiceDate { get; set; }
        [Column(TypeName = "decimal(38, 2)")]
        public decimal CashAdvanceLocalAmt { get; set; }
        [Column(TypeName = "decimal(38, 2)")]
        public decimal? LocalAmt { get; set; }
        [StringLength(15)]
        public string? AccCode { get; set; }
    }
}
