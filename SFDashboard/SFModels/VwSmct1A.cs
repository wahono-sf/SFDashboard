using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSmct1A
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Charge Table No")]
        [StringLength(20)]
        public string? ChargeTableNo { get; set; }
        [Column("Agent Rate Type")]
        [StringLength(1)]
        public string? AgentRateType { get; set; }
        [Column("Airline ID")]
        [StringLength(3)]
        public string? AirlineId { get; set; }
        [Column("Apply To Table")]
        [StringLength(10)]
        public string? ApplyToTable { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Charge ID")]
        [StringLength(8)]
        public string? ChargeId { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Delivery Agent Code")]
        [StringLength(10)]
        public string? DeliveryAgentCode { get; set; }
        [Column("Delivery Type")]
        [StringLength(4)]
        public string? DeliveryType { get; set; }
        [Column("Demurrage Free Days")]
        public int? DemurrageFreeDays { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column("Dest Code")]
        [StringLength(3)]
        public string? DestCode { get; set; }
        [Column("Dest Name")]
        [StringLength(45)]
        public string? DestName { get; set; }
        [Column("Detention Free Days")]
        public int? DetentionFreeDays { get; set; }
        [Column("Discount Percent", TypeName = "decimal(6, 3)")]
        public decimal? DiscountPercent { get; set; }
        [Column("Effective Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EffectiveDate { get; set; }
        [Column("Est Transit Time")]
        public short? EstTransitTime { get; set; }
        [Column("Est Transit Time Remark")]
        [StringLength(50)]
        public string? EstTransitTimeRemark { get; set; }
        [Column("Expiry Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ExpiryDate { get; set; }
        [Column("Export Nomination Rate", TypeName = "decimal(13, 2)")]
        public decimal? ExportNominationRate { get; set; }
        [Column("Export Nomination Sales", TypeName = "decimal(13, 2)")]
        public decimal? ExportNominationSales { get; set; }
        [Column("Export Note")]
        [StringLength(1000)]
        public string? ExportNote { get; set; }
        [Column("Export Rebate 20ft", TypeName = "decimal(13, 2)")]
        public decimal? ExportRebate20ft { get; set; }
        [Column("Export Rebate 20ft Coload", TypeName = "decimal(13, 2)")]
        public decimal? ExportRebate20ftCoload { get; set; }
        [Column("Export Rebate 20ft Per Shp", TypeName = "decimal(13, 2)")]
        public decimal? ExportRebate20ftPerShp { get; set; }
        [Column("Export Rebate 20ft Per Shp Coload", TypeName = "decimal(13, 2)")]
        public decimal? ExportRebate20ftPerShpCoload { get; set; }
        [Column("Export Rebate 40ft", TypeName = "decimal(13, 2)")]
        public decimal? ExportRebate40ft { get; set; }
        [Column("Export Rebate 40ft Coload", TypeName = "decimal(13, 2)")]
        public decimal? ExportRebate40ftCoload { get; set; }
        [Column("Export Rebate 40ft Per Shp", TypeName = "decimal(13, 2)")]
        public decimal? ExportRebate40ftPerShp { get; set; }
        [Column("Export Rebate 40ft Per Shp Coload", TypeName = "decimal(13, 2)")]
        public decimal? ExportRebate40ftPerShpCoload { get; set; }
        [Column("Export Rebate FCL", TypeName = "decimal(13, 2)")]
        public decimal? ExportRebateFcl { get; set; }
        [Column("Export Rebate FCL Coload", TypeName = "decimal(13, 2)")]
        public decimal? ExportRebateFclCoload { get; set; }
        [Column("Export Rebate Nomination", TypeName = "decimal(13, 2)")]
        public decimal? ExportRebateNomination { get; set; }
        [Column("Export Rebate Nomination Coload", TypeName = "decimal(13, 2)")]
        public decimal? ExportRebateNominationCoload { get; set; }
        [Column("Export Rebate Nomination Per Shp", TypeName = "decimal(13, 2)")]
        public decimal? ExportRebateNominationPerShp { get; set; }
        [Column("Export Rebate Nomination Per Shp Coload", TypeName = "decimal(13, 2)")]
        public decimal? ExportRebateNominationPerShpCoload { get; set; }
        [StringLength(50)]
        public string? Frequency { get; set; }
        [Column("Fumigation Flag")]
        [StringLength(1)]
        public string? FumigationFlag { get; set; }
        [Column("Import Rate", TypeName = "decimal(13, 2)")]
        public decimal? ImportRate { get; set; }
        [Column("Import Rebate 20ft", TypeName = "decimal(13, 2)")]
        public decimal? ImportRebate20ft { get; set; }
        [Column("Import Rebate 20ft Coload", TypeName = "decimal(13, 2)")]
        public decimal? ImportRebate20ftCoload { get; set; }
        [Column("Import Rebate 20ft Per Shp", TypeName = "decimal(13, 2)")]
        public decimal? ImportRebate20ftPerShp { get; set; }
        [Column("Import Rebate 20ft Per Shp Coload", TypeName = "decimal(13, 2)")]
        public decimal? ImportRebate20ftPerShpCoload { get; set; }
        [Column("Import Rebate 40ft", TypeName = "decimal(13, 2)")]
        public decimal? ImportRebate40ft { get; set; }
        [Column("Import Rebate 40ft Coload", TypeName = "decimal(13, 2)")]
        public decimal? ImportRebate40ftCoload { get; set; }
        [Column("Import Rebate 40ft Per Shp", TypeName = "decimal(13, 2)")]
        public decimal? ImportRebate40ftPerShp { get; set; }
        [Column("Import Rebate 40ft Per Shp Coload", TypeName = "decimal(13, 2)")]
        public decimal? ImportRebate40ftPerShpCoload { get; set; }
        [Column("Import Rebate Fcl", TypeName = "decimal(13, 2)")]
        public decimal? ImportRebateFcl { get; set; }
        [Column("Import Rebate Fcl Coload", TypeName = "decimal(13, 2)")]
        public decimal? ImportRebateFclCoload { get; set; }
        [Column("Import Rebate Nomination", TypeName = "decimal(13, 2)")]
        public decimal? ImportRebateNomination { get; set; }
        [Column("Import Rebate Nomination Coload", TypeName = "decimal(13, 2)")]
        public decimal? ImportRebateNominationCoload { get; set; }
        [Column("Import Rebate Nomination Per Shp", TypeName = "decimal(13, 2)")]
        public decimal? ImportRebateNominationPerShp { get; set; }
        [Column("Import Rebate Nomination Per Shp Coload", TypeName = "decimal(13, 2)")]
        public decimal? ImportRebateNominationPerShpCoload { get; set; }
        [Column("Job Type")]
        [StringLength(10)]
        public string? JobType { get; set; }
        [Column("Location From Code")]
        [StringLength(10)]
        public string? LocationFromCode { get; set; }
        [Column("Location To Code")]
        [StringLength(10)]
        public string? LocationToCode { get; set; }
        [Column("Module Code")]
        [StringLength(2)]
        public string? ModuleCode { get; set; }
        [StringLength(1000)]
        public string? Note { get; set; }
        [Column("Note Code")]
        [StringLength(5)]
        public string? NoteCode { get; set; }
        [Column("On Carriage Rate", TypeName = "decimal(13, 2)")]
        public decimal? OnCarriageRate { get; set; }
        [Column("Origin Code")]
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [Column("Origin Name")]
        [StringLength(45)]
        public string? OriginName { get; set; }
        [Column("Party Code")]
        [StringLength(12)]
        public string? PartyCode { get; set; }
        [Column("Party Name")]
        [StringLength(80)]
        public string? PartyName { get; set; }
        [Column("Port Of Discharge Code")]
        [StringLength(10)]
        public string? PortOfDischargeCode { get; set; }
        [Column("Port Of Discharge Name")]
        [StringLength(45)]
        public string? PortOfDischargeName { get; set; }
        [Column("Port Of Loading Code")]
        [StringLength(10)]
        public string? PortOfLoadingCode { get; set; }
        [Column("Port Of Loading Name")]
        [StringLength(45)]
        public string? PortOfLoadingName { get; set; }
        [Column("Quote No")]
        [StringLength(15)]
        public string? QuoteNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Salesman Code")]
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [Column("Second Via Port Code")]
        [StringLength(10)]
        public string? SecondViaPortCode { get; set; }
        [Column("Second Via Port Transit Time")]
        public short? SecondViaPortTransitTime { get; set; }
        [StringLength(4)]
        public string? Sector { get; set; }
        [Column("Ship Mode")]
        [StringLength(20)]
        public string? ShipMode { get; set; }
        [Column("Standard Charge Flag")]
        [StringLength(1)]
        public string? StandardChargeFlag { get; set; }
        [Column("Table Type")]
        [StringLength(2)]
        public string? TableType { get; set; }
        [Column("Transhipment Rate", TypeName = "decimal(13, 2)")]
        public decimal? TranshipmentRate { get; set; }
        [Column("Transport Company Code")]
        [StringLength(10)]
        public string? TransportCompanyCode { get; set; }
        [Column("User Define 01")]
        [StringLength(50)]
        public string? UserDefine01 { get; set; }
        [Column("User Define 02")]
        [StringLength(50)]
        public string? UserDefine02 { get; set; }
        [Column("User Define 03")]
        [StringLength(50)]
        public string? UserDefine03 { get; set; }
        [Column("User Define 04")]
        [StringLength(50)]
        public string? UserDefine04 { get; set; }
        [Column("User Define 05")]
        [StringLength(50)]
        public string? UserDefine05 { get; set; }
        [Column("User Define 06")]
        [StringLength(50)]
        public string? UserDefine06 { get; set; }
        [Column("User Define 07")]
        [StringLength(50)]
        public string? UserDefine07 { get; set; }
        [Column("User Define 08")]
        [StringLength(50)]
        public string? UserDefine08 { get; set; }
        [Column("User Define 09")]
        [StringLength(50)]
        public string? UserDefine09 { get; set; }
        [Column("User Define 10")]
        [StringLength(50)]
        public string? UserDefine10 { get; set; }
        [Column("User Group")]
        [StringLength(10)]
        public string? UserGroup { get; set; }
        [Column("Valid Flag")]
        [StringLength(1)]
        public string? ValidFlag { get; set; }
        [Column("Via Port Code")]
        [StringLength(10)]
        public string? ViaPortCode { get; set; }
        [Column("Via Port Name")]
        [StringLength(50)]
        public string? ViaPortName { get; set; }
        [Column("Via Port Transit Time")]
        public short? ViaPortTransitTime { get; set; }
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
