using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("smct1")]
    [Index("UserGroup", Name = "IX_Smct1_UserGroup_1")]
    public partial class Smct1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(20)]
        public string? ChargeTableNo { get; set; }
        [StringLength(1)]
        public string? AgentRateType { get; set; }
        [Column("AirlineID")]
        [StringLength(3)]
        public string? AirlineId { get; set; }
        [StringLength(10)]
        public string? ApplyToTable { get; set; }
        [Column("ChargeID")]
        [StringLength(8)]
        public string? ChargeId { get; set; }
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [StringLength(10)]
        public string? DeliveryAgentCode { get; set; }
        [StringLength(4)]
        public string? DeliveryType { get; set; }
        public int? DemurrageFreeDays { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [StringLength(3)]
        public string? DestCode { get; set; }
        [StringLength(45)]
        public string? DestName { get; set; }
        public int? DetentionFreeDays { get; set; }
        [Column(TypeName = "decimal(6, 3)")]
        public decimal? DiscountPercent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EffectiveDate { get; set; }
        public short? EstTransitTime { get; set; }
        [StringLength(50)]
        public string? EstTransitTimeRemark { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExpiryDate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ExportNominationRate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ExportNominationSales { get; set; }
        [StringLength(1000)]
        public string? ExportNote { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ExportRebate20ft { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ExportRebate20ftCoload { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ExportRebate20ftPerShp { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ExportRebate20ftPerShpCoload { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ExportRebate40ft { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ExportRebate40ftCoload { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ExportRebate40ftPerShp { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ExportRebate40ftPerShpCoload { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ExportRebateFcl { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ExportRebateFclCoload { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ExportRebateNomination { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ExportRebateNominationCoload { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ExportRebateNominationPerShp { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ExportRebateNominationPerShpCoload { get; set; }
        [StringLength(50)]
        public string? Frequency { get; set; }
        [StringLength(1)]
        public string? FrtCollectFlag { get; set; }
        [StringLength(1)]
        public string? FumigationFlag { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ImportNominationSales { get; set; }
        [StringLength(1000)]
        public string? ImportNote { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ImportRate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ImportRebate20ft { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ImportRebate20ftCoload { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ImportRebate20ftPerShp { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ImportRebate20ftPerShpCoload { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ImportRebate40ft { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ImportRebate40ftCoload { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ImportRebate40ftPerShp { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ImportRebate40ftPerShpCoload { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ImportRebateFcl { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ImportRebateFclCoload { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ImportRebateNomination { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ImportRebateNominationCoload { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ImportRebateNominationPerShp { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ImportRebateNominationPerShpCoload { get; set; }
        [StringLength(10)]
        public string? JobType { get; set; }
        [StringLength(10)]
        public string? LocationFromCode { get; set; }
        [StringLength(10)]
        public string? LocationToCode { get; set; }
        [StringLength(2)]
        public string? ModuleCode { get; set; }
        [StringLength(1000)]
        public string? Note { get; set; }
        [StringLength(5)]
        public string? NoteCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? OnCarriageRate { get; set; }
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [StringLength(45)]
        public string? OriginName { get; set; }
        [StringLength(12)]
        public string? PartyCode { get; set; }
        [StringLength(80)]
        public string? PartyName { get; set; }
        [StringLength(10)]
        public string? PortOfDischargeCode { get; set; }
        [StringLength(20)]
        public string? PortOfDischargeTerminal { get; set; }
        [StringLength(10)]
        public string? PortOfLoadingCode { get; set; }
        [StringLength(20)]
        public string? PortOfLoadingTerminal { get; set; }
        [StringLength(15)]
        public string? QuoteNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [StringLength(10)]
        public string? SecondViaPortCode { get; set; }
        public short? SecondViaPortTransitTime { get; set; }
        [StringLength(4)]
        public string? Sector { get; set; }
        [StringLength(20)]
        public string? ShipMode { get; set; }
        [StringLength(1)]
        public string? StandardChargeFlag { get; set; }
        [StringLength(2)]
        public string? TableType { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TranshipmentRate { get; set; }
        public int? TransitDay { get; set; }
        [StringLength(10)]
        public string? TransportCompanyCode { get; set; }
        [StringLength(50)]
        public string? UserDefine01 { get; set; }
        [StringLength(50)]
        public string? UserDefine02 { get; set; }
        [StringLength(50)]
        public string? UserDefine03 { get; set; }
        [StringLength(50)]
        public string? UserDefine04 { get; set; }
        [StringLength(50)]
        public string? UserDefine05 { get; set; }
        [StringLength(50)]
        public string? UserDefine06 { get; set; }
        [StringLength(50)]
        public string? UserDefine07 { get; set; }
        [StringLength(50)]
        public string? UserDefine08 { get; set; }
        [StringLength(50)]
        public string? UserDefine09 { get; set; }
        [StringLength(50)]
        public string? UserDefine10 { get; set; }
        [StringLength(10)]
        public string? UserGroup { get; set; }
        [StringLength(1)]
        public string? ValidFlag { get; set; }
        [StringLength(10)]
        public string? ViaPortCode { get; set; }
        [StringLength(50)]
        public string? ViaPortName { get; set; }
        public short? ViaPortTransitTime { get; set; }
        public int? ViaTransitDay { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
    }
}
