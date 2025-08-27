using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("ctcl1")]
    public partial class Ctcl1
    {
        [Key]
        public int TrxNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ActualDetentionCharge { get; set; }
        public int? BookingLineItemNo { get; set; }
        [StringLength(30)]
        public string? BookingNo { get; set; }
        [StringLength(5)]
        public string? CntrType { get; set; }
        public int? CombineFreeDay { get; set; }
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ComputedDetentionCharge { get; set; }
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [StringLength(13)]
        public string ContainerNo { get; set; } = null!;
        public int? DemurrageFreeDay { get; set; }
        [StringLength(10)]
        public string? DepotCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DestEta { get; set; }
        public int? DetentionFreeDay { get; set; }
        [Column("DGFlag")]
        [StringLength(1)]
        public string? Dgflag { get; set; }
        [StringLength(20)]
        public string? DriverPassNo { get; set; }
        public int? EdiCount { get; set; }
        [StringLength(5)]
        public string EquipmentType { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? Eta { get; set; }
        [StringLength(10)]
        public string? EventCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EventDate { get; set; }
        [StringLength(5)]
        public string? EventPortCode { get; set; }
        [StringLength(1000)]
        public string? InstructionToDepot { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [StringLength(30)]
        public string? MasterBlNo { get; set; }
        [StringLength(50)]
        public string? OrderNo { get; set; }
        [StringLength(5)]
        public string? PortOfLoadingCode { get; set; }
        [StringLength(5)]
        public string? PortOfDischargeCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReleaseDate { get; set; }
        [StringLength(255)]
        public string? Remarks { get; set; }
        [Column("RITrxNo")]
        public int? RitrxNo { get; set; }
        [Column("ROLineItemNo")]
        public int? RolineItemNo { get; set; }
        [StringLength(30)]
        public string? SealNo { get; set; }
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [StringLength(12)]
        public string? ShippingLineCode { get; set; }
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [Column("SOLineItemNo")]
        public int? SolineItemNo { get; set; }
        [Column("SOTrxNo")]
        public int? SotrxNo { get; set; }
        [StringLength(3)]
        public string? State { get; set; }
        [StringLength(3)]
        public string? StatusType { get; set; }
        [StringLength(255)]
        public string? SurveyRemarks { get; set; }
        [StringLength(80)]
        public string? TruckerName { get; set; }
        [Column("TSFlag")]
        [StringLength(5)]
        public string? Tsflag { get; set; }
        [StringLength(25)]
        public string? VehicleNo { get; set; }
        [StringLength(50)]
        public string? VesselName { get; set; }
        [StringLength(12)]
        public string? VgmAcquiredtime { get; set; }
        [StringLength(1)]
        public string? VgmFlag { get; set; }
        [StringLength(70)]
        public string? VgmReferenceNo { get; set; }
        [StringLength(70)]
        public string? VgmSigningPerson { get; set; }
        [StringLength(3)]
        public string? VgmWeightingMethod { get; set; }
        [StringLength(20)]
        public string? VoyageNo { get; set; }
        [StringLength(5)]
        public string StatusCode { get; set; } = null!;
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
    }
}
