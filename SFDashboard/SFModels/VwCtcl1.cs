using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwCtcl1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Actual Detention Charge", TypeName = "decimal(13, 2)")]
        public decimal? ActualDetentionCharge { get; set; }
        [Column("Bookign Line Item No")]
        public int? BookignLineItemNo { get; set; }
        [Column("Booking No")]
        [StringLength(30)]
        public string? BookingNo { get; set; }
        [Column("Cntr Type")]
        [StringLength(5)]
        public string? CntrType { get; set; }
        [Column("Combine Free Day")]
        public int? CombineFreeDay { get; set; }
        [Column("Commodity Code")]
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [Column("Commodity Description")]
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [Column("Computed Detention Charge", TypeName = "decimal(13, 2)")]
        public decimal? ComputedDetentionCharge { get; set; }
        [Column("Consignee Code")]
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [Column("Consignee Name")]
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [Column("Container No")]
        [StringLength(13)]
        public string ContainerNo { get; set; } = null!;
        [Column("Demurrage Free Day")]
        public int? DemurrageFreeDay { get; set; }
        [Column("Depot Code")]
        [StringLength(10)]
        public string? DepotCode { get; set; }
        [Column("Dest ETA")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DestEta { get; set; }
        [Column("Detention Free Day")]
        public int? DetentionFreeDay { get; set; }
        [Column("DG Flag")]
        [StringLength(1)]
        public string? DgFlag { get; set; }
        [Column("Driver Pass No")]
        [StringLength(20)]
        public string? DriverPassNo { get; set; }
        [Column("EDI Count")]
        public int? EdiCount { get; set; }
        [Column("Equipment Type")]
        [StringLength(5)]
        public string EquipmentType { get; set; } = null!;
        [Column("ETA")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Eta { get; set; }
        [Column("Event Code")]
        [StringLength(10)]
        public string? EventCode { get; set; }
        [Column("Event Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EventDate { get; set; }
        [Column("Event Port Code")]
        [StringLength(5)]
        public string? EventPortCode { get; set; }
        [Column("Instruction To Depot")]
        [StringLength(1000)]
        public string? InstructionToDepot { get; set; }
        [Column("Job No")]
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column("Master BL No")]
        [StringLength(30)]
        public string? MasterBlNo { get; set; }
        [Column("Order No")]
        [StringLength(50)]
        public string? OrderNo { get; set; }
        [Column("Port Of Loading Code")]
        [StringLength(5)]
        public string? PortOfLoadingCode { get; set; }
        [Column("Port Of Discharge Code")]
        [StringLength(5)]
        public string? PortOfDischargeCode { get; set; }
        [Column("Release Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ReleaseDate { get; set; }
        [StringLength(255)]
        public string? Remarks { get; set; }
        [Column("RI Trx No")]
        public int? RiTrxNo { get; set; }
        [Column("RO Line Item No")]
        public int? RoLineItemNo { get; set; }
        [Column("Seal No")]
        [StringLength(30)]
        public string? SealNo { get; set; }
        [Column("Shipper Code")]
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [Column("Shipper Name")]
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [Column("Shipping Line Code")]
        [StringLength(12)]
        public string? ShippingLineCode { get; set; }
        [Column("Site Code")]
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [Column("SO Line Item No")]
        public int? SoLineItemNo { get; set; }
        [Column("SO Trx No")]
        public int? SoTrxNo { get; set; }
        [StringLength(3)]
        public string? State { get; set; }
        [Column("Status Type")]
        [StringLength(3)]
        public string? StatusType { get; set; }
        [Column("Survey Remarks")]
        [StringLength(255)]
        public string? SurveyRemarks { get; set; }
        [Column("Trucker Name")]
        [StringLength(80)]
        public string? TruckerName { get; set; }
        [Column("TS Flag")]
        [StringLength(5)]
        public string? TsFlag { get; set; }
        [Column("Vehicle No")]
        [StringLength(25)]
        public string? VehicleNo { get; set; }
        [Column("Vessel Name")]
        [StringLength(50)]
        public string? VesselName { get; set; }
        [Column("Vgm Acquired Time")]
        [StringLength(12)]
        public string? VgmAcquiredTime { get; set; }
        [Column("Vgm Flag")]
        [StringLength(1)]
        public string? VgmFlag { get; set; }
        [Column("Vgm Reference No")]
        [StringLength(70)]
        public string? VgmReferenceNo { get; set; }
        [Column("Vgm Signing Person")]
        [StringLength(70)]
        public string? VgmSigningPerson { get; set; }
        [Column("Vgm Weighting Method")]
        [StringLength(3)]
        public string? VgmWeightingMethod { get; set; }
        [Column("Voyage No")]
        [StringLength(20)]
        public string? VoyageNo { get; set; }
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
        [StringLength(5)]
        public string Status { get; set; } = null!;
    }
}
