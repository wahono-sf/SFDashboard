using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("sits1")]
    public partial class Sits1
    {
        [StringLength(6)]
        public string? TrxNo { get; set; }
        [StringLength(10)]
        public string? ApptAgentCode { get; set; }
        [StringLength(80)]
        public string? ApptAgentName { get; set; }
        [StringLength(20)]
        public string? ApptAgentContact { get; set; }
        [StringLength(30)]
        public string? ApptAgentTel { get; set; }
        [StringLength(1)]
        public string? BankDrafFlag { get; set; }
        [StringLength(15)]
        public string? BankDrafNo { get; set; }
        [StringLength(13)]
        public string? BankDraftNo { get; set; }
        [StringLength(1)]
        public string? BankEndorseNo { get; set; }
        [StringLength(13)]
        public string? BankEndorseStampNo { get; set; }
        [StringLength(10)]
        public string? BillCurCre { get; set; }
        [StringLength(10)]
        public string? BillCurCsh { get; set; }
        [StringLength(10)]
        public string? BillingParty { get; set; }
        [StringLength(80)]
        public string? BillingPartyName { get; set; }
        [Column("BillRTCash")]
        [StringLength(20)]
        public string? BillRtcash { get; set; }
        [Column("BillRTCre")]
        [StringLength(20)]
        public string? BillRtcre { get; set; }
        [StringLength(10)]
        public string? BillToCash { get; set; }
        [StringLength(10)]
        public string? BillToCre { get; set; }
        [StringLength(30)]
        public string? BlNo { get; set; }
        [StringLength(30)]
        public string? BookingNo { get; set; }
        [StringLength(10)]
        public string? BreakBulkAgentCode { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? BuyTotal { get; set; }
        [StringLength(10)]
        public string? CarriageDv { get; set; }
        [StringLength(10)]
        public string? CarrierCode { get; set; }
        [StringLength(80)]
        public string? CarrierName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CashReceiveDate { get; set; }
        [StringLength(5)]
        public string? CashRecover { get; set; }
        [StringLength(5)]
        public string? CashRevenue { get; set; }
        [StringLength(8)]
        public string? CashStatusCode { get; set; }
        [StringLength(8)]
        public string? CollectFromCode { get; set; }
        [StringLength(80)]
        public string? CollectFromName { get; set; }
        [StringLength(50)]
        public string? Collectaddr1 { get; set; }
        [StringLength(50)]
        public string? Collectaddr2 { get; set; }
        [StringLength(50)]
        public string? Collectaddr3 { get; set; }
        [StringLength(50)]
        public string? Collectaddr4 { get; set; }
        [StringLength(50)]
        public string? CommodityDesc1 { get; set; }
        [StringLength(3)]
        public string? ComputerCode { get; set; }
        [StringLength(8)]
        public string? ConsigneeCode { get; set; }
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress1 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress2 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress3 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress4 { get; set; }
        [StringLength(50)]
        public string? ConsigneeContact { get; set; }
        [StringLength(10)]
        public string? ContractorCode { get; set; }
        [StringLength(50)]
        public string? ContractorName { get; set; }
        [StringLength(50)]
        public string? ContractorAddr1 { get; set; }
        [StringLength(50)]
        public string? ContractorAddr2 { get; set; }
        [StringLength(50)]
        public string? ContractorAddr3 { get; set; }
        [StringLength(50)]
        public string? ContractorAddr4 { get; set; }
        [StringLength(30)]
        public string? ConsigneeTel { get; set; }
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [StringLength(1)]
        public string? CreditCashFlag { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CrFrtCostAmt { get; set; }
        [Column("CrReceiveCostAMt", TypeName = "decimal(13, 2)")]
        public decimal? CrReceiveCostAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CrRevCostAmt { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(13)]
        public string? CustomBondClearNo { get; set; }
        [StringLength(1)]
        public string? CustomBondFlag { get; set; }
        [StringLength(13)]
        public string? CustomBondNo { get; set; }
        [StringLength(13)]
        public string? CustomBondRecepitNo { get; set; }
        [StringLength(6)]
        public string? CustomDv { get; set; }
        [StringLength(50)]
        public string? DeliveryAddress1 { get; set; }
        [StringLength(50)]
        public string? DeliveryAddress2 { get; set; }
        [StringLength(50)]
        public string? DeliveryAddress3 { get; set; }
        [StringLength(50)]
        public string? DeliveryAddress4 { get; set; }
        [StringLength(50)]
        public string? DeliveryInst1 { get; set; }
        [StringLength(50)]
        public string? DeliveryInst2 { get; set; }
        [StringLength(50)]
        public string? DeliveryInst3 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeliveryOrderDate { get; set; }
        [StringLength(10)]
        public string? DeliveryOrderNo { get; set; }
        [StringLength(3)]
        public string? DeliveryTerm { get; set; }
        [StringLength(10)]
        public string? DeliveryToCode { get; set; }
        [StringLength(80)]
        public string? DeliveryToName { get; set; }
        [StringLength(10)]
        public string? DeliveryUndeliveryCode { get; set; }
        [StringLength(5)]
        public string? DistrictC { get; set; }
        [StringLength(5)]
        public string? DistrictI { get; set; }
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocReleaseDate { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? DueAgentCollect { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? DueAgentPrepaid { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? DueCarrierCollect { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? DueCarrierPrepaid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Eta { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Etd { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExecuteDate { get; set; }
        [StringLength(30)]
        public string? ExportJobNo { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Factor { get; set; }
        [StringLength(30)]
        public string? FeederVesselName { get; set; }
        [StringLength(12)]
        public string? FeederVoyage { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? FinalAmt { get; set; }
        [StringLength(3)]
        public string? FinalCurr { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? FinalRate { get; set; }
        [StringLength(5)]
        public string? FirstViaCityCode { get; set; }
        [StringLength(5)]
        public string? FithViaCityCode { get; set; }
        [StringLength(5)]
        public string? FourthViaCityCode { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? FrtAmt { get; set; }
        [StringLength(3)]
        public string? Gst { get; set; }
        [Column("HBlNo")]
        [StringLength(30)]
        public string? HblNo { get; set; }
        [StringLength(9)]
        public string? HsCode { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? IataTot { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? InsuranceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InvAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InvCost { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InvDate { get; set; }
        [StringLength(10)]
        public string? InvNo { get; set; }
        [StringLength(8)]
        public string? InvStatus { get; set; }
        [StringLength(1)]
        public string? InvType { get; set; }
        [StringLength(2)]
        public string? JobMth { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [StringLength(50)]
        public string? JobRefNo { get; set; }
        [StringLength(1)]
        public string? KgLbFlag { get; set; }
        [StringLength(2)]
        public string? LastSeqNo { get; set; }
        [StringLength(15)]
        public string? LetterOfCreditNo { get; set; }
        public int? NoOf20ftContainer { get; set; }
        public int? NoOf40ftContainer { get; set; }
        public int? NoOf45ftContainer { get; set; }
        public int? NoOfDeliveryOrder { get; set; }
        public int? NoOfOriginBl { get; set; }
        [StringLength(10)]
        public string? NotifyNo { get; set; }
        [StringLength(80)]
        public string? NotifyName { get; set; }
        [StringLength(50)]
        public string? NotifyAddr1 { get; set; }
        [StringLength(50)]
        public string? NotifyAddr2 { get; set; }
        [StringLength(50)]
        public string? NotifyAddr3 { get; set; }
        [StringLength(50)]
        public string? NotifyAddr4 { get; set; }
        [Column("OBlNo")]
        [StringLength(30)]
        public string? OblNo { get; set; }
        [StringLength(3)]
        public string? Origin { get; set; }
        [StringLength(30)]
        public string? OriginBlNo { get; set; }
        [StringLength(1)]
        public string? Other { get; set; }
        [StringLength(1)]
        public string? PartialNo { get; set; }
        public int? Pcs { get; set; }
        public int? PcsOrRcp { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PermitDate { get; set; }
        [StringLength(15)]
        public string? PermitNo { get; set; }
        [StringLength(1)]
        public string? PerpaidOrCollect { get; set; }
        [StringLength(30)]
        public string? PlaceOfDelivery { get; set; }
        [StringLength(30)]
        public string? PlaceOfReceipt { get; set; }
        [StringLength(1)]
        public string? PostFlag { get; set; }
        [StringLength(5)]
        public string? ProfitShareFlag { get; set; }
        [StringLength(5)]
        public string? PortOfDischgCode { get; set; }
        [StringLength(5)]
        public string? PortOfLoadingCode { get; set; }
        [StringLength(50)]
        public string? PreparedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PrepareDate { get; set; }
        [StringLength(1)]
        public string? RateClass { get; set; }
        [StringLength(10)]
        public string? ReceiptNo { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? RecoverableFlag { get; set; }
        [StringLength(10)]
        public string? ReleaseBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReleaseDate { get; set; }
        [StringLength(50)]
        public string? ReleaseTo { get; set; }
        [StringLength(4)]
        public string? RelTime { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(50)]
        public string? Remark1 { get; set; }
        [StringLength(50)]
        public string? Remark2 { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Revenue { get; set; }
        [StringLength(5)]
        public string? Salesman { get; set; }
        [Column("SBlNo")]
        [StringLength(30)]
        public string? SblNo { get; set; }
        [StringLength(30)]
        public string? ScrItemCode { get; set; }
        [StringLength(3)]
        public string? SecondToDestCode { get; set; }
        [StringLength(5)]
        public string? SecondViaCityCode { get; set; }
        [StringLength(2)]
        public string? Sector { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? SellTot { get; set; }
        [StringLength(2)]
        public string? SeqNo { get; set; }
        [StringLength(12)]
        public string? ShipLineCode { get; set; }
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [StringLength(50)]
        public string? ShipperAddr1 { get; set; }
        [StringLength(50)]
        public string? ShipperAddr2 { get; set; }
        [StringLength(50)]
        public string? ShipperAddr3 { get; set; }
        [StringLength(50)]
        public string? ShipperAddr4 { get; set; }
        [StringLength(5)]
        public string? Site { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? TaxChgCollect { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? TaxChgPrepaid { get; set; }
        [StringLength(5)]
        public string? ThirdViaCityCode { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? TotAmtCollect { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? ToAmtLocal { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? TotChgWt { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? TotGrossWt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotGst { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotItem { get; set; }
        public int? TotPcs { get; set; }
        public int? TotQty { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotVol { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotWt { get; set; }
        [StringLength(17)]
        public string? UcrNo { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? ValChgCollect { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? ValChgPrepaid { get; set; }
        [StringLength(30)]
        public string? VesselAlpha { get; set; }
        [StringLength(10)]
        public string? ViaAgentCode { get; set; }
        [StringLength(80)]
        public string? ViaAgentName { get; set; }
        [StringLength(12)]
        public string? VoyageNo { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? WtChgCollect { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? WtChgPrepaid { get; set; }
        [StringLength(1)]
        public string? WtVal { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreatebyDate { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }

        [ForeignKey("CurrCode")]
        public virtual Glex1? CurrCodeNavigation { get; set; }
        [ForeignKey("DivisionCode")]
        public virtual Acdv1? DivisionCodeNavigation { get; set; }
    }
}
