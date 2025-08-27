using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmtn1")]
    public partial class Jmtn1
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        [StringLength(30)]
        public string JobNo { get; set; } = null!;
        [Key]
        public short LineItemNo { get; set; }
        [Column(TypeName = "decimal(2, 0)")]
        public decimal? AmendedFieldCount { get; set; }
        [StringLength(70)]
        public string? AmendReason1 { get; set; }
        [StringLength(70)]
        public string? AmendReason2 { get; set; }
        [StringLength(70)]
        public string? AmendReason3 { get; set; }
        [StringLength(70)]
        public string? AmendReason4 { get; set; }
        [StringLength(2)]
        public string? AppProductType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ApproveDate { get; set; }
        [StringLength(30)]
        public string? AwbBlNo { get; set; }
        [StringLength(3)]
        public string? BgIndFlag { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BlanketStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CaAppDateTime { get; set; }
        [StringLength(35)]
        public string? CaLicenseNo1 { get; set; }
        [StringLength(35)]
        public string? CaLicenseNo2 { get; set; }
        [StringLength(35)]
        public string? CaLicenseNo3 { get; set; }
        [StringLength(35)]
        public string? CaLicenseNo4 { get; set; }
        [StringLength(35)]
        public string? CaLicenseNo5 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CertDate { get; set; }
        [StringLength(35)]
        public string? CertDetailLine1 { get; set; }
        [StringLength(35)]
        public string? CertDetailLine2 { get; set; }
        [StringLength(35)]
        public string? CertDetailLine3 { get; set; }
        [StringLength(35)]
        public string? CertDetailLine4 { get; set; }
        [StringLength(35)]
        public string? CertDetailLine5 { get; set; }
        [StringLength(35)]
        public string? CertInfo01Line01 { get; set; }
        [StringLength(35)]
        public string? CertInfo01Line02 { get; set; }
        [StringLength(35)]
        public string? CertInfo01Line03 { get; set; }
        [StringLength(35)]
        public string? CertInfo01Line04 { get; set; }
        [StringLength(35)]
        public string? CertInfo01Line05 { get; set; }
        [StringLength(35)]
        public string? CertInfo02Line01 { get; set; }
        [StringLength(35)]
        public string? CertInfo02Line02 { get; set; }
        [StringLength(35)]
        public string? CertInfo02Line03 { get; set; }
        [StringLength(35)]
        public string? CertInfo02Line04 { get; set; }
        [StringLength(35)]
        public string? CertInfo02Line05 { get; set; }
        [StringLength(35)]
        public string? CertInfo03Line01 { get; set; }
        [StringLength(35)]
        public string? CertInfo03Line02 { get; set; }
        [StringLength(35)]
        public string? CertInfo03Line03 { get; set; }
        [StringLength(35)]
        public string? CertInfo03Line04 { get; set; }
        [StringLength(35)]
        public string? CertInfo03Line05 { get; set; }
        [StringLength(35)]
        public string? CertInfo04Line01 { get; set; }
        [StringLength(35)]
        public string? CertInfo04Line02 { get; set; }
        [StringLength(35)]
        public string? CertInfo04Line03 { get; set; }
        [StringLength(35)]
        public string? CertInfo04Line04 { get; set; }
        [StringLength(35)]
        public string? CertInfo04Line05 { get; set; }
        [StringLength(35)]
        public string? CertInfo05Line01 { get; set; }
        [StringLength(35)]
        public string? CertInfo05Line02 { get; set; }
        [StringLength(35)]
        public string? CertInfo05Line03 { get; set; }
        [StringLength(35)]
        public string? CertInfo05Line04 { get; set; }
        [StringLength(35)]
        public string? CertInfo05Line05 { get; set; }
        [StringLength(17)]
        public string? CertNo { get; set; }
        [Column(TypeName = "decimal(4, 0)")]
        public decimal? CertSeqNo1 { get; set; }
        [Column(TypeName = "decimal(4, 0)")]
        public decimal? CertSeqNo2 { get; set; }
        [StringLength(2)]
        public string? CertType1 { get; set; }
        [StringLength(2)]
        public string? CertType2 { get; set; }
        [StringLength(17)]
        public string? ClaimantCode { get; set; }
        [StringLength(100)]
        public string? ClaimantName { get; set; }
        [StringLength(50)]
        public string? ClaimantCompany01 { get; set; }
        [StringLength(50)]
        public string? ClaimantCompany02 { get; set; }
        [Column("ClaimantUEN")]
        [StringLength(17)]
        public string? ClaimantUen { get; set; }
        [StringLength(1)]
        public string? CoFlag { get; set; }
        [StringLength(17)]
        public string? ConsigneeCode { get; set; }
        [StringLength(35)]
        public string? ConsigneeName01 { get; set; }
        [StringLength(35)]
        public string? ConsigneeName02 { get; set; }
        [StringLength(35)]
        public string? ConsigneeAddress01 { get; set; }
        [StringLength(35)]
        public string? ConsigneeAddress02 { get; set; }
        [StringLength(35)]
        public string? ConsigneeAddress03 { get; set; }
        [StringLength(35)]
        public string? ConsigneeCityName { get; set; }
        [StringLength(2)]
        public string? ConsigneeCountryCode { get; set; }
        [StringLength(9)]
        public string? ConsigneePostalCode { get; set; }
        [StringLength(9)]
        public string? ConsigneeSubentityCode { get; set; }
        [StringLength(35)]
        public string? ConsigneeSubentityName { get; set; }
        [Column("Cpc1Item1PC1")]
        [StringLength(35)]
        public string? Cpc1Item1Pc1 { get; set; }
        [Column("Cpc1Item1PC2")]
        [StringLength(35)]
        public string? Cpc1Item1Pc2 { get; set; }
        [Column("Cpc1Item1PC3")]
        [StringLength(35)]
        public string? Cpc1Item1Pc3 { get; set; }
        [Column("Cpc1Item2PC1")]
        [StringLength(35)]
        public string? Cpc1Item2Pc1 { get; set; }
        [Column("Cpc1Item2PC2")]
        [StringLength(35)]
        public string? Cpc1Item2Pc2 { get; set; }
        [Column("Cpc1Item2PC3")]
        [StringLength(35)]
        public string? Cpc1Item2Pc3 { get; set; }
        [Column("Cpc1Item3PC1")]
        [StringLength(35)]
        public string? Cpc1Item3Pc1 { get; set; }
        [Column("Cpc1Item3PC2")]
        [StringLength(35)]
        public string? Cpc1Item3Pc2 { get; set; }
        [Column("Cpc1Item3PC3")]
        [StringLength(35)]
        public string? Cpc1Item3Pc3 { get; set; }
        [Column("Cpc1Item4PC1")]
        [StringLength(35)]
        public string? Cpc1Item4Pc1 { get; set; }
        [Column("Cpc1Item4PC2")]
        [StringLength(35)]
        public string? Cpc1Item4Pc2 { get; set; }
        [Column("Cpc1Item4PC3")]
        [StringLength(35)]
        public string? Cpc1Item4Pc3 { get; set; }
        [Column("Cpc1Item5PC1")]
        [StringLength(35)]
        public string? Cpc1Item5Pc1 { get; set; }
        [Column("Cpc1Item5PC2")]
        [StringLength(35)]
        public string? Cpc1Item5Pc2 { get; set; }
        [Column("Cpc1Item5PC3")]
        [StringLength(35)]
        public string? Cpc1Item5Pc3 { get; set; }
        [Column("Cpc2Item1PC1")]
        [StringLength(35)]
        public string? Cpc2Item1Pc1 { get; set; }
        [Column("Cpc2Item1PC2")]
        [StringLength(35)]
        public string? Cpc2Item1Pc2 { get; set; }
        [Column("Cpc2Item1PC3")]
        [StringLength(35)]
        public string? Cpc2Item1Pc3 { get; set; }
        [Column("Cpc2Item2PC1")]
        [StringLength(35)]
        public string? Cpc2Item2Pc1 { get; set; }
        [Column("Cpc2Item2PC2")]
        [StringLength(35)]
        public string? Cpc2Item2Pc2 { get; set; }
        [Column("Cpc2Item2PC3")]
        [StringLength(35)]
        public string? Cpc2Item2Pc3 { get; set; }
        [Column("Cpc2Item3PC1")]
        [StringLength(35)]
        public string? Cpc2Item3Pc1 { get; set; }
        [Column("Cpc2Item3PC2")]
        [StringLength(35)]
        public string? Cpc2Item3Pc2 { get; set; }
        [Column("Cpc2Item3PC3")]
        [StringLength(35)]
        public string? Cpc2Item3Pc3 { get; set; }
        [Column("Cpc2Item4PC1")]
        [StringLength(35)]
        public string? Cpc2Item4Pc1 { get; set; }
        [Column("Cpc2Item4PC2")]
        [StringLength(35)]
        public string? Cpc2Item4Pc2 { get; set; }
        [Column("Cpc2Item4PC3")]
        [StringLength(35)]
        public string? Cpc2Item4Pc3 { get; set; }
        [Column("Cpc2Item5PC1")]
        [StringLength(35)]
        public string? Cpc2Item5Pc1 { get; set; }
        [Column("Cpc2Item5PC2")]
        [StringLength(35)]
        public string? Cpc2Item5Pc2 { get; set; }
        [Column("Cpc2Item5PC3")]
        [StringLength(35)]
        public string? Cpc2Item5Pc3 { get; set; }
        [Column("Cpc3Item1PC1")]
        [StringLength(35)]
        public string? Cpc3Item1Pc1 { get; set; }
        [Column("Cpc3Item1PC2")]
        [StringLength(35)]
        public string? Cpc3Item1Pc2 { get; set; }
        [Column("Cpc3Item1PC3")]
        [StringLength(35)]
        public string? Cpc3Item1Pc3 { get; set; }
        [Column("Cpc3Item2PC1")]
        [StringLength(35)]
        public string? Cpc3Item2Pc1 { get; set; }
        [Column("Cpc3Item2PC2")]
        [StringLength(35)]
        public string? Cpc3Item2Pc2 { get; set; }
        [Column("Cpc3Item2PC3")]
        [StringLength(35)]
        public string? Cpc3Item2Pc3 { get; set; }
        [Column("Cpc3Item3PC1")]
        [StringLength(35)]
        public string? Cpc3Item3Pc1 { get; set; }
        [Column("Cpc3Item3PC2")]
        [StringLength(35)]
        public string? Cpc3Item3Pc2 { get; set; }
        [Column("Cpc3Item3PC3")]
        [StringLength(35)]
        public string? Cpc3Item3Pc3 { get; set; }
        [Column("Cpc3Item4PC1")]
        [StringLength(35)]
        public string? Cpc3Item4Pc1 { get; set; }
        [Column("Cpc3Item4PC2")]
        [StringLength(35)]
        public string? Cpc3Item4Pc2 { get; set; }
        [Column("Cpc3Item4PC3")]
        [StringLength(35)]
        public string? Cpc3Item4Pc3 { get; set; }
        [Column("Cpc3Item5PC1")]
        [StringLength(35)]
        public string? Cpc3Item5Pc1 { get; set; }
        [Column("Cpc3Item5PC2")]
        [StringLength(35)]
        public string? Cpc3Item5Pc2 { get; set; }
        [Column("Cpc3Item5PC3")]
        [StringLength(35)]
        public string? Cpc3Item5Pc3 { get; set; }
        [Column("Cpc4Item1PC1")]
        [StringLength(35)]
        public string? Cpc4Item1Pc1 { get; set; }
        [Column("Cpc4Item1PC2")]
        [StringLength(35)]
        public string? Cpc4Item1Pc2 { get; set; }
        [Column("Cpc4Item1PC3")]
        [StringLength(35)]
        public string? Cpc4Item1Pc3 { get; set; }
        [Column("Cpc4Item2PC1")]
        [StringLength(35)]
        public string? Cpc4Item2Pc1 { get; set; }
        [Column("Cpc4Item2PC2")]
        [StringLength(35)]
        public string? Cpc4Item2Pc2 { get; set; }
        [Column("Cpc4Item2PC3")]
        [StringLength(35)]
        public string? Cpc4Item2Pc3 { get; set; }
        [Column("Cpc4Item3PC1")]
        [StringLength(35)]
        public string? Cpc4Item3Pc1 { get; set; }
        [Column("Cpc4Item3PC2")]
        [StringLength(35)]
        public string? Cpc4Item3Pc2 { get; set; }
        [Column("Cpc4Item3PC3")]
        [StringLength(35)]
        public string? Cpc4Item3Pc3 { get; set; }
        [Column("Cpc4Item4PC1")]
        [StringLength(35)]
        public string? Cpc4Item4Pc1 { get; set; }
        [Column("Cpc4Item4PC2")]
        [StringLength(35)]
        public string? Cpc4Item4Pc2 { get; set; }
        [Column("Cpc4Item4PC3")]
        [StringLength(35)]
        public string? Cpc4Item4Pc3 { get; set; }
        [Column("Cpc4Item5PC1")]
        [StringLength(35)]
        public string? Cpc4Item5Pc1 { get; set; }
        [Column("Cpc4Item5PC2")]
        [StringLength(35)]
        public string? Cpc4Item5Pc2 { get; set; }
        [Column("Cpc4Item5PC3")]
        [StringLength(35)]
        public string? Cpc4Item5Pc3 { get; set; }
        [Column("Cpc5Item1PC1")]
        [StringLength(35)]
        public string? Cpc5Item1Pc1 { get; set; }
        [Column("Cpc5Item1PC2")]
        [StringLength(35)]
        public string? Cpc5Item1Pc2 { get; set; }
        [Column("Cpc5Item1PC3")]
        [StringLength(35)]
        public string? Cpc5Item1Pc3 { get; set; }
        [Column("Cpc5Item2PC1")]
        [StringLength(35)]
        public string? Cpc5Item2Pc1 { get; set; }
        [Column("Cpc5Item2PC2")]
        [StringLength(35)]
        public string? Cpc5Item2Pc2 { get; set; }
        [Column("Cpc5Item2PC3")]
        [StringLength(35)]
        public string? Cpc5Item2Pc3 { get; set; }
        [Column("Cpc5Item3PC1")]
        [StringLength(35)]
        public string? Cpc5Item3Pc1 { get; set; }
        [Column("Cpc5Item3PC2")]
        [StringLength(35)]
        public string? Cpc5Item3Pc2 { get; set; }
        [Column("Cpc5Item3PC3")]
        [StringLength(35)]
        public string? Cpc5Item3Pc3 { get; set; }
        [Column("Cpc5Item4PC1")]
        [StringLength(35)]
        public string? Cpc5Item4Pc1 { get; set; }
        [Column("Cpc5Item4PC2")]
        [StringLength(35)]
        public string? Cpc5Item4Pc2 { get; set; }
        [Column("Cpc5Item4PC3")]
        [StringLength(35)]
        public string? Cpc5Item4Pc3 { get; set; }
        [Column("Cpc5Item5PC1")]
        [StringLength(35)]
        public string? Cpc5Item5Pc1 { get; set; }
        [Column("Cpc5Item5PC2")]
        [StringLength(35)]
        public string? Cpc5Item5Pc2 { get; set; }
        [Column("Cpc5Item5PC3")]
        [StringLength(35)]
        public string? Cpc5Item5Pc3 { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CustomDutyAmt { get; set; }
        [StringLength(7)]
        public string? CustomsProcedureCode1 { get; set; }
        [StringLength(7)]
        public string? CustomsProcedureCode2 { get; set; }
        [StringLength(7)]
        public string? CustomsProcedureCode3 { get; set; }
        [StringLength(7)]
        public string? CustomsProcedureCode4 { get; set; }
        [StringLength(7)]
        public string? CustomsProcedureCode5 { get; set; }
        [StringLength(3)]
        public string? DclrCode { get; set; }
        [StringLength(1)]
        public string? DclrIndFlag { get; set; }
        [StringLength(20)]
        public string? DeclarantPartyCode { get; set; }
        [StringLength(3)]
        public string? DeclarationCode { get; set; }
        [StringLength(20)]
        public string? DeclareBy { get; set; }
        [StringLength(20)]
        public string? DeliveryOrderNo { get; set; }
        [StringLength(70)]
        public string? DocFileName01 { get; set; }
        [StringLength(70)]
        public string? DocFileName02 { get; set; }
        [StringLength(70)]
        public string? DocFileName03 { get; set; }
        [StringLength(70)]
        public string? DocFileName04 { get; set; }
        [StringLength(70)]
        public string? DocFileName05 { get; set; }
        [StringLength(70)]
        public string? DocFileName06 { get; set; }
        [StringLength(70)]
        public string? DocFileName07 { get; set; }
        [StringLength(70)]
        public string? DocFileName08 { get; set; }
        [StringLength(70)]
        public string? DocFileName09 { get; set; }
        [StringLength(70)]
        public string? DocFileName10 { get; set; }
        [StringLength(35)]
        public string? DocType01 { get; set; }
        [StringLength(35)]
        public string? DocType02 { get; set; }
        [StringLength(35)]
        public string? DocType03 { get; set; }
        [StringLength(35)]
        public string? DocType04 { get; set; }
        [StringLength(35)]
        public string? DocType05 { get; set; }
        [StringLength(35)]
        public string? DocType06 { get; set; }
        [StringLength(35)]
        public string? DocType07 { get; set; }
        [StringLength(35)]
        public string? DocType08 { get; set; }
        [StringLength(35)]
        public string? DocType09 { get; set; }
        [StringLength(35)]
        public string? DocType10 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDateOfExhibition { get; set; }
        [StringLength(17)]
        public string? EndUserCode { get; set; }
        [StringLength(50)]
        public string? EndUserName01 { get; set; }
        [StringLength(50)]
        public string? EndUserName02 { get; set; }
        [StringLength(35)]
        public string? EndUserAddress01 { get; set; }
        [StringLength(35)]
        public string? EndUserAddress02 { get; set; }
        [StringLength(35)]
        public string? EndUserCityName { get; set; }
        [StringLength(2)]
        public string? EndUserCountryCode { get; set; }
        [StringLength(9)]
        public string? EndUserPostalCode { get; set; }
        [StringLength(9)]
        public string? EndUserSubentityCode { get; set; }
        [StringLength(35)]
        public string? EndUserSubentityName { get; set; }
        [Column(TypeName = "decimal(4, 0)")]
        public decimal? EntryYear { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Eta { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Etd { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ExciseAmt { get; set; }
        [StringLength(17)]
        public string? ExporterCode { get; set; }
        [StringLength(35)]
        public string? ExporterName01 { get; set; }
        [StringLength(35)]
        public string? ExporterName02 { get; set; }
        [StringLength(35)]
        public string? ExporterAddress01 { get; set; }
        [StringLength(35)]
        public string? ExporterAddress02 { get; set; }
        [StringLength(35)]
        public string? ExporterCityName { get; set; }
        [StringLength(2)]
        public string? ExporterCountryCode { get; set; }
        [Column("ExporterCRUEI")]
        [StringLength(17)]
        public string? ExporterCruei { get; set; }
        [StringLength(9)]
        public string? ExporterPostalCode { get; set; }
        [StringLength(9)]
        public string? ExporterSubentityCode { get; set; }
        [StringLength(35)]
        public string? ExporterSubentityName { get; set; }
        [StringLength(1)]
        public string? ExtReasonCode { get; set; }
        [StringLength(70)]
        public string? ExtReason1 { get; set; }
        [StringLength(70)]
        public string? ExtReason2 { get; set; }
        [StringLength(70)]
        public string? ExtReason3 { get; set; }
        [StringLength(70)]
        public string? ExtReason4 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? FeeAmt { get; set; }
        [StringLength(50)]
        public string? FeederVesselName { get; set; }
        [StringLength(17)]
        public string? FeederVoyage { get; set; }
        [StringLength(3)]
        public string? FinalDestCode { get; set; }
        [StringLength(5)]
        public string? FirstViaPortCode { get; set; }
        [StringLength(17)]
        public string? FreightForwarderCode { get; set; }
        [StringLength(50)]
        public string? FreightForwarderName01 { get; set; }
        [StringLength(50)]
        public string? FreightForwarderName02 { get; set; }
        [Column("FreightForwarderCRUEI")]
        [StringLength(17)]
        public string? FreightForwarderCruei { get; set; }
        [Column(TypeName = "decimal(15, 3)")]
        public decimal? GrossWt { get; set; }
        [StringLength(50)]
        public string? GrossWtUomCode { get; set; }
        [StringLength(2)]
        public string? GspDonorCountry { get; set; }
        [Column(TypeName = "decimal(15, 2)")]
        public decimal? GstAmt { get; set; }
        [StringLength(3)]
        public string? GstCode { get; set; }
        [StringLength(1)]
        public string? GstRecoverableFlag { get; set; }
        [StringLength(17)]
        public string? HandlingAgentCode { get; set; }
        [StringLength(50)]
        public string? HandlingAgentName01 { get; set; }
        [StringLength(50)]
        public string? HandlingAgentName02 { get; set; }
        [Column("HandlingAgentCRUEI")]
        [StringLength(17)]
        public string? HandlingAgentCruei { get; set; }
        [StringLength(8)]
        public string? Importer { get; set; }
        [StringLength(17)]
        public string? ImporterCode { get; set; }
        [StringLength(50)]
        public string? ImporterName01 { get; set; }
        [StringLength(50)]
        public string? ImporterName02 { get; set; }
        [Column("ImporterCRUEI")]
        [StringLength(17)]
        public string? ImporterCruei { get; set; }
        [StringLength(17)]
        public string? InConveyanceRefNo { get; set; }
        [StringLength(30)]
        public string? InMawbOblNo { get; set; }
        [StringLength(2)]
        public string? InModuleCode { get; set; }
        [StringLength(35)]
        public string? InTransportIdentifier { get; set; }
        [StringLength(7)]
        public string? InVesselLocCode { get; set; }
        [StringLength(105)]
        public string? InVesselLocName { get; set; }
        [StringLength(50)]
        public string? InVesselName { get; set; }
        [StringLength(17)]
        public string? InwardCarrierAgentCode { get; set; }
        [StringLength(50)]
        public string? InwardCarrierAgentName01 { get; set; }
        [StringLength(50)]
        public string? InwardCarrierAgentName02 { get; set; }
        [Column("InwardCarrierAgentCRUEI")]
        [StringLength(17)]
        public string? InwardCarrierAgentCruei { get; set; }
        [Column("IssueAuthID")]
        [StringLength(17)]
        public string? IssueAuthId { get; set; }
        [StringLength(17)]
        public string? ManufacturerCode { get; set; }
        [StringLength(35)]
        public string? ManufacturerName01 { get; set; }
        [StringLength(35)]
        public string? ManufacturerName02 { get; set; }
        [StringLength(35)]
        public string? ManufacturerAddress01 { get; set; }
        [StringLength(35)]
        public string? ManufacturerAddress02 { get; set; }
        [StringLength(35)]
        public string? ManufacturerCityName { get; set; }
        [StringLength(2)]
        public string? ManufacturerCountryCode { get; set; }
        [StringLength(9)]
        public string? ManufacturerPostalCode { get; set; }
        [StringLength(9)]
        public string? ManufacturerSubentityCode { get; set; }
        [StringLength(35)]
        public string? ManufacturerSubentityName { get; set; }
        [StringLength(30)]
        public string? MawbOblNo { get; set; }
        [Column("MESFlag")]
        [StringLength(1)]
        public string? Mesflag { get; set; }
        [StringLength(1)]
        public string? MindefFlag { get; set; }
        [StringLength(2)]
        public string? ModuleCode { get; set; }
        [Column(TypeName = "decimal(2, 0)")]
        public decimal? NoOfCopy1 { get; set; }
        [Column(TypeName = "decimal(2, 0)")]
        public decimal? NoOfCopy2 { get; set; }
        [Column("NRT", TypeName = "decimal(15, 3)")]
        public decimal? Nrt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OrgAppDate { get; set; }
        [StringLength(17)]
        public string? OutConveyanceRefNo { get; set; }
        [StringLength(30)]
        public string? OutMawbOblNo { get; set; }
        [StringLength(2)]
        public string? OutModuleCode { get; set; }
        [StringLength(35)]
        public string? OutTransportIdentifier { get; set; }
        [StringLength(7)]
        public string? OutVesselLocCode { get; set; }
        [StringLength(105)]
        public string? OutVesselLocName { get; set; }
        [StringLength(17)]
        public string? OutwardCarrierAgentCode { get; set; }
        [StringLength(50)]
        public string? OutwardCarrierAgentName01 { get; set; }
        [StringLength(50)]
        public string? OutwardCarrierAgentName02 { get; set; }
        [Column("OutwardCarrierAgentCRUEI")]
        [StringLength(17)]
        public string? OutwardCarrierAgentCruei { get; set; }
        [StringLength(3)]
        public string? PackType { get; set; }
        [Column(TypeName = "decimal(3, 0)")]
        public decimal? PercentContent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PermitAppDateTime { get; set; }
        [StringLength(6)]
        public string? PermitCode { get; set; }
        public int? PermitCount { get; set; }
        [StringLength(75)]
        public string? PermitDesc { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PermitEndDate { get; set; }
        [StringLength(3)]
        public string? PermitIndicator { get; set; }
        [StringLength(17)]
        public string? PermitNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PermitStartDate { get; set; }
        [StringLength(7)]
        public string? PermitType { get; set; }
        [StringLength(1)]
        public string? PermitValidityFlag { get; set; }
        [StringLength(5)]
        public string? PortOfDischargeCode { get; set; }
        [StringLength(45)]
        public string? PortOfDischargeName { get; set; }
        [StringLength(5)]
        public string? PortOfLoadingCode { get; set; }
        [StringLength(35)]
        public string? PrevPermitNo { get; set; }
        public int? Qty { get; set; }
        [StringLength(7)]
        public string? RcpLocCode { get; set; }
        [StringLength(256)]
        public string? RcpLocName { get; set; }
        [StringLength(17)]
        public string? RecipientMbx1 { get; set; }
        [StringLength(17)]
        public string? RecipientMbx2 { get; set; }
        [StringLength(17)]
        public string? RecipientMbx3 { get; set; }
        [StringLength(30)]
        public string? RefNo { get; set; }
        [StringLength(4)]
        public string? RefundCode { get; set; }
        [StringLength(70)]
        public string? RefundReason1 { get; set; }
        [StringLength(70)]
        public string? RefundReason2 { get; set; }
        [StringLength(70)]
        public string? RefundReason3 { get; set; }
        [StringLength(70)]
        public string? RefundReason4 { get; set; }
        [StringLength(7)]
        public string? RelLocCode { get; set; }
        [StringLength(256)]
        public string? RelLocName { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(512)]
        public string? Remark1Line1 { get; set; }
        [StringLength(512)]
        public string? Remark1Line2 { get; set; }
        [StringLength(512)]
        public string? Remark2Line1 { get; set; }
        [StringLength(512)]
        public string? Remark2Line2 { get; set; }
        [StringLength(512)]
        public string? Remark3Line1 { get; set; }
        [StringLength(512)]
        public string? Remark3Line2 { get; set; }
        [StringLength(512)]
        public string? Remark4Line1 { get; set; }
        [StringLength(512)]
        public string? Remark4Line2 { get; set; }
        [StringLength(512)]
        public string? Remark5Line1 { get; set; }
        [StringLength(512)]
        public string? Remark5Line2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RemovalDate { get; set; }
        [StringLength(11)]
        public string? ReplacePermitNo { get; set; }
        [StringLength(3)]
        public string? SaveStatus { get; set; }
        [StringLength(1)]
        public string? SendFlag { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDateOfExhibition { get; set; }
        [StringLength(7)]
        public string? StrLocCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SubmissionDatetime { get; set; }
        [StringLength(1)]
        public string? SupplierIndFlag { get; set; }
        [StringLength(1)]
        public string? TnAgentFlag { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? TotalAmt { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? TotalCiffobAmt { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? TotalCustomsAmt { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? TotalCustomsRefundAmt { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? TotalExciseAmt { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? TotalExciseRefundAmt { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? TotalGstAmt { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? TotalGstRefundAmt { get; set; }
        [Column(TypeName = "decimal(5, 0)")]
        public decimal? TotalLineCount { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? TotalOtherAmt { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? TotalOtherRefundAmt { get; set; }
        [Column(TypeName = "decimal(8, 0)")]
        public decimal? TotalOutPackQty { get; set; }
        [StringLength(50)]
        public string? TotalOutPackQtyUomCode { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? TotalPayableAmt { get; set; }
        [StringLength(255)]
        public string? TradenetRemark { get; set; }
        [StringLength(10)]
        public string? TradenetType { get; set; }
        [StringLength(35)]
        public string? TranDetailLine1 { get; set; }
        [StringLength(35)]
        public string? TranDetailLine2 { get; set; }
        [StringLength(35)]
        public string? TranDetailLine3 { get; set; }
        [StringLength(35)]
        public string? TranDetailLine4 { get; set; }
        [StringLength(35)]
        public string? TranDetailLine5 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TrxDate { get; set; }
        [Column("UD1Line1")]
        [StringLength(102)]
        public string? Ud1line1 { get; set; }
        [Column("UD1Line2")]
        [StringLength(102)]
        public string? Ud1line2 { get; set; }
        [Column("UD1Line3")]
        [StringLength(102)]
        public string? Ud1line3 { get; set; }
        [Column("UD1Line4")]
        [StringLength(102)]
        public string? Ud1line4 { get; set; }
        [Column("UD1Line5")]
        [StringLength(102)]
        public string? Ud1line5 { get; set; }
        [Column("UD2Line1")]
        [StringLength(102)]
        public string? Ud2line1 { get; set; }
        [Column("UD2Line2")]
        [StringLength(102)]
        public string? Ud2line2 { get; set; }
        [Column("UD2Line3")]
        [StringLength(102)]
        public string? Ud2line3 { get; set; }
        [Column("UD2Line4")]
        [StringLength(102)]
        public string? Ud2line4 { get; set; }
        [Column("UD2Line5")]
        [StringLength(102)]
        public string? Ud2line5 { get; set; }
        [Column("UD3Line1")]
        [StringLength(102)]
        public string? Ud3line1 { get; set; }
        [Column("UD3Line2")]
        [StringLength(102)]
        public string? Ud3line2 { get; set; }
        [Column("UD3Line3")]
        [StringLength(102)]
        public string? Ud3line3 { get; set; }
        [Column("UD3Line4")]
        [StringLength(102)]
        public string? Ud3line4 { get; set; }
        [Column("UD3Line5")]
        [StringLength(102)]
        public string? Ud3line5 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? UnitPrice { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? UnitWt { get; set; }
        [StringLength(3)]
        public string? UpdateIndFlag { get; set; }
        [StringLength(11)]
        public string? UpdatePermitNo { get; set; }
        [Column(TypeName = "decimal(2, 0)")]
        public decimal? UpdateReqCount { get; set; }
        [StringLength(2)]
        public string? VesselCountry { get; set; }
        [StringLength(2)]
        public string? VesselType { get; set; }
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
