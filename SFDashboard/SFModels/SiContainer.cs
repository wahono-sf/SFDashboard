using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class SiContainer
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Container No")]
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        [Column("Container Type")]
        [StringLength(5)]
        public string? ContainerType { get; set; }
        [Column("Goods Description 01")]
        [StringLength(50)]
        public string? GoodsDescription01 { get; set; }
        [Column("Goods Description 02")]
        [StringLength(50)]
        public string? GoodsDescription02 { get; set; }
        [Column("BL No")]
        [StringLength(20)]
        public string BlNo { get; set; } = null!;
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Shipper Code")]
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [Column("Shipper Name")]
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [Column("Consignee Code")]
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [Column("Consignee Name")]
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [Column("Shippingline Code")]
        [StringLength(12)]
        public string? ShippinglineCode { get; set; }
        [Column("Shipment Type")]
        [StringLength(1)]
        public string? ShipmentType { get; set; }
        [Column("Vessel Code")]
        [StringLength(50)]
        public string? VesselCode { get; set; }
        [Column("Vessel Name")]
        [StringLength(50)]
        public string? VesselName { get; set; }
        [Column("Mother Vessel Name")]
        [StringLength(50)]
        public string? MotherVesselName { get; set; }
        [Column("Mother Voyage")]
        [StringLength(20)]
        public string? MotherVoyage { get; set; }
        [Column("Voyage No")]
        [StringLength(20)]
        public string? VoyageNo { get; set; }
        [Column("Port Of Loading Name")]
        [StringLength(45)]
        public string? PortOfLoadingName { get; set; }
        [Column("Etd Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EtdDate { get; set; }
        [Column("Eta Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EtaDate { get; set; }
        public int? Pcs { get; set; }
        [Column("Uom Code")]
        [StringLength(3)]
        public string? UomCode { get; set; }
        [Column("Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column("Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string CreatedBy { get; set; } = null!;
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string UpdatedBy { get; set; } = null!;
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
