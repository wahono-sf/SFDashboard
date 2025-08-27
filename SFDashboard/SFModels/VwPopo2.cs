using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwPopo2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        [StringLength(50)]
        public string LineItemNo { get; set; } = null!;
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Date Requested")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DateRequested { get; set; }
        [Column("Date Requested At Site")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DateRequestedAtSite { get; set; }
        [Column("Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column("Harmonize Code")]
        [StringLength(15)]
        public string? HarmonizeCode { get; set; }
        [Column("Harmonize Description")]
        [StringLength(50)]
        public string? HarmonizeDescription { get; set; }
        [Column("Hazardous Flag")]
        [StringLength(1)]
        public string? HazardousFlag { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Height { get; set; }
        [Column("Insurance Value", TypeName = "decimal(13, 2)")]
        public decimal? InsuranceValue { get; set; }
        [Column("Item Total Amt", TypeName = "decimal(13, 2)")]
        public decimal? ItemTotalAmt { get; set; }
        [Column("Latest Delivery Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LatestDeliveryDate { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Length { get; set; }
        [Column("Line Item Comments")]
        [StringLength(80)]
        public string? LineItemComments { get; set; }
        [Column("Mode Of Transport")]
        [StringLength(10)]
        public string? ModeOfTransport { get; set; }
        [Column("Net Weight", TypeName = "decimal(13, 4)")]
        public decimal? NetWeight { get; set; }
        [Column("Part Description")]
        [StringLength(80)]
        public string? PartDescription { get; set; }
        [Column("Part No")]
        [StringLength(50)]
        public string? PartNo { get; set; }
        [Column("PO Line")]
        [StringLength(50)]
        public string? PoLine { get; set; }
        [Column("Qty Ordered")]
        [StringLength(50)]
        public string? QtyOrdered { get; set; }
        [Column("Qty Shipped")]
        [StringLength(3)]
        public string? QtyShipped { get; set; }
        [Column("Qty UOM")]
        [StringLength(3)]
        public string? QtyUom { get; set; }
        [Column("Shipping Status")]
        [StringLength(10)]
        public string? ShippingStatus { get; set; }
        [Column("Supplier Part No")]
        [StringLength(50)]
        public string? SupplierPartNo { get; set; }
        [Column("Tag No")]
        [StringLength(50)]
        public string? TagNo { get; set; }
        [Column("Time Of Arrival", TypeName = "datetime")]
        public DateTime? TimeOfArrival { get; set; }
        [Column("Unit Price", TypeName = "decimal(13, 5)")]
        public decimal? UnitPrice { get; set; }
        [Column("UOM")]
        [StringLength(50)]
        public string? Uom { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }
        [Column("Weight Measurement")]
        [StringLength(50)]
        public string? WeightMeasurement { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Width { get; set; }
    }
}
