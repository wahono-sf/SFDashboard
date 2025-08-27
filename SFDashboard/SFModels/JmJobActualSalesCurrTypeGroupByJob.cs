using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmJobActualSalesCurrTypeGroupByJob
    {
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Invoice USD Local Amt", TypeName = "decimal(38, 2)")]
        public decimal? InvoiceUsdLocalAmt { get; set; }
        [Column("Invoice Non USD Local Amt", TypeName = "decimal(38, 2)")]
        public decimal? InvoiceNonUsdLocalAmt { get; set; }
        [Column("Debit Note USD Local Amt", TypeName = "decimal(38, 2)")]
        public decimal? DebitNoteUsdLocalAmt { get; set; }
        [Column("Debit Note Non USD Local Amt", TypeName = "decimal(38, 2)")]
        public decimal? DebitNoteNonUsdLocalAmt { get; set; }
        [Column("Credit Note USD Local Amt", TypeName = "decimal(38, 2)")]
        public decimal? CreditNoteUsdLocalAmt { get; set; }
        [Column("Credit Note Non USD Local Amt", TypeName = "decimal(38, 2)")]
        public decimal? CreditNoteNonUsdLocalAmt { get; set; }
    }
}
