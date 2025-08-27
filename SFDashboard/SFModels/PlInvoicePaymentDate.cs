using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class PlInvoicePaymentDate
    {
        [StringLength(20)]
        public string? InvoiceOrChequeNo { get; set; }
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TrxDate { get; set; }
    }
}
