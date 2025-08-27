using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("popo2")]
    public partial class Popo2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        [StringLength(50)]
        public string LineItemNo { get; set; } = null!;
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateRequested { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateRequestedAtSite { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [StringLength(15)]
        public string? HarmonizeCode { get; set; }
        [StringLength(50)]
        public string? HarmonizeDesc { get; set; }
        [StringLength(1)]
        public string? HazardousFlag { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Height { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InsuranceValue { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ItemTotalAmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LatestDeliveryDate { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Length { get; set; }
        [StringLength(80)]
        public string? LineItemComments { get; set; }
        [StringLength(10)]
        public string? ModeOfTransport { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? NetWeight { get; set; }
        [StringLength(80)]
        public string? PartDesc { get; set; }
        [StringLength(50)]
        public string? PartNo { get; set; }
        [Column("POLine")]
        [StringLength(50)]
        public string? Poline { get; set; }
        [StringLength(50)]
        public string? QtyOrdered { get; set; }
        [StringLength(3)]
        public string? QtyShipped { get; set; }
        [Column("QtyUOM")]
        [StringLength(50)]
        public string? QtyUom { get; set; }
        [StringLength(10)]
        public string? ShippingStatus { get; set; }
        [StringLength(50)]
        public string? SupplierPartNo { get; set; }
        [StringLength(50)]
        public string? TagNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimeOfArrival { get; set; }
        [Column(TypeName = "decimal(13, 5)")]
        public decimal? UnitPrice { get; set; }
        [Column("UOM")]
        [StringLength(50)]
        public string? Uom { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }
        [StringLength(50)]
        public string? WeightMeasurement { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Width { get; set; }
    }
}
