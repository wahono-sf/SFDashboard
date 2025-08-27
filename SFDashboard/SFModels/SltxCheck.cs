using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class SltxCheck
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Invoice Or Cheque No")]
        [StringLength(20)]
        public string? InvoiceOrChequeNo { get; set; }
    }
}
