using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class PlVendorInvoiceByInvoice
    {
        [Column("Vendor Code")]
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [Column("Invoice No")]
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column("Post Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PostDate { get; set; }
        [Column("Item Code")]
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [Column("Item Local Amt", TypeName = "decimal(38, 2)")]
        public decimal? ItemLocalAmt { get; set; }
        [Column("Item Job No")]
        [StringLength(20)]
        public string? ItemJobNo { get; set; }
    }
}
