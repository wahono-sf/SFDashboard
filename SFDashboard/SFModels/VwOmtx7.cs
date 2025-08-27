using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwOmtx7
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amt { get; set; }
        [Column("Consignee Name")]
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? Date { get; set; }
        [Column("Invoice No")]
        [StringLength(50)]
        public string? InvoiceNo { get; set; }
        [Column("Loose Qty")]
        public int? LooseQty { get; set; }
        [Column("Order Trx No")]
        public int? OrderTrxNo { get; set; }
        [Column("Order Line Item No")]
        public int? OrderLineItemNo { get; set; }
        public int? Pcs { get; set; }
        [Column("Po No")]
        [StringLength(50)]
        public string? PoNo { get; set; }
        [Column("Ref No")]
        [StringLength(50)]
        public string? RefNo { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [Column("Shipper Name")]
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [Column("Total Volume", TypeName = "decimal(13, 4)")]
        public decimal? TotalVolume { get; set; }
        [Column("Total Weight", TypeName = "decimal(13, 4)")]
        public decimal? TotalWeight { get; set; }
        [Column("Uom Code")]
        [StringLength(3)]
        public string? UomCode { get; set; }
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string? CreatedBy { get; set; }
        [StringLength(3)]
        public string? Status { get; set; }
    }
}
