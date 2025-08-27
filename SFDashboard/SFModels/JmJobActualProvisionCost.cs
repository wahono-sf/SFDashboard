using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmJobActualProvisionCost
    {
        [Column("Vendor Code")]
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [Column("Vendor Name")]
        [StringLength(80)]
        public string? VendorName { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Invoice No")]
        [StringLength(255)]
        public string? InvoiceNo { get; set; }
        [Column("Voucher No")]
        [StringLength(20)]
        public string? VoucherNo { get; set; }
        [Column("Voucher Type")]
        [StringLength(2)]
        public string? VoucherType { get; set; }
        [Column("Item Code")]
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [Column("Post Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PostDate { get; set; }
        [Column("Item Curr Code")]
        [StringLength(3)]
        public string? ItemCurrCode { get; set; }
        [Column("Item Curr Rate", TypeName = "decimal(13, 6)")]
        public decimal? ItemCurrRate { get; set; }
        [Column("Item Qty", TypeName = "decimal(18, 4)")]
        public decimal? ItemQty { get; set; }
        [Column("Item Unit Rate", TypeName = "decimal(15, 5)")]
        public decimal? ItemUnitRate { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column("Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? LocalAmt { get; set; }
        [Column("Ref No")]
        [StringLength(20)]
        public string? RefNo { get; set; }
        [Column("Trx Type")]
        [StringLength(1)]
        public string? TrxType { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
