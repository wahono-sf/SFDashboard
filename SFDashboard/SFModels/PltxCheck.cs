using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class PltxCheck
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Vendor Code")]
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [Column("Invoice Or Cheque No")]
        [StringLength(20)]
        public string? InvoiceOrChequeNo { get; set; }
    }
}
