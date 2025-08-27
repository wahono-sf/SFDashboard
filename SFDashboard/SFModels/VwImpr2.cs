using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwImpr2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Country Code")]
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column("Kit Part No")]
        [StringLength(50)]
        public string? KitPartNo { get; set; }
        [Column("Kit Part No Trx No")]
        public int? KitPartNoTrxNo { get; set; }
        [Column("Kit Product Code")]
        [StringLength(255)]
        public string? KitProductCode { get; set; }
        [Column("Kit Product Flag")]
        [StringLength(1)]
        public string? KitProductFlag { get; set; }
        [Column("Kit Product Trx No")]
        public int? KitProductTrxNo { get; set; }
        [Column("Kit Qty")]
        public int? KitQty { get; set; }
        [Column("Local Unit Cost", TypeName = "decimal(13, 2)")]
        public decimal? LocalUnitCost { get; set; }
        [StringLength(2)]
        public string? Origin { get; set; }
        [Column("Quote date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? QuoteDate { get; set; }
        [Column("Unit Cost", TypeName = "decimal(13, 2)")]
        public decimal? UnitCost { get; set; }
        [Column("Vendor Code")]
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [Column("Vendor Product Code")]
        [StringLength(24)]
        public string? VendorProductCode { get; set; }
        [Column("Product Code")]
        [StringLength(255)]
        public string? ProductCode { get; set; }
        [StringLength(3)]
        [Unicode(false)]
        public string Status { get; set; } = null!;
    }
}
