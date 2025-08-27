using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmJobSale
    {
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InvoiceDate { get; set; }
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column("Local Amt", TypeName = "decimal(38, 2)")]
        public decimal? LocalAmt { get; set; }
        [Column("10%Vat Amt", TypeName = "decimal(38, 2)")]
        public decimal? _10VatAmt { get; set; }
        [Column("1%Vat Amt", TypeName = "decimal(38, 2)")]
        public decimal? _1VatAmt { get; set; }
        [StringLength(3)]
        public string? TermCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PaymentDate { get; set; }
        [Column(TypeName = "decimal(38, 2)")]
        public decimal? PaymentAmt { get; set; }
        [Column("Acc Code")]
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column(TypeName = "decimal(38, 2)")]
        public decimal? OutstandingAmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
    }
}
